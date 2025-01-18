const express = require('express');
const sql = require('mssql');
const app = express();
const port = 3000;

const config = {
    user: 'sa', // better stored in an app setting such as process.env.DB_USER
    password: 'demo!100', // better stored in an app setting such as process.env.DB_PASSWORD
    server: '10.0.1.111', // better stored in an app setting such as process.env.DB_SERVER
    port: 1433, // optional, defaults to 1433, better stored in an app setting such as process.env.DB_PORT
    database: 'gadcert', // better stored in an app setting such as process.env.DB_NAME
    authentication: {
        type: 'default'
    },
    options: {
        encrypt: true
    }
}


app.get('/', (req, res) => {
  console.log(`Ricevuta richiesta`);
  connectAndQuery();

  res.send('Hello, World!');
});

async function connectAndQuery() {
    try {
        var poolConnection = await sql.connect(config);

        console.log("Reading rows from the Table...");
        var resultSet = await poolConnection.request().query(`SELECT TOP 20 * from tuser_token`);

        console.log(`${resultSet.recordset.length} rows returned.`);

        // output column headers
        var columns = "";
        for (var column in resultSet.recordset.columns) {
            columns += column + ", ";
        }
        console.log("%s\t", columns.substring(0, columns.length - 2));

        // output row contents from default record set
        resultSet.recordset.forEach(row => {
            console.log("%s\t%s", row.UserId, row.Token);
        });

        // close connection only when we're certain application is finished
        poolConnection.close();
    } catch (err) {
        console.error(err.message);
    }
}
app.listen(port, () => {
  console.log(`App listening at http://localhost:${port}`);
});