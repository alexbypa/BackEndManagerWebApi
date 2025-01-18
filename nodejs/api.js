var  Db = require('./dboperations');
var  Order = require('./tuser_token.js');
var  express = require('express');
var  bodyParser = require('body-parser');
var  cors = require('cors');
var  app = express();
const sql = require('mssql');

var  router = express.Router();

app.use(bodyParser.urlencoded({ extended:  true }));
app.use(bodyParser.json());
app.use(cors());

app.use('/api', router);

router.use((request, response, next) => {
  console.log("Intercettata richiesta");
  next();
});

router.route('/get').get((request, response) => {
  const userid = request.query.userid
  Db.getUserToken(userid).then((data) => {
    response.json(data[0]);
  })
})

router.route('/set').get((request, response) => {
  const userid = request.query.userid;
  const token = request.query.token;
  Db.setUserToken(userid, token);
  Db.getUserToken(userid).then((data) => {
    response.json(data[0]);
  })
})

router.route('/shutdown').get((request, response) => {  console.log('Ricevuta richiesta di arresto');
  // Esegui le operazioni di pulizia
  response.send('Arresto in corso...');
  process.exit(0);
});

var  port = process.env.PORT || 1433;
app.listen(port);
console.log('Order API is runnning at ' + port);
