using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Running;
using Newtonsoft.Json;

namespace BenchmarkDotNet;
class Program {
    public static void Main(string[] args) {
        Console.WriteLine("test");
        var summary = BenchmarkRunner.Run<ListCountBenchmark>();
        Console.ReadLine();
    }
}
[HtmlExporter]
[MemoryDiagnoser]
//[HideColumns(Column.RatioSD, Column.AllocRatio)]
[SimpleJob(RuntimeMoniker.Net80)]
public class ListCountBenchmark {
    private List<int> _list;

    [Params(1_000)]
    public int Count { get; set; }

    [GlobalSetup]
    public void GlobalSetup() {
        IEnumerable<int> range = Enumerable.Range(0, Count);

        _list = range.ToList();
    }
    //[Benchmark]
    //public int ListCountMethod() => _list.Count();

    //[Benchmark]
    //public int ListCountProperty() => _list.Count;

    [Benchmark]
    public void serializeNewtonSoft() {
        var json = JsonConvert.SerializeObject(_list);
        var obj = JsonConvert.DeserializeObject<List<int>>(json);
        Console.WriteLine(json);
    }
    [Benchmark]
    public void serializeSystem() {
        var json = System.Text.Json.JsonSerializer.Serialize(_list);
        var obj = System.Text.Json.JsonSerializer.Deserialize<List<int>>(json);
        Console.WriteLine(json);
    }
    [Benchmark]
    public void serializeNetJson() {
        var json = NetJSON.NetJSON.Serialize(_list);
        var obj = NetJSON.NetJSON.Deserialize<List<int>>(json);
        Console.WriteLine(json);
    }
}



