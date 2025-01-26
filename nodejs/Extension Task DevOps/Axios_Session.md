### Mantiene la sessione tra le varie richieste !

```js
const { response } = require('express');
const crypto = require('crypto');

function generateHmacSha256Signature(secret, stringToSign) {
    // Convert secret and stringToSign to buffers
    const secretBuffer = Buffer.from(secret, 'utf-8');
    const stringToSignBuffer = Buffer.from(stringToSign, 'utf-8');
  
    // Create HMAC-SHA256
    const hmac = crypto.createHmac('sha256', secretBuffer);
  
    // Update with the string to sign
    hmac.update(stringToSignBuffer);
  
    // Generate the HMAC in bytes, and convert to base64
    const signature = hmac.digest('base64');
    return signature;
  }
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
    console.log('setSession: ', response.data);
    return response.data; // Return the data, this will be the parameter of .then()
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
    console.log('getSession: ', response.data);
    return response.data;
}

async function publish(){
    try{
        var secret = "ciccio";
        var filePath = "D:\\Project_Pixelo\ProviderManager\\js.zip"
        //var stringToSign = `${timestamp}:$filePath`;
        var stringToSign = filePath;

        const signature = generateHmacSha256Signature(secret, stringToSign);
        console.log('Signature:', signature);

        //TODO: passare i parametri corretti
        const response = await axiosInstance.post('https://jobschedulerpreprod.pixelo.it/DevOpsListener/CapturePipelineDevopsPublish?idSector=1&description=blablabla', {});
        console.log('publish: ', response.data);
        return response.data;
    } catch (error) {
        console.log('publish error STATUS: ', error);
        return response.status;
    }
}

setSession()
    .then((data) => {
        if (data && data.Session == "test") {
            console.log("Session is valid can get session");
            getSession()
                .then(() => {
                    console.log('risultato publish', publish());
                });
        } else {
            console.log("Session is invalid cannot get session");
        }
    });
```
