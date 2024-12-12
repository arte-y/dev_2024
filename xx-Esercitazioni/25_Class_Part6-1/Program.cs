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

    // 1. visualizzare i prodotti nel menu main vengenon solo i prodotti aggiunti in runtime ma non quello del file Json questo un bug

    while (continua)
    {
      Console.WriteLine("\nMenu:");
      Console.WriteLine("1. Visualizza Prodotti");
      Console.WriteLine("2. Aggiungi Prodotto");
      Console.WriteLine("3. Trova Prodotto per ID");
      Console.WriteLine("4. Aggiorna Prodotto");
      Console.WriteLine("5. Elimina Prodotto");
      Console.WriteLine("6. Esci");
      // ==
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
          // Console.Write("ID: ");
          // int id = int.Parse(Console.ReadLine());
          Console.Write("nome: ");
          string nome = Console.ReadLine();
          Console.Write("prezzo: ");
          decimal prezzo = decimal.Parse(Console.ReadLine());
          Console.Write("giacenza: ");
          int giacenza = int.Parse(Console.ReadLine());
          Console.Write("descrizione: ");
          string descrizione = Console.ReadLine();


          manager.AggiungiProdotto(new ProdottoAdvanced { NomeProdotto = nome, PrezzoProdotto = prezzo, GiacenzaProdotto = giacenza, DescrizioneProdotto = descrizione });
          // manager.AggiungiProdotto(new ProdottoAdvanced { Id = id, NomeProdotto = nome, PrezzoProdotto = prezzo, GiacenzaProdotto = giacenza, DescrizioneProdotto = descrizione });

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
        case "4":
          Console.Write("ID: ");
          int idProdottoAggiornare = int.Parse(Console.ReadLine());
          Console.Write("Nome: ");
          string nomeNuovo = Console.ReadLine();
          Console.Write("Prezzo: ");
          decimal prezzoNuovo = decimal.Parse(Console.ReadLine());
          Console.Write("Giacenza: ");
          int giacenzaNuovo = int.Parse(Console.ReadLine());
          Console.Write("Descrizione: ");
          string descrizioneNuovo = Console.ReadLine();
          manager.AggiornaProdotto(idProdottoAggiornare, new ProdottoAdvanced { NomeProdotto = nomeNuovo, PrezzoProdotto = prezzoNuovo, GiacenzaProdotto = giacenzaNuovo, DescrizioneProdotto = descrizioneNuovo });
          break;
        case "5":
          Console.Write("Inserisci l'ID del prodotto da eliminare: ");
          int idProdottoEliminare = int.Parse(Console.ReadLine());
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
  private static int ultimoId = 0; //campo static per tracciare l'ultimo ID generate
                                   // è private perchè non voglio che venga modificato dall'esterno
                                   // è static perchè voglio che sia condiviso tra tutte le istanze della classe

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
      _id = value; // rende il setter privato per impedire meodifiche manuali all'ID
                   // value e definito iimplicitamente dal compilatore e rappresenta il valore assegnato alla proprietà
                   // value è una variabile locale e non può essere utilizzata all'esterno del setter
                   // value è quello che si chiama un parametro implicito cioè non lo devo dichiarare io ma è già dichiarato dal compilatore
    }
  }

  // costruttore per generare autmaticamente l'ID
  // quando viene creato un nuovo oggetto ProdottoAdvanced con il costruttore vuoto (senza parametri) viene chiamato questo csoturttore (costruttore default)
  // ceh genera un nuovo ID e lo assegna all'oggetto usando il metodo generaId
  // invece gli altri parametri (nomeprodotto, prezzoprodotto, ------ ) vengono inizializzati con i valori di default (null, 0,0)
  // ed in seguito vengono assegnati i valori inseriti dall'utente
  public ProdottoAdvanced()
  {
    Id = GeneraId();
  }
  // metodo statico per generare un ID progressivo
  // è statico perche in questo caso mi serve che sia condiviso tra tutte le istnza della classe in modo che l'ID sia univoco per ogni prodotto
  private static int GeneraId()
  {
    // incremento l'ultimo ID e lo restituisco e getlastid è un metodo statico
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

  // public ProdottoAdvancedManager (List<ProdottoAdvanced> prodottiIniziali =nul) //?prof fatto
  // {
  //   if(prodottiIniziali != nul)
  //   prodotti=prodottiIniziali
  //   else
  //   prodotti = new List<ProdottoAdvanced>();
  // }

  // public ProdottoAdvancedManager( )
  // {
  //   prodotti = new List<ProdottoAdvanced>(); // inizializzo la lista di prodotti nel costruttore pubblico in modo ce sia accessibile dall'esterno
  // }
  // metodo per aggiungere un prodotto alla lista
  public void AggiungiProdotto(ProdottoAdvanced prodotto)
  {
    prodotto.Id = prossimoId;
    prossimoId++;
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
      File.Delete($@"prodotti/Prodotto{prodotto.Id}.json");
    }
  }
}

public class ProdottoRepository
{
  private readonly string folderPath = "prodotti";

  // // public ProdottoRepository()
  // // {
  // //   // directory
  // //   if (!Directory.Exists(folderPath))
  // //   {
  // //     Directory.CreateDirectory(folderPath);
  // //   }
  // // }

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

// imlementazione di id automatici
// detagli delle modicfiche inzializzazione di prossimold:
// un ciclo foreach la lista di prodotto per trovare il valore altro di id. Se un prodotto ha un id maggiaore o ugale a prossimold, aggiorno prossimold aggiundendo 1.
// metodo trovaprodotto

// in prodotto advanced manager

// private int prossimoId = 0;