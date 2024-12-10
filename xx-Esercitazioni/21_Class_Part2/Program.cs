using Newtonsoft.Json;
class Program
{
  static void Main(string[] args)
  {
    List<ProdottoAdvanced> prodotti = new List<ProdottoAdvanced>
    {
        new ProdottoAdvanced { Id = 1, NomeProdotto = "Prodotto A", PrezzoProdotto = 10.50m, GiacenzaProdotto = 100, DescrizioneProdotto = "Prodotto A Descrizione" },
        new ProdottoAdvanced { Id = 2, NomeProdotto = "Prodotto A", PrezzoProdotto = 20.50m, GiacenzaProdotto = 200, DescrizioneProdotto = "Prodotto B Descrizione" }
    };

    // json write and read

    // serializzazione
    string filePath = "prodotti.json";
    string jsonData = JsonConvert.SerializeObject(prodotti, Formatting.Indented);
    File.WriteAllText(filePath, jsonData);

    Console.WriteLine($"Dati serializzati e salvati in {filePath}:\n{jsonData}\n");

    // deserializzazione
    string readJsonData = File.ReadAllText(filePath);
    List<ProdottoAdvanced> prodottiDeserializzati = JsonConvert.DeserializeObject<List<ProdottoAdvanced>>(readJsonData);

    Console.WriteLine("Dati deserializzati:");
    foreach (var prodotto in prodottiDeserializzati)
    {
      Console.WriteLine($"Id: {prodotto.Id}, Nome: {prodotto.NomeProdotto}, Prezzo: {prodotto.PrezzoProdotto}, Giacenza: {prodotto.GiacenzaProdotto}, Descrizone: {prodotto.DescrizioneProdotto}");
    }

    try
    {
      ProdottoAdvanced prodotto = new ProdottoAdvanced();
      prodotto.Id = 0;
    }
    catch (ArgumentException ex)
    {
      Console.WriteLine($"Errore:{ex.Message}");
    }

    try
    {
      ProdottoAdvanced prodotto = new ProdottoAdvanced();
      prodotto.NomeProdotto = "";
    }
    catch (ArgumentException ex)
    {
      Console.WriteLine($"Errore:{ex.Message}");
    }

    try
    {
      ProdottoAdvanced prodotto = new ProdottoAdvanced();
      prodotto.PrezzoProdotto = 0;
    }
    catch (ArgumentException ex)
    {
      Console.WriteLine($"Errore:{ex.Message}");
    }

    try
    {
      ProdottoAdvanced prodotto = new ProdottoAdvanced();
      prodotto.GiacenzaProdotto = -1;
    }
    catch (ArgumentException ex)
    {
      Console.WriteLine($"Erore:{ex.Message}");
    }


  }

}

public class ProdottoAdvanced
{
  // definisco le proprietà pubblica Id in modo che possa esse letta e scritta dell'esterno della classe
  // il vantaggio di utilizzare le proprietà è che posso controllare l'accesso alla variabile privata _id e applicare della regole di validazione
  private int _id;
  public int Id
  {
    get { return _id; } // restituisce il valore della variabile privata _id
                        // set { _id = value; } // imposta il valore della variabile privata _id con il valore passato come argomento
                        // implemento la logica di validazione per il valore passato come argomento
                        // se il valore passato come argomento è minore e uguale a zero. solle un'eccezione
                        // l'eccezione interrompe l'esecuzione del programma e visualizza un messaggio di errore
                        // l'eccezione puo essere catturata e gestita in un blocco try-catch
    set
    {
      if (value <= 0)
      {
        throw new ArgumentException("Il valore di Id deve essere maggiore di zero");
      }
      _id = value; // imposta il valore della variabile privata _id con il valore passato come argomento
    }
  }
  private string _nomeProdotto;
  public string NomeProdotto
  {
    get { return _nomeProdotto; }

    set
    {
      if (string.IsNullOrEmpty(value))
      {
        throw new ArgumentException("Il nome del prodotto non può essere vuoto");
      }
      _nomeProdotto = value;
    }
  }
  private decimal _prezzoProdotto;
  public decimal PrezzoProdotto
  {
    get { return _prezzoProdotto; }

    set
    {
      if (value <= 0)
      {
        throw new ArgumentException("Il prezzo del prodotto deve essere maggiore di zero");
      }
      _prezzoProdotto = value;
    }
  }
  private int _giacenzaProdotto;
  public int GiacenzaProdotto
  {
    get { return _giacenzaProdotto; }

    set
    {

      if (value < 0)
      {
        throw new ArgumentException("La giacenza del prodotto non può essere negativa");
      }
      _giacenzaProdotto = value;
    }
  }
  private string _descrizioneProdotto;
  public string DescrizioneProdotto
  {
    get { return _descrizioneProdotto; }
    set { _descrizioneProdotto = value; }
  }

}