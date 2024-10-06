```javascript
pm.test("Validate must be 0",function(){
    var xml = xml2Json(pm.response.text());
    pm.expect(xml.Message.Status.Validate).to.equal("0");
    
    var Balance = xml.Message.ListData.Record.Column.find(col => col.$.Name == "Balance").$.Value;
    pm.environment.set("Balance", Balance);
})
