```javascript
var jsonObject = xml2Json(pm.response.text());
var manifestazioni = jsonObject["soap:Envelope"]["soap:Body"]["s71002_ManifestazioniResponse"]["s71002_ManifestazioniResult"]["manifestazioni"]["ManifestazioniBeanResponse"];
var text = "";

for (let i = 0; i <  manifestazioni.length; i++) {
  console.info(manifestazioni[i]["manifestazione"] + " " + manifestazioni[i]["descrizione"] + "[" + manifestazioni[i]["sigla"] + "]");
}

var filter = jsonObject["soap:Envelope"]["soap:Body"]["s71002_ManifestazioniResponse"]["s71002_ManifestazioniResult"]["info_download"]["filter"];

console.info("filter:" + filter) 
console.info("inizio:" + pm.environment.get("inizio"));
console.info("fine:" + pm.environment.get("fine"));
console.info("step:" + pm.environment.get("step"));

if (filter > parseInt(pm.environment.get("fine")) && parseInt(pm.environment.get("step")) < 70 ){
    pm.environment.set("inizio", parseInt(pm.environment.get("inizio")) + 30);
    pm.environment.set("fine", parseInt(pm.environment.get("fine")) + 30);
    pm.environment.set("step", parseInt(pm.environment.get("step")) + 1);
    console.warn(pm.environment);
} else {
    console.error("Raggiunta fine interrogazione")
}
