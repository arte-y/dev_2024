// Gestione di file JSON in C# con la libreria Newtonsoft.Json
// Installare la libreria con il comando: dotnet add package Newtonsoft.Json

using Newtonsoft.Json; // aggiungere il riferimento alla libreria

// Letture e scritture di file JSON
/*
{
  "nome": "nome1",
  "cognome": "cognome1",
  "eta": "20"
}
*/

string path = @"test.json"; // in questo caso al file è nella stessa cartella del programma
string json = File.ReadAllText(path); // legge il contenuto del file

// esempio di deserializzazione di un ofile JSON

dynamic obj = JsonConvert.DeserializeObject(json); // deserializza il json in un oggetto dinamico
Console.WriteLine($"nome: {obj.nome} cognome: {obj.cognome} eta: {obj.eta}"); // stampa il

// esempio di deserializzazione di un file JSON con piu livelli


/*
{
  "nome": "Mario",
  "cognome": "Rossi",
  "eta": "30"
  "indirizzo": {
        "via": "Via Roma",
        "citta": "Roma"
  }
}
*/

string path2 = @"test2.json"; // in questo caso al file è nella stessa cartella del programma
string json2 = File.ReadAllText(path2); // legge il contenuto del file

dynamic obj2 = JsonConvert.DeserializeObject(json2); // deserializza il file
Console.WriteLine($"nome: {obj2.nome} cognome: {obj2.cognome} eta: {obj2.eta} via{obj2.indirizzo.via} citta:{obj2.indirizzo.citta}"); // stampa il contenuto


// esempio di serializzazione di un oggetto in un file JSON
/*
{
  "nome": "Mario Rossi",
  "età": 30,
  "impiegato": true,
  "indirizzo": {
    "via": "Via Roma 10",
    "città": "Roma",
    "CAP": "00100"
  },
  "numeriditelefono": [
    {"tipo": "casa", "numero": "1234-5678"},
    {"tipo": "ufficio", "numero": "8765-4321"}
  ],
  "lingueParlate": ["italiano", "inglese", "spagnolo"],
  "sposato": false,
  "patente": null
}
*/

string path3 = @"test3.json"; // in questo caso al file è nella stessa cartella del programma
string json3 = File.ReadAllText(path3); // legge il contenuto del file

dynamic obj3 = JsonConvert.DeserializeObject(json3); // deserializza il file
Console.WriteLine($"nome: {obj3.nome} eta:{obj3.eta} impiegato:{obj3.impiegato} via:{obj3.indirizzo.via} citta: {obj3.indirizzo.citta} CAP:{obj3.indirizzo.cap}"); // stampa il contenuto
Console.WriteLine($"numeri di telefono:{obj3.numeriDiTelefono[1].tipo} numero: {obj3.numeriDiTelefono[1].numero}"); // stampa il file
Console.WriteLine($"Lingua: {obj3.lingueParlate[1]}"); // stampa il file
Console.WriteLine($"Sposato: {obj3.sposato}"); // stampo se è sposato
Console.WriteLine($"Patente: {obj3.patente}"); // stampo se ha la patente
