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
    ProdottoAdvancedManager manager = new ProdottoAdvancedManager();

    // menu interattivo per eseguire le operazioni CRUD sui prodotti

    // variabile per controllare se il probramma deve continuare u uscire
    bool continua = true;

    // il ciclo while continua finche la variabile continua è true

    while(continua)
    {
      Console.WriteLine("\nMenu:");
      Console.WriteLine("1. Visualizza Prodotti");
      Console.WriteLine("2. Aggiungi Prodotto");
      Console.WriteLine("3. Trova Prodotto per ID");
      Console.WriteLine("4. Aggiorna Prodotto");
      Console.WriteLine("5. Elimina Prodotto");
      Console.WriteLine("6. Esci");

      // acquisire l'input dell'utente 
      Console.Write("\nScelta: ");
      string scelta = Console.ReadLine();

      // switch-case per geestire le scelte dell'utente che usa scelta come variable di controllo

      switch (scelta)
      {
        case "1":
        Console.WriteLine("Prodotti:");
        // visualizzare tutti i prodotti con il metodo OttieniProdotti della classe ProdottoAdvancedManager(manager)
        foreach (var prodotto in manager.OttieniProdotti())
        {
          Console.WriteLine($"Id: {prodotto.Id}, Nome: {prodotto.NomeProdotto}, Prezzo: {prodotto.PrezzoProdotto}, Giacenza: {prodotto.GiacenzaProdotto}, Descrizione: {prodotto.DescrizioneProdotto}");
        }
        break;
        case "2":
        Console.Write("Inserisci l'ID del prodotto: ");
        int id = int.Parse(Console.ReadLine());
        Console.Write("Inserisci il nome del prodotto: ");
        string nome = Console.ReadLine();
        Console.Write("Inserisci il prezzo del prodotto: ");
        decimal prezzo = decimal.Parse(Console.ReadLine());
        Console.Write("Inserisci la giacenza del prodotto: ");
        int giacenza = int.Parse(Console.ReadLine());
        Console.Write("Inserisci la descrizione del prodotto: ");
        string descrizione = Console.ReadLine();

        manager.AggiungiProdotto(new ProdottoAdvanced { Id = id, NomeProdotto = nome, PrezzoProdotto = prezzo, GiacenzaProdotto = giacenza, DescrizioneProdotto = descrizione });
        break;
        case "3":
        Console.Write("Inserisci l'ID del prodotto da cercare: ");
        int idProdotto = int.Parse(Console.ReadLine());
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


      }









    }


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
  private readonly string filePath = "prodotti.json";

  public void SalvaProdotti(List<ProdottoAdvanced> prodotti)
  {
    // serializzo la lista di prodotti in formato JSON
    string jsonData = JsonConvert.SerializeObject(prodotti);
    // scrivo il contenuto del file
    File.WriteAllText(filePath, jsonData);
    Console.WriteLine($"Dati salvati in {filePath}:\n{jsonData}");
  }

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


