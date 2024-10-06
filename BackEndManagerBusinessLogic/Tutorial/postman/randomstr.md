```javascript
function randomStr(len, arr) { 
            var ans = ''; 
            for (var i = len; i > 0; i--) { 
                ans +=  
                  arr[Math.floor(Math.random() * arr.length)]; 
            } 
            return ans; 
        } 
pm.environment.set("refid", randomStr(20, '1234567890abcdefghijklmnopqrstuvwxyz'))
