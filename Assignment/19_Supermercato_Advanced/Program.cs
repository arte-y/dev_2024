using System.ComponentModel;
using System.Data.Common;
using Newtonsoft.Json;
class Program
{
  static void Main(string[] args)
  {
    //creare un oggetto di tipo ProdottoRepository per gestire il salvataggio e il caricamento dei dati
    ProdottoRepository prodottoRepository = new ProdottoRepository();

    // caricare i dati da file con iò metodo CaricaProdotti della classe ProdottoRepository (repository)
    List<ProdottoAdvanced> prodotti = prodottoRepository.CaricaProdotti();

    // creare un oggetto di tipo ProdottoAdvancedManager per gestire i prodotti
    ProdottoAdvancedManager manager = new ProdottoAdvancedManager(prodotti);

    // menu interattivo per eseguire le operazioni CRUD sui prodotti

    // variabile per controllare se il probramma deve continuare u uscire
    bool continua = true;

    // il ciclo while continua finche la variabile continua è true

    while (continua)
    {
      Console.WriteLine("\nMenu:");
      Console.WriteLine("1. Visualizza Prodotti");
      Console.WriteLine("2. Aggiungi Prodotto");
      Console.WriteLine("3. Trova Prodotto per ID");
      Console.WriteLine("4. Aggiorna Prodotto");
      Console.WriteLine("5. Elimina Prodotto");
      Console.WriteLine("6. Esci");

      string scelta = InputManager.LeggiIntero("\nScelta: ", 1, 6).ToString();
      // pulisco la console
      Console.Clear();

      switch (scelta)
      {
        case "1":
          Console.WriteLine("Prodotti:");
          manager.StampaProdottoIncolonnati();
          break;
        case "2":
          string nome = InputManager.LeggiStringa("\nnome: ");

          decimal prezzo = InputManager.LeggiDecimale("\nprezzo: ");

          int giacenza = InputManager.LeggiIntero("\ngiacenza: ");

          string descrizione = InputManager.LeggiStringa("\ndescrizione: ");

          manager.AggiungiProdotto(new ProdottoAdvanced { NomeProdotto = nome, PrezzoProdotto = prezzo, GiacenzaProdotto = giacenza, DescrizioneProdotto = descrizione });

          break;
        case "3":
          int idProdotto = InputManager.LeggiIntero("\nID: ");

          ProdottoAdvanced prodottoTrovato = manager.TrovaProdotto(idProdotto);
          if (prodottoTrovato != null)
          {
            Console.WriteLine($"Prodotto trovato: Id: {idProdotto}: {prodottoTrovato.NomeProdotto}");
          }
          else
          {
            Console.WriteLine($"\nProdotto non trovato per ID {idProdotto}");
          }
          break;
        case "4":
          int idProdottoAggiornare = InputManager.LeggiIntero("\nID: ");

          string nomeNuovo = InputManager.LeggiStringa("\nNome: ");

          decimal prezzoNuovo = InputManager.LeggiDecimale("\nPrezzo: ");

          int giacenzaNuovo = InputManager.LeggiIntero("\nGiacenza: ");

          string descrizioneNuovo = InputManager.LeggiStringa("\nDescrizione: ");

          manager.AggiornaProdotto(idProdottoAggiornare, new ProdottoAdvanced { NomeProdotto = nomeNuovo, PrezzoProdotto = prezzoNuovo, GiacenzaProdotto = giacenzaNuovo, DescrizioneProdotto = descrizioneNuovo });
          break;
        case "5":

          int idProdottoEliminare = InputManager.LeggiIntero("\nID: ");

          manager.EliminaProdotto(idProdottoEliminare);
          break;
        case "6":
          prodottoRepository.SalvaProdotti(manager.OttieniProdotti());
          continua = false;
          break;
        default:
          Console.WriteLine("Scelta non valida. Riprova.");
          break;
      }

    }

  }

}


public class ProdottoAdvanced
{
  private static int ultimoId = 0;
  private int _id;
  private string _nomeProdotto;
  private decimal _prezzoProdotto;
  private int _giacenzaProdotto;
  private string _descrizioneProdotto;

  public int Id
  {
    get
    {
      return _id;
    }
    set
    {
      _id = value;
    }
  }

  public ProdottoAdvanced()
  {
    Id = GeneraId();
  }

  private static int GeneraId()
  {
    return ++ultimoId;

  }

  public string NomeProdotto
  {
    get { return _nomeProdotto; }
    set
    {
      if (string.IsNullOrEmpty(value))
      {
        throw new ArgumentException("Il valore di NomeProdotto non può essere vuoto");
      }
      _nomeProdotto = value;
    }
  }

  public decimal PrezzoProdotto
  {
    get { return _prezzoProdotto; }
    set
    {
      if (value <= 0)
      {
        throw new ArgumentException("Il valore di PrezzoProdotto deve essere maggiore di zero");
      }
      _prezzoProdotto = value;

    }
  }

  public int GiacenzaProdotto
  {
    get { return _giacenzaProdotto; }
    set
    {
      if (value < 0)
      {
        throw new ArgumentException("Il valore di GiacenzaProdotto non può essere negativo");
      }
      _giacenzaProdotto = value;
    }
  }

  public string DescrizioneProdotto
  {
    get { return _descrizioneProdotto; }
    set
    {
      if (string.IsNullOrEmpty(value))
      {
        throw new ArgumentException("Il valore di DescrizioneProdotto non può essere vuoto");
      }
      _descrizioneProdotto = value;
    }
  }
}

public class ProdottoAdvancedManager
{
  private ProdottoRepository repository; // prof fatto

  private int prossimoId;

  private List<ProdottoAdvanced> prodotti; // prodotti e private perchè non voglio che vengano modificati dall'esterno

  public ProdottoAdvancedManager(List<ProdottoAdvanced> prodotti)
  {
    this.prodotti = prodotti; // fatto costruttore
    repository = new ProdottoRepository(); // prof fatto
    prossimoId = 1;
    foreach (var prodotto in prodotti)
    {
      if (prodotto.Id >= prossimoId)
      {
        prossimoId = prodotto.Id + 1;
      }
    }

  }

  public void AggiungiProdotto(ProdottoAdvanced prodotto)
  {
    prodotto.Id = prossimoId;
    prossimoId++;
    prodotti.Add(prodotto);

  }

  public List<ProdottoAdvanced> OttieniProdotti()
  {
    return prodotti;
  }

  public void StampaProdottoIncolonnati()
  {
    // intestazione con larghezza fissa
    Console.WriteLine($"{"ID",-5} {"Nome",-20} {"Prezzo",-10} {"Giacenza",-10} {"Descrizione",-20}");

    Console.WriteLine(new string('-', 50)); // Linea separatrice

    foreach (var prodotto in prodotti)
    {
      Console.WriteLine($"{prodotto.Id,-5} {prodotto.NomeProdotto,-20} {prodotto.PrezzoProdotto,-10} {prodotto.GiacenzaProdotto,-10} {prodotto.DescrizioneProdotto,-20}");
    }
  }

  public ProdottoAdvanced TrovaProdotto(int id)
  {
    foreach (var prodotto in prodotti)
    {
      if (prodotto.Id == id)
      {
        return prodotto;
      }
    }
    return null;
  }

  public void AggiornaProdotto(int id, ProdottoAdvanced nuovoProdotto)
  {
    var prodotto = TrovaProdotto(id);
    if (prodotto != null)
    {
      prodotto.NomeProdotto = nuovoProdotto.NomeProdotto;
      prodotto.PrezzoProdotto = nuovoProdotto.PrezzoProdotto;
      prodotto.GiacenzaProdotto = nuovoProdotto.GiacenzaProdotto;
      prodotto.DescrizioneProdotto = nuovoProdotto.DescrizioneProdotto;
    }
  }

  public void EliminaProdotto(int id)
  {
    var prodotto = TrovaProdotto(id);
    if (prodotto != null)
    {
      prodotti.Remove(prodotto);
      File.Delete($@"prodotti/Prodotto{prodotto.Id}.json");
    }
  }
}

public class ProdottoRepository
{
  private readonly string folderPath = "prodotti";

  public void SalvaProdotti(List<ProdottoAdvanced> prodotti)
  {
    if (!Directory.Exists(folderPath))
    {
      Directory.CreateDirectory(folderPath);
    }

    // Random rnd = new Random ();
    // int jsonId = rnd.Next(11,19);
    foreach (var prodotto in prodotti)
    {
      string filePath = Path.Combine(folderPath, $"Prodotto{prodotto.Id}.json");
      // Serialize fle
      string jsonData = JsonConvert.SerializeObject(prodotto, Formatting.Indented);
      // scrivo
      File.WriteAllText(filePath, jsonData);
      Console.WriteLine($"salvati {filePath}");
    }
  }

  public List<ProdottoAdvanced> CaricaProdotti()
  {
    List<ProdottoAdvanced> prodotti = new List<ProdottoAdvanced>();

    // control
    if (Directory.Exists(folderPath))
    {

      string[] filePaths = Directory.GetFiles(folderPath, "*.json");

      foreach (var item in filePaths)
      {
        // Read fatoo
        string jsonData = File.ReadAllText(item);
        // Deserialize
        ProdottoAdvanced prodotto = JsonConvert.DeserializeObject<ProdottoAdvanced>(jsonData);
        prodotti.Add(prodotto);
        Console.WriteLine($" caricati {item}");
      }
      foreach (var prodotto in prodotti)
      {
        Console.WriteLine($"Id: {prodotto.Id}, Nome: {prodotto.NomeProdotto}, Prezzo: {prodotto.PrezzoProdotto}, Giacenza: {prodotto.GiacenzaProdotto}, Descrizione: {prodotto.DescrizioneProdotto}");
      }
    }
    else
    {
      Console.WriteLine($"Cartell {folderPath} non esiste");
    }

    return prodotti;
  }


}


public static class InputManager
{
  public static int LeggiIntero(string messaggio, int min = int.MinValue, int max = int.MaxValue)
  {
    int valore; // variabile per memorizzare il valore intero acquisito
    // while continua finche l'utente non fornisce un input valido
    while (true)
    {
      Console.WriteLine($"{messaggio}"); // messagio e la variabile di inut che dovro passare aò metodo
      string input = Console.ReadLine(); // acquisisco l'input dell'utente come stringa
      // try parse per convertire la stringa in un intero e controllare se l'input è valido
      if (int.TryParse(input, out valore) && valore >= min && valore <= max)
      {
        return valore; // se l'input è valido restituisco il valore
      }
      else
      {
        Console.WriteLine($"inserice un valore intero compreso tra {min} e {max}."); // messahio di errore
      }
    }
  }

  public static decimal LeggiDecimale(string messaggio, decimal min = decimal.MinValue, decimal max = decimal.MaxValue)
  {
    decimal valore; // variabile per memorizzare il valore decimale acquisito
    while (true)
    {
      Console.WriteLine($"{messaggio}");
      string input = Console.ReadLine();

      if (input.Contains("."))
      {
        input = input.Replace(".", ",");
      }



      if (decimal.TryParse(input, out valore) && valore >= min && valore <= max)
      {
        return valore;
      }
      else
      {
        Console.WriteLine($"Inserisci un valore decimale compreso tra {min} e {max}.");
      }
    }
  }

  public static string LeggiStringa(string messaggio, bool obbligatorio = true)
  {
    while (true)
    {
      Console.WriteLine($"{messaggio}"); // messaggio e la variabile di input che dovro passare al metodo
      string input = Console.ReadLine(); // acquisisco l'input dell'utente come stringa
      if (!string.IsNullOrWhiteSpace(input) || !obbligatorio)
      {
        return input; // restituire il valore della stringa
      }
      else
      {
        Console.WriteLine("Il valore non può essere vuoto. Riprova."); // messaggio di errore
      }
    }
  }

  public static bool LeggiConferma(string messaggio)
  {
    while (true)
    {
      Console.WriteLine($"{messaggio} (s/n)");
      string input = Console.ReadLine().ToLower();
      if (input == "s" || input == "si")
      {
        return true;
      }
      if (input == "n" || input == "no")
      {
        return false;
      }
      Console.WriteLine("Errore: Rispondere 's' o 'n'.");

    }
  }
}



public class Client
{
  private int _Id;
  private string _UserNome;

  public int Id
  {
    get { return _Id; }
    set
    {
      _Id = value;
    }
  }

  public string UserNome
  {
    get { return _UserNome; }
    set
    {
      if (string.IsNullOrEmpty(value))
      {
        throw new ArgumentException("Il valore di NomeProdotto non può essere vuoto");
      }
      _UserNome = value;
    }
  }

  // Generate id
  public Client()
  {
    Id = GeneraId();
  }

  public static int GeneraId()
  {
    Random rnd = new Random();
    return rnd.Next(11, 111);

  }

  public void StampaC()
  {
    Console.WriteLine($"Id: {Id}, Nome: {UserNome}");
  }

}

public class ClientManager
{
  private List<Client> clients;

  public ClientManager(List<Client> clients)
  {
    this.clients = clients;
  }

  public void AggiungiClient(Client client)
  {
    clients.Add(client);
  }

  public List<Client> OttieniClients()
  {
    return clients;
  }

  public void StampaClient()
  {
    foreach (var client in clients)
    {
      client.StampaC();
    }
  }

  public Client TrovaClient(int id)
  {
    foreach (var client in clients)
    {
      if (client.Id == id)
      {
        return client;
      }
    }
    return null;
  }

  public void AggiornaClient(int id, Client nuovoClient)
  {
    var client = TrovaClient(id);
    if (client != null)
    {
      client.UserNome = nuovoClient.UserNome;
    }
  }

  public void EliminaClient(int id)
  {
    var client = TrovaClient(id);
    if (client != null)
    {
      clients.Remove(client);
    }
  }

}

public class ClientRepository
{
  private readonly string folderPath = "clients";

  public void SalvaClients(List<Client> clients)
  {
    if (!Directory.Exists(folderPath))
    {
      Directory.CreateDirectory(folderPath);
    }

    foreach (var client in clients)
    {
      string filePath = Path.Combine(folderPath, $"Client{client.Id}.json");
      string jsonData = JsonConvert.SerializeObject(client, Formatting.Indented);
      File.WriteAllText(filePath, jsonData);
    }
  }

  public List<Client> CaricaClients()
  {
    List<Client> clients = new List<Client>();

    if (Directory.Exists(folderPath))
    {
      string[] filePaths = Directory.GetFiles(folderPath, "*.json");

      foreach (var item in filePaths)
      {
        string jsonData = File.ReadAllText(item);
        Client client = JsonConvert.DeserializeObject<Client>(jsonData);
        clients.Add(client);
      }
    }
    else
    {
      Console.WriteLine($"Cartella {folderPath} non esiste");
    }

    return clients;
  }
}
