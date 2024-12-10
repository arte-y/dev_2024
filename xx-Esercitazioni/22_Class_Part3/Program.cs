using Newtonsoft.Json;
class Program
{
  static void Main(string[] args)
  {
    // Cercare una ogetto di tipo ProdottoAdvancedManager per gestire i prodotti
    ProdottoAdvancedManager manager = new ProdottoAdvancedManager();

    // Aggiungere un prodotto alla lista con il metodo AggiungiProdotto della class ProdottoAdvancedManager(manager)

    manager.AggiungiProdotto(new ProdottoAdvanced {Id =1, NomeProdotto = "Prodotto A", PrezzoProdotto = 10.50m, GiacenzaProdotto = 100, DescrizioneProdotto = "Prodotto A Descrizione" });
    manager.AggiungiProdotto(new ProdottoAdvanced {Id =2, NomeProdotto = "Prodotto B", PrezzoProdotto = 20.50m, GiacenzaProdotto = 200, DescrizioneProdotto = "Prodotto B Descrizione" });

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
    ProdottoAdvanced nuovoProdotto = new ProdottoAdvanced {Id = 2, NomeProdotto = "Prodotto C", PrezzoProdotto = 30.50m, GiacenzaProdotto = 300, DescrizioneProdotto = "Prodotto C Descrizione" };
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

  }
}

