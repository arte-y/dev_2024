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



//! esempio di serializzazione di un oggetto in un file JSON

// // chieo al utente di inserire i dati
// Console.WriteLine("Inserisci il nome:");
// string nome = Console.ReadLine();
// Console.WriteLine("Inserisci il cognome:");
// string cognome = Console.ReadLine();
// Console.WriteLine("Inserisci l'età:");
// int eta = int.Parse(Console.ReadLine());
// Console.WriteLine("Inserici indirizzo:");
// string indirizzo = Console.ReadLine();
// Console.WriteLine("Inserisci la città:");
// string citta = Console.ReadLine();

// // creo un oggetto con i dati inseriti
// dynamic obj4 = new
// {
//     nome = nome,
//     cognome = cognome,
//     eta = eta,
//     indirizzo = indirizzo,
//     citta = citta
// };

// // serializzo l'oggetto

// string json4 = JsonConvert.SerializeObject(obj4, Formatting.Indented);


// scrivo il file
// File.WriteAllText("test4.json", json4);

// uso di formatting indented: posso formattare il file in modo che sia più leggibile andando a copa dop ogni virgula e parentesi graffa
// File.WriteAllText("test4.json", json4);

//! esmepio di scrittura di dati in un file JSON con serializzazione con più livelli

var obj5 = new
{
    nome = "Mario",
    cognome = "Rossi",
    eta = 30,
    impiegato = true,
    indirizzo = new
    {
        via = "Via Roma 10",
        citta = "Roma",
        CAP = "00100"
    },
    numeriDiTelefono = new[]
    {
        new { tipo = "casa", numero = "1234-5678" },
        new { tipo = "ufficio", numero = "8765-4321" }
    },
    lingueParlate = new[] { "italiano", "inglese", "spagnolo" },
    sposato = false,
    patente = (string)null
};

string json5 = JsonConvert.SerializeObject(obj5, Formatting.Indented); // serializzo l'oggetto
File.WriteAllText("test5.json", json5); // scrivo il file

// Esempio di scrittura di dati in un file JSON

//creo un array di oggetti

var obj6 = new[]
{
    new { nome = "Mario", cognome = "Rossi", eta = 30 },
    new { nome = "Luca", cognome = "Bianchi", eta = 25 },
    new { nome = "Paolo", cognome = "Verdi", eta = 35 }
};

// serializzo l'array
string json6 = JsonConvert.SerializeObject(obj6, Formatting.Indented);

// scrivo il file
File.WriteAllText("test6.json", json6);

//! 07 esempio di aggiunta di un oggetto ad un file JSON

// leggo il file
string json7 = File.ReadAllText("test6.json");
// deserializzo il file
dynamic obj7 = JsonConvert.DeserializeObject(json7);
// aggiungo un oggetto all'array
var obj7new = new { nome = "Tamer", cognome = "Yilmaz", eta = 29};
// converto l'oggetto in un array di oggetti dinamici
List<dynamic> list = obj7.ToObject<List<dynamic>>();
list.Add(obj7new);
// serializzo l'array
string json7new = JsonConvert.SerializeObject(list, Formatting.Indented);
// scrivo il file
File.WriteAllText("test6.json", json7new);


//! 08 esempio di eliminazione di un oggetto da un file JSON
 // leggo il file
string json8 = File.ReadAllText("test6.json");
// deserializzo il file
dynamic obj8 = JsonConvert.DeserializeObject(json8);
// rimuovo un oggetto dall'array
List<dynamic> list8 = obj8.ToObject<List<dynamic>>();
list8.RemoveAt(1);
// serializzo l'array
string json8new = JsonConvert.SerializeObject(list8, Formatting.Indented);
// scrivo il file
File.WriteAllText("test6.json", json8new); 

//! 09 esempio di modifica di un oggetto in un file JSON

// leggo il file
string json9 = File.ReadAllText("test6.json");
// deserializzo il file
dynamic obj9 = JsonConvert.DeserializeObject(json9);
// modifico un oggetto dell'array
List<dynamic> list9 = obj9.ToObject<List<dynamic>>();
list9[0].nome= "Mario";
list9[0].cognome = "Calligaris";
list9[0].eta = 38;
// serializzo l'array
string json9new = JsonConvert.SerializeObject(list9, Formatting.Indented);
// scrivo il file
File.WriteAllText("test6.json", json9new);

//! 10 esempio di lettura di un file json con un array di oggetti

/*
[
  {
    "nome": "Mario",
    "cognome": "Calligaris",
    "eta": 28
  },
  {
    "nome": "Paolo",
    "cognome": "Verdi",
    "eta": 35
  },
  {
    "nome": "Tamer",
    "cognome": "Yilmaz",
    "eta": 29
  }
]
*/

string path10 = @"test6.json"; // in questo caso al file è nella stessa cartella del programma
string json10 = File.ReadAllText(path10); // legge il contenuto del file

dynamic obj10 = JsonConvert.DeserializeObject(json10); // deserializza il file

// stampo il file
foreach (var item in obj10)
{
    Console.WriteLine($"nome: {item.nome} cognome: {item.cognome} eta: {item.eta}");
}


//! 11 Esempio du creazione di un file json da dictionary

Dictionary<string, string> dict = new Dictionary<string, string>
{
    { "nome", "Mario" },
    { "cognome", "Rossi" },

};

string json11 = JsonConvert.SerializeObject(dict, Formatting.Indented); // serializzo il dictionary
File.WriteAllText("test11.json", json11); // scrivo il file
