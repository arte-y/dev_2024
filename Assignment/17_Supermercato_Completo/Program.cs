using System.Runtime.CompilerServices;
using Newtonsoft.Json;

/*
var data = new[]
 {
  new { Codice = "001", Nome = "pesto", Prezzo = 2.5, Quantita = 10 },
  new { Codice = "002", Nome = "pasta", Prezzo = 1.5, Quantita = 20 },
  new { Codice = "003", Nome = "verdure", Prezzo = 3.5, Quantita = 30 },
  new { Codice = "004", Nome = "pollo", Prezzo = 5.5, Quantita = 40 },
  new { Codice = "005", Nome = "latte", Prezzo = 1.5, Quantita = 50 },
  new { Codice = "006", Nome = "pane", Prezzo = 1.0, Quantita = 60 },
  new { Codice = "007", Nome = "uova", Prezzo = 2.0, Quantita = 70 },
  new { Codice = "008", Nome = "pomodori", Prezzo = 2.5, Quantita = 80 },
  new { Codice = "009", Nome = "patate", Prezzo = 1.5, Quantita = 90 },
  new { Codice = "010", Nome = "insalata", Prezzo = 1.5, Quantita = 100 },
  new { Codice = "011", Nome = "tonno", Prezzo = 3.5, Quantita = 110 },
  new { Codice = "012", Nome = "salmone", Prezzo = 5.5, Quantita = 120 },
  new { Codice = "013", Nome = "sardine", Prezzo = 2.5, Quantita = 130 },
  new { Codice = "014", Nome = "cipolle", Prezzo = 1.5, Quantita = 140 },
  new { Codice = "015", Nome = "carote", Prezzo = 1.5, Quantita = 150 },
  new { Codice = "016", Nome = "zucchine", Prezzo = 3.5, Quantita = 160 },
  new { Codice = "017", Nome = "melanzane", Prezzo = 5.5, Quantita = 170 },
  new { Codice = "018", Nome = "peperoni", Prezzo = 1.5, Quantita = 180 },
  new { Codice = "019", Nome = "cetrioli", Prezzo = 1.5, Quantita = 190 }
 };
 */


string folderData = @"Database";
string path = Path.Combine(folderData, "data-prodotti.json");

if (!Directory.Exists(folderData))
{
  Directory.CreateDirectory(folderData);
  Console.WriteLine("Directory created");
}
else
{
  Console.WriteLine("Folder already exists");
}

if (!File.Exists(path))
{
  File.Create(path).Close();
  Console.WriteLine("File created");
}
else
{
  Console.WriteLine("File already exists");
}
// File.WriteAllText(path, JsonConvert.SerializeObject(data, Formatting.Indented));
var data = JsonConvert.DeserializeObject<dynamic[]>(File.ReadAllText(path));


Console.Clear();
Console.WriteLine("Benvenuto al Supermercato");

bool continuaT = true;

Console.WriteLine("Sei un cliente o un amministratore?");
Console.WriteLine("1. Cliente");
Console.WriteLine("2. Amministratore");
Console.Write("Scegli un'opzione: ");

string sceltaT = Console.ReadLine();


if (sceltaT == "1") // cliente
{
  try
  {
    ClientPanel();
  }
  catch (Exception ex)
  {
    Console.WriteLine($"Errore:Cliente{ex.Message}");
  }

}
else if (sceltaT == "2") // admin
{
  try
  {
    AdminPanel();
  }
  catch (Exception ex)
  {
    Console.WriteLine($"Errore:Admin{ex.Message}");
  }

}
else
{
  Console.WriteLine("Scelta non valida");
}

Console.WriteLine("Arrivederci!");

//! Admin panel
void AdminPanel()
{
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
            AdminEsci(ref continua);
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
}
//! Admin panel fin qui

//! Cliente panel
void ClientPanel()
{

  Dictionary<string, int> carrrello = new Dictionary<string, int>();

  bool continua = true;

  Console.Clear();
  while (continua)
  {
    Menu();
    string scelta = Console.ReadLine();

    switch (scelta) // if
    {
      case "1":
        VisualizzaProdotti();
        break;
      case "2":
        CercaProdotto();
        break;
      case "3":
        AggiungiProdotto(carrrello);
        break;
      case "4":
        RimuoviProdotto(carrrello);
        break;
      case "5":
        VisualizzaCarrello(carrrello);
        break;
      case "6":
        ProcediAlPagamento(carrrello);
        continua = false;
        break;
      case "0":
        Esci(ref continua, carrrello);
        break;
      default:
        Console.WriteLine("Scelta non valida");
        break;
    }
  }
}

//! Cliente fin qui


#region Funzioni admin panel

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

  foreach (var item in data)
  {
    if (item.Nome == nomeProdotto)
    {
      Console.WriteLine($"Codice: {item.Codice}, Nome: {item.Nome}, Prezzo: {item.Prezzo}, Quantita: {item.Quantita}");
    }
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

  for (int i = 0; i < data5.Count; i++)
  {
    if (data5[i].Nome == nomeProdotto)
    {
      Console.WriteLine($"Codice: {data5[i].Codice}, Nome: {data5[i].Nome}, Prezzo: {data5[i].Prezzo}, Quantita: {data5[i].Quantita}");
      data5.RemoveAt(i);
      Thread.Sleep(100);
      Console.WriteLine("Prodotto rimosso e aggiornato catalogo");

    }
  }
  File.WriteAllText(path, JsonConvert.SerializeObject(data5, Formatting.Indented));

  var data6 = JsonConvert.DeserializeObject<dynamic[]>(File.ReadAllText(path));

}

void AdminModificaProdotto()
{
  Console.WriteLine("Modifica un prodotto");

  Console.Write("Nome: ");
  var nomeProdotto = Console.ReadLine().ToLower();

  var data7 = JsonConvert.DeserializeObject<dynamic[]>(File.ReadAllText(path)).ToList();

  foreach (var item in data7)
  {
    if (item.Nome == nomeProdotto)
    {
      Console.WriteLine($"Codice: {item.Codice}, Nome: {item.Nome}, Prezzo: {item.Prezzo}, Quantita: {item.Quantita}");
    }
  }

  for (int i = 0; i < data7.Count; i++)
  {
    if (data7[i].Nome == nomeProdotto)
    {
      Console.Write("Insserici il nuovo codice (lascia vuoto per non modificare): ");
      int nuovoCodice1 = Convert.ToInt32(Console.ReadLine());
      if (!string.IsNullOrWhiteSpace(nuovoCodice1.ToString()))
      {
        data7[i].Codice = nuovoCodice1;
      }

      Console.Write("Insserici il nuovo nome: (lascia vuoto per non modificare): ");
      var nuovoNome1 = Console.ReadLine().ToLower();
      if (!string.IsNullOrWhiteSpace(nuovoNome1))
      {
        data7[i].Nome = nuovoNome1;
      }

      Console.Write("Insserici il nuovo prezzo (lascia vuoto per non modificare): ");
      double nuovoPrezzo1 = Convert.ToDouble(Console.ReadLine());
      if (!string.IsNullOrWhiteSpace(nuovoPrezzo1.ToString()))
      {
        data7[i].Prezzo = nuovoPrezzo1;
      }

      Console.Write("Insserici il nuovo prezzo (lascia vuoto per non modificare): ");
      int nuovaQuantita1 = Convert.ToInt32(Console.ReadLine());
      if (!string.IsNullOrWhiteSpace(nuovaQuantita1.ToString()))
      {
        data7[i].Quantita = nuovaQuantita1;

      }
    }

    File.WriteAllText(path, JsonConvert.SerializeObject(data7, Formatting.Indented));
  }
}

void AdminEsci(ref bool continua)
{
  Console.WriteLine("Uscita dal pannello di amministrazione");
  continua = false;
}

#endregion

#region Funzioni cliente panel
void Menu()
{
  Console.WriteLine("\n1 Visualizza prodotti");
  Console.WriteLine("2 Cerca un prodotto");
  Console.WriteLine("3 Aggiungi prodotto");
  Console.WriteLine("4 Rimuovi prodotto");
  Console.WriteLine("5 Visualizza carrello");
  Console.WriteLine("6 procedi al pagamento");
  Console.WriteLine("0 Esci");
  Console.Write("scegli un opzione: ");
}

void VisualizzaProdotti()
{
  Console.WriteLine("*** Prodotti disponibili ***");
  AdminVisualizzaProdotti();
}

void CercaProdotto()
{
  Console.WriteLine("Cerca un prodotto");

  Console.Write("Nome di prodotto: ");
  AdminCercaProdotto();

}

void AggiungiProdotto(Dictionary<string, int> carrello)
{

  Console.Write("Aggiungi un prodotto: ");
  string risposta = Console.ReadLine().ToLower();

  var data = JsonConvert.DeserializeObject<dynamic[]>(File.ReadAllText(path));

  foreach (var item in data)
  {
    if (item.Nome == risposta)
    {
      Console.Write("Quanti ne vuoi aggiungere?: ");
      int quantita = Convert.ToInt32(Console.ReadLine());

      int quantitaDisponibile = (int)item.Quantita;

      if (quantitaDisponibile < quantita)
      {
        Console.WriteLine("Quantita non disponibile");
        break;
      }
      else if (carrello.ContainsKey(risposta))
      {
        carrello[risposta] += quantita;
        item.Quantita = quantitaDisponibile - quantita;
        break;
      }
      else
      {
        carrello.Add(risposta, quantita);
        item.Quantita = quantitaDisponibile - quantita;
        break;
      }
    }
  }
  File.WriteAllText(path, JsonConvert.SerializeObject(data, Formatting.Indented));
}

void RimuoviProdotto(Dictionary<string, int> carrello)
{

  Console.Write("Rimuovi un prodotto: ");
  string risposta = Console.ReadLine().ToLower();

  var data = JsonConvert.DeserializeObject<dynamic[]>(File.ReadAllText(path));

  foreach (var item in data)
  {
    if (item.Nome == risposta)
    {
      Console.Write("Quanti ne vuoi rimuovere?: ");
      int quantita = Convert.ToInt32(Console.ReadLine());
      int quantitaDisponibile = (int)item.Quantita;

      if (carrello.ContainsKey(risposta))
      {
        if (carrello[risposta] < quantita)
        {
          Console.WriteLine("Quantita non disponibile");
          break;
        }
        else if (carrello[risposta] == quantita)
        {
          carrello.Remove(risposta);
          item.Quantita = quantitaDisponibile + quantita;
          break;
        }
        else
        {
          carrello[risposta] -= quantita;
          item.Quantita = quantitaDisponibile + quantita;
          break;
        }
      }
    }
  }

  File.WriteAllText(path, JsonConvert.SerializeObject(data, Formatting.Indented));

}

void VisualizzaCarrello(Dictionary<string, int> carrrello)
{
  Console.WriteLine("*** Visualizza Carrello e Details ***");

  var data = JsonConvert.DeserializeObject<dynamic[]>(File.ReadAllText(path));

  foreach (var item in carrrello)
  {
    foreach (var item2 in data)
    {
      if (item2.Nome == item.Key)
      {
        Console.WriteLine($"Nome: {item2.Nome}, Quantita: {item.Value}, Prezzo/unitario: {item2.Prezzo}€");
      }
    }
  }


}

void ProcediAlPagamento(Dictionary<string, int> carrello)
{
  Console.WriteLine("*** Pagina al pagamento ***");
  double totale = 0;
  var scontrino = new List<string>();

  scontrino.Add("********** Scontrino **********");
  scontrino.Add("Nome\tQuantita\tPrezzo\tTotale");

  foreach (var item in carrello)
  {
    foreach (var item2 in data)
    {
      if (item2.Nome == item.Key)
      {
        double prezzo = (double)item2.Prezzo;
        double totaleProdotto = item.Value * prezzo;
        totale += totaleProdotto;

        scontrino.Add($"{item.Key}\t{item.Value}\t{prezzo:F2}\t{totaleProdotto:F2}");
      }
    }
  }
  scontrino.Add("-------------------------------");
  scontrino.Add($"Totale:\t\t\t{totale:F2} Euro");
  scontrino.Add("*******************************");

  Console.WriteLine($"Totale prezzo: {totale:F2} Euro");
  Console.WriteLine("Voresi procedere al pagamento? (s/n)");
  string risposta = Console.ReadLine().ToLower();
  if (risposta == "s")
  {
    Console.WriteLine("Pagamento effettuato con successo");

    Random rnd = new Random();
    int numeroScontrino = rnd.Next(1000, 9999);
    scontrino.Add($"Numero scontrino: {numeroScontrino}");

    string folderData = @"Database";
    string scontrinoPath = Path.Combine(folderData, $"scontrino{numeroScontrino}.txt");

    File.WriteAllLines(scontrinoPath, scontrino);
    Console.WriteLine("Scontrino salvato");
  }
  else
  {
    Console.WriteLine("Pagamento annullato");
  }
}

void Esci(ref bool continua, Dictionary<string, int> carrello)
{
  Console.WriteLine("Vuoi salvare il carrello? (s/n)");
  string risposta = Console.ReadLine().ToLower();
  if (risposta == "s")
  {
    File.WriteAllText("carrello.json", JsonConvert.SerializeObject(carrello, Formatting.Indented));
    Console.WriteLine("Carrello salvato");

  }
  else
  {
    Console.WriteLine("Carrello non salvato");
  }

  //svoto carrello e riaggiornoa il file

  var data = JsonConvert.DeserializeObject<dynamic[]>(File.ReadAllText(path));

  foreach (var item in carrello)
  {
    foreach (var item2 in data)
    {
      if (item2.Nome == item.Key)
      {
        item2.Quantita += item.Value;
      }
    }
  }

  File.WriteAllText(path, JsonConvert.SerializeObject(data, Formatting.Indented));


  continua = false;
  Console.WriteLine("Arrivederci!");
}


#endregion