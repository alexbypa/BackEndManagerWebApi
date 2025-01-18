const  config = {
  user:  'sa', // sql user
  password:  'demo!100', //sql user password
  server:  '10.0.1.111', // if it does not work try- localhost
  database:  'gadcert',
  options: {
    trustedconnection:  true,
    enableArithAbort:  true,
    instancename:  'SQLEXPRESS'  // SQL Server instance name
  },
  port:  1433
}

module.exports = config;