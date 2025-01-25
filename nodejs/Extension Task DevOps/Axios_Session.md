### Mantiene la sessione tra le varie richieste !

```js
function createAxios() {
    const axios = require('axios');
    return axios.create({withCredentials: true});
}
const axiosInstance = createAxios();

// 2. Make sure you save the cookie after login.
// I'm using an object so that the reference to the cookie is always the same.
const cookieJar = {
    myCookies: undefined,
};

async function setSession() {
    const response = await axiosInstance.post('https://jobschedulerpreprod.pixelo.it/DevOpsListener/SetSession', {});
    cookieJar.myCookies = response.headers['set-cookie'];
    console.log(`setSession: ${response.data}`);
}

// 3. Add the saved cookie to the request.
async function getSession() {
    // read the cookie and set it in the headers
    const response = await axiosInstance.get('https://jobschedulerpreprod.pixelo.it/DevOpsListener/GetSession',
        {
            headers: {
                cookie: cookieJar.myCookies,
            },
        });
    if (response.data.Session == "test"){
        console.log("Session is valid");
    } else {
        console.log("Session is invalid");
    }
    console.log(`getSession: ${response.data}`);
}

setSession().then(() => getSession());
//getSession();
```
