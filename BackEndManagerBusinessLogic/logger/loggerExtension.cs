using Microsoft.Extensions.Configuration;
using Serilog;
using Serilog.Events;
using Serilog.Sinks.Email;
using Serilog.Sinks.MSSqlServer;
using System.Data;
using TelegramSink;

namespace BackEndManagerBusinessLogic.logger {
    internal class loggerExtension {
    }
}
public class loggerExtension {
    //TODO: Inserire tutte le opzioni di serilog del controller per ricordarsi facilmente di tutte le funzionalità esposte
    //TODO: Riprendere le altre tipologie di estensione Enrich etc etc json ....
    public static readonly ILogger log = null;
    static loggerExtension() {
        var configuration = new ConfigurationBuilder()
        .AddJsonFile("appsettings.json")
        .Build();

        var loggingConfigurationSection = configuration.GetSection("SerilogConfiguration");
        var loggingConfig = loggingConfigurationSection.Get<SerilogConfiguration>();

        log = new LoggerConfiguration()
            .ReadFrom.Configuration(configuration)
            .WriteTo.Conditional(evt => {
                if (loggingConfig != null && loggingConfig.SerilogCondition.FirstOrDefault(level => level.Level != null && level.Sink.Equals("MSSqlServer") && level.Level.Contains(evt.Level.ToString())) != null)
                    return true;
                else
                    return false;
            }, wt => wt.MSSqlServer(configuration.GetConnectionString(loggingConfig.SerilogOption.MSSqlServer.connectionString),
            new MSSqlServerSinkOptions {
                TableName = loggingConfig.SerilogOption.MSSqlServer.sinkOptionsSection.tableName,
                SchemaName = loggingConfig.SerilogOption.MSSqlServer.sinkOptionsSection.schemaName,
                AutoCreateSqlTable = loggingConfig.SerilogOption.MSSqlServer.sinkOptionsSection.autoCreateSqlTable,
                BatchPostingLimit = loggingConfig.SerilogOption.MSSqlServer.sinkOptionsSection.batchPostingLimit,
                BatchPeriod = TimeSpan.Parse(loggingConfig.SerilogOption.MSSqlServer.sinkOptionsSection.period)
            }, columnOptions: GetColumnOptions()))
            .WriteTo.Conditional(evt => {
                return (loggingConfig != null && loggingConfig.SerilogCondition.FirstOrDefault(item => item.Level != null && item.Sink.Equals("File") && item.Level.Contains(evt.Level.ToString())) != null);
            }, wt => wt.File("logs/log.txt"))
            .WriteTo.Conditional(evt => {
                if (loggingConfig != null && loggingConfig.SerilogCondition.FirstOrDefault(level => level.Level != null && level.Sink.Equals("ElasticSearch") && level.Level.Contains(evt.Level.ToString())) != null)
                    return true;
                else
                    return false;
            }, wt => wt.Elasticsearch())
            .WriteTo.Conditional(evt => {
                return (loggingConfig != null && loggingConfig.SerilogCondition.FirstOrDefault(item => item.Level != null && item.Sink.Equals("Email") && item.Level.Contains(evt.Level.ToString())) != null);
            }, wt => wt.Email(new EmailSinkOptions { From = "alexbypa@gmail.com" })) //TODO:
            .WriteTo.Conditional(evt => {
                if (loggingConfig != null && loggingConfig.SerilogCondition.FirstOrDefault(item => item.Level != null && item.Sink.Equals("Telegram") && item.Level.Contains(evt.Level.ToString())) != null)
                    return true;
                else
                    return false;
            }, wt => wt.TeleSink(loggingConfig.SerilogOption.TelegramOption.Api_Key, loggingConfig.SerilogOption.TelegramOption.chatId))
            .WriteTo.Console(LogEventLevel.Information)
            .CreateLogger();
    }
    public Dictionary<string, List<int>> loglevels { get; set; }

    /// <summary>
    /// method to write log
    /// </summary>
    /// <param name="Action">Action is the parameter that indicates the area of ​​interest in which the log is being written</param>
    /// <param name="IdTransaction">IdTransaction is the reference code for retrieving the log (for example, if you use a warehouse program, each operation on a product could be the barcode of the item)</param>
    /// <param name="level">level is the LogEventLevel of serilog</param>
    /// <param name="ex">is the text of the error to report</param>
    /// <param name="message">indicates the log message</param>
    /// <param name="args">are additional parameters that can help identify particular scenarios</param>
    public static async void TraceAsync(string Action, string IdTransaction, LogEventLevel level, Exception? ex, string message, params object[] args) {
        await Task.Run(() => TraceSync(Action, IdTransaction, level, ex, message, args));
    }

    /// <summary>
    /// method to write log
    /// </summary>
    /// <param name="Action">Action is the parameter that indicates the area of ​​interest in which the log is being written</param>
    /// <param name="IdTransaction">IdTransaction is the reference code for retrieving the log (for example, if you use a warehouse program, each operation on a product could be the barcode of the item)</param>
    /// <param name="level">level is the LogEventLevel of serilog</param>
    /// <param name="ex">is the text of the error to report</param>
    /// <param name="message">indicates the log message</param>
    /// <param name="args">are additional parameters that can help identify particular scenarios</param>
    public static void TraceSync(string Action, string IdTransaction, LogEventLevel level, Exception? ex, string message, params object[] args) {
        message += " {IdTransaction} {MachineName} {Action}";
        List<object> arguments = new List<object>();
        if (args != null)
            arguments = args.ToList();

        arguments.Add(IdTransaction);
        arguments.Add(Environment.MachineName);
        arguments.Add(Action);

        Thread.Sleep(500);

        if (message.Split("{").Length - 1 != arguments.Count) {
            log.Error(new Exception("parametri non validi su loggerExtension"), message);
        }

        if (level == LogEventLevel.Debug)
            log.Debug(message, arguments.ToArray());
        if (level == LogEventLevel.Information)
            log.Information(message, arguments.ToArray());
        if (level == LogEventLevel.Warning)
            log.Warning(message, arguments.ToArray());
        if (level == LogEventLevel.Error)
            log.Error(ex, message, arguments.ToArray());
        if (level == LogEventLevel.Fatal)
            log.Fatal(ex, message, arguments.ToArray());

    }
    public static ColumnOptions GetColumnOptions() {
        var columnOptions = new ColumnOptions();
        // Override the default Primary Column of Serilog by custom column name
        //columnOptions.Id.ColumnName = "LogId";

        // Removing all the default column
        columnOptions.Store.Add(StandardColumn.LogEvent);
        //columnOptions.Store.Remove(StandardColumn.MessageTemplate);
        //columnOptions.Store.Remove(StandardColumn.Properties);

        // Adding all the custom columns
        columnOptions.AdditionalColumns = new List<SqlColumn> {
            new SqlColumn { DataType = SqlDbType.VarChar, ColumnName = "IdTransaction", DataLength = 250, AllowNull = false },
            new SqlColumn { DataType = SqlDbType.VarChar, ColumnName = "MachineName", DataLength = 250, AllowNull = false },
            new SqlColumn { DataType = SqlDbType.VarChar, ColumnName = "Action", DataLength = 250, AllowNull = false }
        };
        return columnOptions;
    }
}


// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
public class ColumnOptionsSection {
    public List<string> addStandardColumns { get; set; }
    public List<string> removeStandardColumns { get; set; }
    public List<CustomColumn> customColumns { get; set; }
}

public class CustomColumn {
    public string ColumnName { get; set; }
    public string DataType { get; set; }
    public int DataLength { get; set; }
    public bool AllowNull { get; set; }
}

public class MSSqlServer {
    public string connectionString { get; set; }
    public SinkOptionsSection sinkOptionsSection { get; set; }
    public ColumnOptionsSection columnOptionsSection { get; set; }
}

public class SerilogConfiguration {
    public List<SerilogCondition> SerilogCondition { get; set; }
    public SerilogOption SerilogOption { get; set; }
}

public class SerilogCondition {
    public string Sink { get; set; }
    public List<string> Level { get; set; }
}

public class SerilogOption {
    public MSSqlServer MSSqlServer { get; set; }
    public TelegramOption TelegramOption { get; set; }
}
public class TelegramOption {
    public string Api_Key { get; set; }
    public string chatId { get; set; }
}
public class SinkOptionsSection {
    public string tableName { get; set; }
    public string schemaName { get; set; }
    public bool autoCreateSqlTable { get; set; }
    public int batchPostingLimit { get; set; }
    public string period { get; set; }
}
