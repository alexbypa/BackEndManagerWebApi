```javascript
let jsonData = pm.response.json();
//   jsonData.tasks.forEach(function(item) {
//       console.log(`Name: ${item.displayOrder}, Age: ${item.decimalDisplayOrder}`);
//   });

//TODO: usare i tag "lavorazione interna" 123517
jsonData.tasks.forEach(function(item) {
    //console.log(`task ${item.name}`);
     item.assignees.forEach(function(users){
        var ismine = false;
        
        if (users.id==77376){
            console.log(`task ${item.name} (https://pixelo.teamwork.com/app/tasks/${item.id}) con scadenza ${item.dueDate}} assegnato a me`);
        }
     })
});

/*
filteredItems.forEach(function(item) {
    pm.test(`L'età di ${item.name} è maggiore di 30`, function() {
        pm.expect(item.displayOrder).to.be.above(30);
    });
});
*/
