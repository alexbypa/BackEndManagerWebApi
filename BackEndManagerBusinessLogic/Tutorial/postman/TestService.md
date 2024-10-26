## Lettura FrontEnd e parsing Querytring e XML ##
```javascript
//var jsonData = JSON.parse(responseBody);
var xml = xml2Json(responseBody);
var gameSessionID = xml.Message.ListData.Record.Column.find(col => col.$.Name == "GameSessionID").$.Value;
var url = xml.Message.ListData.Record.Column.find(col => col.$.Name == "url").$.Value;
console.log("url : " + url);
var externalToken = getQueryParam(url, "externalToken");
console.log("gameSessionID : " + gameSessionID);
pm.environment.set("ExternalToken",externalToken);
console.log("externalToken : " + externalToken);
pm.environment.set("gameSessionID",gameSessionID);

pm.test("Status test", function () {
    pm.response.to.have.status(200);
});

function getQueryParam(url, param) {
    var queryString = url.split('?')[1]; // Prendi la parte della query string
    var params = queryString.split('&'); // Dividi in singoli parametri
    for (var i = 0; i < params.length; i++) {
        var paramPair = params[i].split('=');
        if (paramPair[0] === param) {
            return paramPair[1]; // Restituisci il valore del parametro desiderato
        }
    }
    return null;
}
```


##  parsing Json and save enviroment ##
```javascript
//checks if response has permanent token and tries to set it as variable, if not then sets original external token instead
var jsonData = JSON.parse(pm.response.text());
console.log("permanentExternalToken : " + jsonData.permanentExternalToken);
pm.environment.set("permanentExternalToken",jsonData.permanentExternalToken);

//checks if username in request and response match
pm.test("Status test", function () {
    pm.response.to.have.status(200);
});
```

