using Newtonsoft.Json;


// var data = new[]
// {
//   new { Codice = "001", Nome = "Pesto", Prezzo = 2.5, Quantita = 10 },
//   new { Codice = "002", Nome = "Pasta", Prezzo = 1.5, Quantita = 20 },
//   new { Codice = "003", Nome = "Verdure", Prezzo = 3.5, Quantita = 30 },
//   new { Codice = "004", Nome = "Pollo", Prezzo = 5.5, Quantita = 40 },
//   new { Codice = "005", Nome = "Latte", Prezzo = 1.5, Quantita = 50 },
//   new { Codice = "006", Nome = "Pane", Prezzo = 1.0, Quantita = 60 },
//   new { Codice = "007", Nome = "Uova", Prezzo = 2.0, Quantita = 70 },
//   new { Codice = "008", Nome = "Pomodori", Prezzo = 2.5, Quantita = 80 },
//   new { Codice = "009", Nome = "Patate", Prezzo = 1.5, Quantita = 90 },
//   new { Codice = "010", Nome = "Insalata", Prezzo = 1.5, Quantita = 100 },
//   new { Codice = "011", Nome = "Tonno", Prezzo = 3.5, Quantita = 110 },
//   new { Codice = "012", Nome = "Salmone", Prezzo = 5.5, Quantita = 120 },
//   new { Codice = "013", Nome = "Sardine", Prezzo = 2.5, Quantita = 130 },
//   new { Codice = "014", Nome = "Cipolle", Prezzo = 1.5, Quantita = 140 },
//   new { Codice = "015", Nome = "Carote", Prezzo = 1.5, Quantita = 150 },
//   new { Codice = "016", Nome = "Zucchine", Prezzo = 3.5, Quantita = 160 },
//   new { Codice = "017", Nome = "Melanzane", Prezzo = 5.5, Quantita = 170 },
//   new { Codice = "018", Nome = "Peperoni", Prezzo = 1.5, Quantita = 180 },
//   new { Codice = "019", Nome = "Cetrioli", Prezzo = 1.5, Quantita = 190 }
// };

string path = @"data-prodotti.json";
// File.WriteAllText(path, JsonConvert.SerializeObject(data, Formatting.Indented));
var data = JsonConvert.DeserializeObject<dynamic[]>(File.ReadAllText(path));



//! cerca un prodotto

// completo cerca prodotto

//! aggiunge un nuovo prodotto

// completo aggiungi prodotto

//! rimuove un prodotto

// completo rimuovi prodotto

//! modificare il prodotto



// completo modifica prodotto

//! visualizza prodotti


// completo visualizza prodotti




//! Admin panel

Console.WriteLine("Pannello di amministrazione");

bool continua = true;

string admin = "admin";
string password = "admin";

while (continua)
{
  Console.Write("Inserisci username: ");
  string username = Console.ReadLine().ToLower();

  Console.Write("Inserisci password: ");
  string pass = Console.ReadLine().ToLower();

  if (username == admin && pass == password)
  {
    Console.WriteLine("Accesso consentito");
    while (continua)
{
  AdminMenu();
  string scelta = Console.ReadLine();

  switch (scelta)
  {
    case "1":
      AdminVisualizzaProdotti();
      break;
    case "2":
      AdminCercaProdotto();
      break;
    case "3":
      AdminAggiungiProdotto();
      break;
    case "4":
      AdminRimuoviProdotto();
      break;
    case "5":
      AdminModificaProdotto();
      break;
    case "0":
      AdminEsci();
      break;
    default:
      Console.WriteLine("Scelta non valida");
      break;
  }
}
  }
  else
  {
    Console.WriteLine("Accesso negato");
  }
}







#region Funzioni

void AdminMenu()
{
  Console.WriteLine("1 Visualizza prodotti");
  Console.WriteLine("2 Cerca un prodotto");
  Console.WriteLine("3 Aggiungi prodotto");
  Console.WriteLine("4 Rimuovi prodotto");
  Console.WriteLine("5 Modifica prodotto");
  Console.WriteLine("0 Esci");
  Console.Write("scegli un opzione: ");
}

void AdminVisualizzaProdotti()
{
  var data = JsonConvert.DeserializeObject<dynamic[]>(File.ReadAllText(path));
  foreach (var item in data)
  {
    Console.WriteLine($"Codice: {item.Codice}, Nome: {item.Nome}, Prezzo: {item.Prezzo}, Quantita: {item.Quantita}");
  }
}

void AdminCercaProdotto()
{
  Console.WriteLine("Cerca un prodotto");

  Console.Write("Nome di prodotto: ");
  var nomeProdotto = Console.ReadLine().ToLower();

  var data = JsonConvert.DeserializeObject<dynamic[]>(File.ReadAllText(path));
  var product = data.FirstOrDefault(i => i.Nome == nomeProdotto);

  if (product != null)
  {
    Console.WriteLine($"Codice: {product.Codice}, Nome: {product.Nome}, Prezzo: {product.Prezzo}, Quantita: {product.Quantita}");
  }
  else
  {
    Console.WriteLine("Prodotto non trovato");
  }
}

void AdminAggiungiProdotto()
{
  Console.WriteLine("Aggiungi un nuovo prodotto");

  Console.Write("Codice: ");
  int codice = Convert.ToInt32(Console.ReadLine());

  Console.Write("Nome: ");
  string nome = Console.ReadLine().ToLower();

  Console.Write("Prezzo: ");
  double prezzo = Convert.ToDouble(Console.ReadLine());

  Console.Write("Quantita: ");
  int quantita = Convert.ToInt32(Console.ReadLine());


  var newProduct = new { Codice = codice, Nome = nome, Prezzo = prezzo, Quantita = quantita };
  var data3 = JsonConvert.DeserializeObject<dynamic[]>(File.ReadAllText(path)).ToList();
  data3.Add(newProduct);
  File.WriteAllText(path, JsonConvert.SerializeObject(data3, Formatting.Indented));

  var data4 = JsonConvert.DeserializeObject<dynamic[]>(File.ReadAllText(path));
  foreach (var item in data4)
  {
    Console.WriteLine($"Codice: {item.Codice}, Nome: {item.Nome}, Prezzo: {item.Prezzo}, Quantita: {item.Quantita}");
  }
}

void AdminRimuoviProdotto()
{
  Console.WriteLine("Rimuovi un prodotto");

  Console.Write("Nome: ");
  var nomeProdotto = Console.ReadLine().ToLower();

  var data5 = JsonConvert.DeserializeObject<dynamic[]>(File.ReadAllText(path)).ToList();
  var productToRemove = data5.FirstOrDefault(x => x.Nome == nomeProdotto);
  data5.Remove(productToRemove);
  File.WriteAllText(path, JsonConvert.SerializeObject(data5, Formatting.Indented));

  var data6 = JsonConvert.DeserializeObject<dynamic[]>(File.ReadAllText(path));
  foreach (var item in data6)
  {
    Console.WriteLine($"Codice: {item.Codice}, Nome: {item.Nome}, Prezzo: {item.Prezzo}, Quantita: {item.Quantita}");
  }
}

void AdminModificaProdotto()
{
  Console.WriteLine("Modifica un prodotto");

  Console.Write("Nome: ");
  var nomeProdotto = Console.ReadLine().ToLower();

  var data7 = JsonConvert.DeserializeObject<dynamic[]>(File.ReadAllText(path)).ToList();
  var productToModify = data7.FirstOrDefault(i => i.Nome == nomeProdotto);

  Console.Write("Nuovo Codice: ");
  int nuovoCodice = Convert.ToInt32(Console.ReadLine());

  Console.Write("Nuovo Nome: ");
  var nuovoNome = Console.ReadLine().ToLower();

  Console.Write("Nuovo Prezzo: ");
  double nuovoPrezzo = Convert.ToDouble(Console.ReadLine());

  Console.Write("Nuova Quantita: ");
  int nuovaQuantita = Convert.ToInt32(Console.ReadLine());

  productToModify.Codice = nuovoCodice;
  productToModify.Nome = nuovoNome;
  productToModify.Prezzo = nuovoPrezzo;
  productToModify.Quantita = nuovaQuantita;

  File.WriteAllText(path, JsonConvert.SerializeObject(data7, Formatting.Indented));
}

void AdminEsci()
{
  continua = false;
}

#endregion