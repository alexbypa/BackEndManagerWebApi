```javascript
const Utils = {
    getJsonFromResponse(){
        return JSON.parse(pm.response.text());
    },
    ValidateOnJsonResponse(ValidateValue, jsonData){
        pm.test(`Validate deve essere ${jsonData.Validate}`, function () { 
                pm.expect(jsonData.Validate).is.to.equal(ValidateValue, `mi aspettavo: ${ValidateValue}, Arrivato invece: ${jsonData.Validate}`);
        });
    },
    CheckValueOnJsonResponse(jsonData, prop, value){
        pm.test(`${prop} deve essere ${value}`, function () { 
                pm.expect(jsonData[prop]).is.to.equal(value, `mi aspettavo: ${prop} valorizzato a ${value}, Arrivato invece: ${jsonData[prop]}`);
        });
    },
    ValidateHttpStatus(httpStatusCode){
        pm.test(`HttpStatus deve essere ${httpStatusCode}`, function () {
            pm.response.to.have.status(httpStatusCode, `mi aspettavo: ${httpStatusCode}, Arrivato invece: ${pm.response.httpStatusCode}`);
        });
    },
    CheckIfPropertyContainText(jsonData, prop, textToSearch){
        console.log(jsonData);
        var property = jsonData[prop];
        pm.test(`La risposta deve contenere dentro ${prop} il testo ${textToSearch}`, function () { 
            pm.expect(property).is.to.contains(textToSearch, `Non ho trovato il testo {textToSearch}`);
        });
    },
    ResponseMustHaveOnlytheseProperties(jsonData, expectedProperties){
        pm.test(`la risposta deve contenere solo ${expectedProperties}`, function () {
            //var expectedProperties = ["Validate", "ErrDesc"];
            expectedProperties.forEach(function(property) {
                pm.expect(jsonData).to.have.property(property);
            });
            var actualProperties = Object.keys(jsonData);
            pm.expect(actualProperties.length).to.equal(expectedProperties.length, "Ci sono proprietà in più nella risposta");
        })
    },
    PropertyOnJsonMustBeAboveThan(jsonData, prop){
        pm.test(`La proprietà ${prop} deve essere maggiore di zero`, function () { 
            pm.expect(jsonData[prop]).to.be.above(0, `${prop} non è maggiore di zero`);
        });
    },
    PropertyMustBeGuid(jsonData, prop){
        pm.test(`${prop} deve essere un GUID`, function () {            
        const guidRegex = /^[0-9a-fA-F]{8}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{12}$/;
        pm.expect(guidRegex.test(jsonData[prop]), `MI aspettavo un Guid arrivato invece ${jsonData[prop]}`).to.be.true; 
    });
    }
}
module.exports = Utils;
```
