```javascript
pm.test("Balance updated correctly | Bet amount: "+pm.environment.get("betAmount")+" | Balance after: "+jsonData.balance.real, function () { 
        pm.expect(+jsonData.balance.real).is.to.equal(+pm.environment.get("balance_hubtest8")-(+pm.environment.get("betAmount")));
        pm.environment.set("balance_hubtest8", jsonData.balance.real);
    });
