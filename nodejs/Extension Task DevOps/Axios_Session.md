## Mantiene la sessione tra le varie richieste !

```js
const { response } = require('express');
const crypto = require('crypto');
const fs = require('fs').promises; // Use promises-based fs API
const FormData = require('form-data');
const { Blob } = require('node:buffer')


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
    return axios.create({ withCredentials: true });
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

async function publish() {
    try {
        var secret = "cannolidipiana.che.suboni";//TODO: passare la secret corretta tramite il file di configurazione
        var filePath = "C:\\Repository\\node\\index.js"
        var timestamp = Math.floor(Date.now() / 1000);
        var stringToSign = `${timestamp}:index.js`;
        
        const signature = generateHmacSha256Signature(secret, stringToSign);
        console.log('Signature:', signature);

        const fileBuffer = await fs.readFile(filePath);
        console.log('File buffer:', fileBuffer);
        const formData = new FormData();
        const listFiles = [{"fileName":"index.json","pathDirectory":"/BetSoftGame"}];
        formData.append('index.js', fileBuffer, 'index.js'); //TODO: passare il file corretto tramite il path
        formData.append('description', "description"); //  add the description parameter
        formData.append('listFiles', JSON.stringify(listFiles)); //  
        
        console.log(cookieJar.myCookies);
        //TODO: passare i parametri corretti
        const response = await axiosInstance.post(
            'https://jobschedulerpreprod.pixelo.it/DevOpsListener/CapturePipelineDevopsPublish?idSector=1&description=blablabla',
            formData
            , {
                headers: {
                    ...formData.getHeaders(),
                    'X-Signature': signature,
                    'X-timestamp': Math.floor(Date.now() / 1000),
                    'RequestByUser': 'achiodo',//TODO: passare il nome utente
                    cookie: cookieJar.myCookies
                }
            });
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
                    // console.log('risultato publish...TODO');
                    console.log('risultato publish', publish());
                });
        } else {
            console.log("Session is invalid cannot get session");
        }
    });
```
