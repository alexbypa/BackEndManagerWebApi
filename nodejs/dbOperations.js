var  config = require('./dbconfig');
const  sql = require('mssql');

async  function  getUserToken(userid) {
  try {
    let  pool = await  sql.connect(config);
    let  products = await  pool.request()
    .input('userId', sql.VarChar, userid) 
	.query("SELECT * from tUser_Token where UserID = @userid");
    return  products.recordsets;
  }
  catch (error) {
    console.log(error);
  }
}	
async  function  setUserToken(userid, newtoken) {
  try {
    let  pool = await  sql.connect(config);
    let  products = await  pool.request()
    .input('userId', sql.VarChar, userid) 
    .input('token', sql.VarChar, newtoken) 
	.query("update top (1) tUser_Token set Token = @token where UserID = @userid");
    return  products.recordsets;
  }
  catch (error) {
    console.log(error);
  }
}

module.exports = {
  getUserToken:  getUserToken,
  setUserToken:  setUserToken
}