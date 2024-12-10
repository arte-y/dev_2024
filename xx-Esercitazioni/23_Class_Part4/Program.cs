using Newtonsoft.Json;
class Program
{
  static void Main(string[] args)
  {
    //Creare un oggetto di tipo ProdottoRepository per gestire il salvataggio e il caricamento dei dati
    ProdottoRepository repository = new ProdottoRepository();

    // Caricare i dati da file con il metodo CaricaProdotti della classe ProdottoRepository(repository)
    List<ProdottoAdvanced> prodotti = repository.CaricaProdotti();


    // Cercare una ogetto di tipo ProdottoAdvancedManager per gestire i prodotti
    ProdottoAdvancedManager manager = new ProdottoAdvancedManager();

    // Aggiungere un prodotto alla lista con il metodo AggiungiProdotto della class ProdottoAdvancedManager(manager)

    manager.AggiungiProdotto(new ProdottoAdvanced { Id = 1, NomeProdotto = "Prodotto A", PrezzoProdotto = 10.50m, GiacenzaProdotto = 100, DescrizioneProdotto = "Prodotto A Descrizione" });
    manager.AggiungiProdotto(new ProdottoAdvanced { Id = 2, NomeProdotto = "Prodotto B", PrezzoProdotto = 20.50m, GiacenzaProdotto = 200, DescrizioneProdotto = "Prodotto B Descrizione" });

    // Visualizzare tutti i prodotti con il metodo OttieniProdotti della classe ProdottoAdvancedManager(manager)
    Console.WriteLine("Prodotti:");
    foreach (var prodotto in manager.OttieniProdotti())
    {
      Console.WriteLine($"Id: {prodotto.Id}, Nome: {prodotto.NomeProdotto}, Prezzo: {prodotto.PrezzoProdotto}, Giacenza: {prodotto.GiacenzaProdotto}, Descrizione: {prodotto.DescrizioneProdotto}");
    }

    // Trovare un prodotto con il metodo TrovaProdotto della classe ProdottoAdvancedManager(manager)
    int idProdotto = 1;
    ProdottoAdvanced prodottoTrovato = manager.TrovaProdotto(idProdotto);
    if (prodottoTrovato != null)
    {
      Console.WriteLine($"Prodotto trovato: Id: {idProdotto}: {prodottoTrovato.NomeProdotto}");
    }
    else
    {
      Console.WriteLine($"\nProdotto non torvato per ID {idProdotto}");
    }

    // Aggiornare un prodotto con il metodo AggiornaProdotto della classe ProdottoAdvancedManager(manager)
    int idProdottoDaAggiornare = 2;
    ProdottoAdvanced nuovoProdotto = new ProdottoAdvanced { Id = 2, NomeProdotto = "Prodotto C", PrezzoProdotto = 30.50m, GiacenzaProdotto = 300, DescrizioneProdotto = "Prodotto C Descrizione" };
    manager.AggiornaProdotto(idProdottoDaAggiornare, nuovoProdotto);

    // Visualizzare tutti i prodotti con il metodo OttieniProdotti della classe ProdottoAdvancedManager(manager)
    Console.WriteLine("\nProdotti aggiornati:");
    foreach (var prodotto in manager.OttieniProdotti())
    {
      Console.WriteLine($"Id: {prodotto.Id}, Nome: {prodotto.NomeProdotto}, Prezzo: {prodotto.PrezzoProdotto}, Giacenza: {prodotto.GiacenzaProdotto}, Descrizione: {prodotto.DescrizioneProdotto}");
    }

    // Eliminare un prodotto con il metodo EliminaProdotto della classe ProdottoAdvancedManager(manager)
    int idProdottoDaEliminare = 1;
    manager.EliminaProdotto(idProdottoDaEliminare);

    // Visualizzare i prodotti rimanenti con il metodo OttieniProdotti della classe ProdottoAdvancedManager(manager)
    Console.WriteLine("\nProdotti rimanenti:");
    foreach (var prodotto in manager.OttieniProdotti())
    {
      Console.WriteLine($"Id: {prodotto.Id}, Nome: {prodotto.NomeProdotto}, Prezzo: {prodotto.PrezzoProdotto}, Giacenza: {prodotto.GiacenzaProdotto}, Descrizione: {prodotto.DescrizioneProdotto}");
    }

    // Salvare i prodotti su file con il metodo SalvaProdotti della classe ProdottoRepository(repository)
    repository.SalvaProdotti(manager.OttieniProdotti());
  }

}


public class ProdottoAdvanced
{

  private int _id;
  private string _nomeProdotto;
  private decimal _prezzoProdotto;
  private int _giacenzaProdotto;
  private string _descrizioneProdotto;

  public int Id
  {
    get { return _id; }
    set
    {
      if (value <= 0)
      {
        throw new ArgumentException("Il valore di Id deve essere maggiore di zero");
      }
      _id = value;
    }
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
  private List<ProdottoAdvanced> prodotti = new List<ProdottoAdvanced>(); // prodotti e private perchè non voglio che vengano modificati dall'esterno
  public ProdottoAdvancedManager()
  {
    prodotti = new List<ProdottoAdvanced>(); // inizializzo la lista di prodotti nel costruttore pubblico in modo ce sia accessibile dall'esterno
  }
  // metodo per aggiungere un prodotto alla lista
  public void AggiungiProdotto(ProdottoAdvanced prodotto)
  {
    prodotti.Add(prodotto);
  }
  // metodo per visualizzare tutti i prodotti
  public List<ProdottoAdvanced> OttieniProdotti()
  {
    return prodotti;
  }
  // metodo per cercare un prodotto
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
  // metodo per modificare un prodotto esistente
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
  // metodo per eliminare un prodotto
  public void EliminaProdotto(int id)
  {
    var prodotto = TrovaProdotto(id);
    if (prodotto != null)
    {
      prodotti.Remove(prodotto);
    }
  }
}

public class ProdottoRepository
{
  // la classe ProdottoReposiotry è una classe che si occupa di gestire la persistenza dei dati in modo centralizzato
  // i vantaggi di questa classe sono:
  // - centralizzare la gestione della persistenza dei dati
  // - facilità di manutenzione
  // - facilità di test
  // - possibilità di cambiare il tipo di persistenza senza dover modificare il codiece che utilizza la classa
  // - pisibilità di aggiungere logica di caching (memoriizazione temporanea dei dati) senza dover modificare il codice che utilizza la classe

  //filePath è il percorso del file in cui salvare i dati ed ha il modificatore private perche non voglio che venga modificato dell'esterno della classe della classe prima di essere utilizzato
  private readonly string filePath = "prodotti.json";

  // metodo per slavare i dati su file
  public void SalvaProdotti(List<ProdottoAdvanced> prodotti)
  {
    // serializzo la lista di prodotti in formato JSON
    string jsonData = JsonConvert.SerializeObject(prodotti);
    // scrivo il contenuto del file
    File.WriteAllText(filePath, jsonData);
    Console.WriteLine($"Dati salvati in {filePath}:\n{jsonData}");
  }

  // metodo per caricare i dati da file
  // restituisce una lista di prodotti se il file esiste e contiene dati

  public List<ProdottoAdvanced> CaricaProdotti()
  {
    // verifico se il file esiste
    if (File.Exists(filePath))
    {
      // leggo il contenuto del file
      string jsonData = File.ReadAllText(filePath);
      // deserializzo il contenuto del file in una lista di prodotti
      List<ProdottoAdvanced> prodotti = JsonConvert.DeserializeObject<List<ProdottoAdvanced>>(jsonData);
      Console.WriteLine($"Dati caricati da {filePath}:\n{jsonData}");
      foreach (var item in prodotti)
      {
        Console.WriteLine($"Id: {item.Id}, Nome: {item.NomeProdotto}, Prezzo: {item.PrezzoProdotto}, Giacenza: {item.GiacenzaProdotto}, Descrizione: {item.DescrizioneProdotto}");
      }
      // restituisco la lista di prodotti letti dal file in modo che possa essere utilizzata all'esterno della classe
      return prodotti;
    }
    else
    {
      Console.WriteLine($"Il file {filePath} non esiste");
      // restituisco una lista vuota se il file non esiste o è vuoto in modo che possa essere utilizzata all'esterno della classe
      return new List<ProdottoAdvanced>();
    }

  }



}
