In PostgreSQL, non esiste un concetto diretto di "stored procedure di sistema" equivalente a quelle nel database `master` di SQL Server. Tuttavia, è possibile creare una funzione o una procedura disponibile globalmente per tutti i database del sistema. Questo si fa creando la funzione o procedura all'interno del database `postgres` o aggiungendola in uno schema condiviso che può essere incluso nella ricerca dei database.

Ecco come fare:

---

### 1. **Creare una Funzione di Sistema**
Le funzioni in PostgreSQL possono essere utilizzate come "stored procedure". Per renderle disponibili in tutti i database, è necessario creare la funzione nel database `postgres` o in uno schema condiviso.

#### Creazione della Funzione
```sql
CREATE OR REPLACE FUNCTION global_function_example(param1 TEXT)
RETURNS TEXT
LANGUAGE plpgsql
AS $$
BEGIN
    RETURN 'Hai passato: ' || param1;
END;
$$;
```

### 2. **Posizionare la Funzione in uno Schema Condiviso**
È una buona pratica utilizzare uno schema dedicato per funzioni "di sistema". Ad esempio:

#### Creare uno Schema
```sql
CREATE SCHEMA global_utils;
```

#### Spostare la Funzione nello Schema
```sql
ALTER FUNCTION global_function_example(TEXT) SET SCHEMA global_utils;
```

### 3. **Aggiungere lo Schema al `search_path`**
Per rendere lo schema visibile di default a tutti i database o utenti, puoi aggiungerlo al percorso di ricerca.

#### Modificare il `search_path` per Tutti gli Utenti
```sql
ALTER DATABASE postgres SET search_path TO global_utils, public;
```

Oppure, per uno specifico utente:
```sql
ALTER ROLE your_user SET search_path TO global_utils, public;
```

---

### 4. **Creare una Procedura (Introduzione da PostgreSQL 11)**
Se hai bisogno di una procedura che supporti transazioni (ad esempio, con `CALL`), usa la sintassi `CREATE PROCEDURE`.

#### Esempio di Procedura
```sql
CREATE OR REPLACE PROCEDURE global_procedure_example(param1 TEXT)
LANGUAGE plpgsql
AS $$
BEGIN
    RAISE NOTICE 'Hai passato: %', param1;
END;
$$;
```

#### Eseguire la Procedura
```sql
CALL global_procedure_example('Test Param');
```

---

### 5. **Rendere Disponibili Funzioni e Procedure a Tutti i Database**
Se desideri rendere una funzione o procedura disponibile a tutti i database del server PostgreSQL:

1. **Usa un'estensione condivisa**:
   - Crea un'estensione con le tue funzioni e procedure.
   - Installa l'estensione su tutti i database dove vuoi usarla.

2. **Script per Creazione Automatica**:
   - Crea uno script SQL che definisce le funzioni/procedure desiderate.
   - Esegui lo script su ogni database usando un tool come `psql` o uno script di automazione.

---

### Conclusione
Creare funzioni o procedure disponibili globalmente su PostgreSQL richiede di organizzarle in uno schema condiviso e configurare correttamente il `search_path`. In alternativa, puoi adottare approcci come estensioni personalizzate per maggiore modularità. 


### Per ottenere un Elenco di Utenti
```sql
SELECT usename FROM pg_user;
```
