const tl = require('azure-pipelines-task-lib/task');

async function run() {
    try {
        // Leggi un input dal task.json
        const myInput = tl.getInput('myInput', true); // 'true' significa che è obbligatorio
        console.log(`Il valore dell'input è: ${myInput}`);

        // Esegui una logica personalizzata
        if (myInput === 'test') {
            tl.setResult(tl.TaskResult.Succeeded, 'Il task è stato completato con successo!');
        } else {
            tl.setResult(tl.TaskResult.Failed, 'Input non valido!');
        }
    } catch (err) {
        // Gestione errori
        tl.setResult(tl.TaskResult.Failed, `Errore durante l'esecuzione del task: ${err.message}`);
    }
}

run();
