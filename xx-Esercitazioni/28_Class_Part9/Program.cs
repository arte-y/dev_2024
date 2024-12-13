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
      // Console.Write("\nScelta: ");
      // string scelta = Console.ReadLine();
      // string scelta  acquissita mediante il meotodo LeggiIntero della InputManager

      string scelta = InputManager.LeggiIntero("\nScelta: ", 1, 6).ToString();
      // pulisco la console
      Console.Clear();

      // switch-case per geestire le scelte dell'utente che usa scelta come variable di controllo

      switch (scelta)
      {
        case "1":
          Console.WriteLine("Prodotti:");
          manager.StampaProdottoIncolonnati();
          break;
        case "2":

          // acquisisco il nome mediante il metodo LeggiStringa della classe InputManager
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

  //*****************
  // ogni campo utilizz il fromato {campo,largezza} dove;
  // campo è il nvalore da stampare
  // -Larghezza specifica la larghezza del campo; il segno - allinea il testo a sinistra.
  // {"Nome", -20} significa che il nome del prodotto avrà una larghezza fissa di 20 caratteri, allineato a sinistra
  // format dei numeri;
  // per i prezzi, viene usato il formato 0.00 per mostare sempre due cifre decimali
  // liena separatrice:
  // la riga Console.WriteLine(new string('-', 50)); crea una linea orizzontale di 50 caratteri per migliorare la leggibilità

  public void StampaProdottoIncolonnati ()
  {
    // intestazione con larghezza fissa
    Console.WriteLine($"{"ID", -5} {"Nome", -20} {"Prezzo", -10} {"Giacenza", -10} {"Descrizione", -20}");
    
    Console.WriteLine(new string('-', 50)); // Linea separatrice
    
    // stampa ogni prodotto cn larghezza fissa
    foreach (var prodotto in prodotti)
    {
      Console.WriteLine($"{prodotto.Id, -5} {prodotto.NomeProdotto, -20} {prodotto.PrezzoProdotto, -10} {prodotto.GiacenzaProdotto, -10} {prodotto.DescrizioneProdotto, -20}");
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
  //***********


}



// imlementazione di id automatici
// detagli delle modicfiche inzializzazione di prossimold:
// un ciclo foreach la lista di prodotto per trovare il valore altro di id. Se un prodotto ha un id maggiaore o ugale a prossimold, aggiorno prossimold aggiundendo 1.
// metodo trovaprodotto

// in prodotto advanced manager

// private int prossimoId = 0;

// *************************************************************

// classe di questione degli input (InputManager) che puo essere itegrata per semplificare e standardizzare l'acquisizione e la validazione degli input dell'utente . 
// Questa classe aiuta a gestire i casi di arrore e fornisce metodi per acquistare input di diversi tipi
// uso int-MiValue ed int-MaxValue per dare dei valori di default
// quando chiami il metodo, puoi specificare solo i valo....

public static class InputManager
{
  // metodo LeggiIntero accetta un messaggio da visualizzare all'utente e un intervallo di valori interi consentiti
  // MinValue e MaxValue sono i metodi di int che rappresentano il valore minimo e massimo di un intero
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

  // metodo LeggiDecimale
  public static decimal LeggiDecimale(string messaggio, decimal min = decimal.MinValue, decimal max = decimal.MaxValue)
  {
    decimal valore; // variabile per memorizzare il valore decimale acquisito
    while (true)
    {
      Console.WriteLine($"{messaggio}");
      string input = Console.ReadLine();
      // sostituisco la virgula con il punto per gestire i numeri decimali
      if (input.Contains(","))
      {
        input = input.Replace(",", ".");
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

  // metodo LeggiStringa
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

// *************************************************************