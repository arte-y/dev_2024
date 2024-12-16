public class ProdottoManager
{
  private Repository repository;
  private int prossimoId;
  private List<Prodotto> prodotti; // prodotti e private perchè non voglio che vengano modificati dall'esterno

  public ProdottoManager(List<Prodotto> prodotti)
  {

    this.prodotti = prodotti;
    repository = new Repository();
    prossimoId = 1;
    foreach (var prodotto in prodotti)
    {
      if (prodotto.Id >= prossimoId)
      {
        prossimoId = prodotto.Id + 1;
      }
    }

  }

  public void AggiungiProdotto(Prodotto prodotto)
  {
    prodotto.Id = prossimoId;
    prossimoId++;
    prodotti.Add(prodotto);

  }
  // metodo per visualizzare tutti i prodotti
  public List<Prodotto> OttieniProdotti()
  {
    return prodotti;
  }
  
  public void StampaProdottoIncolonnati ()
  {
    // intestazione con larghezza fissa
    Console.WriteLine($"{"ID", -5} {"Nome", -20} {"Prezzo", -10} {"Giacenza", -10} {"Categoria", -20}");
    
    Console.WriteLine(new string('-', 50)); // Linea separatrice
    
    // stampa ogni prodotto cn larghezza fissa
    foreach (var prodotto in prodotti)
    {
      Console.WriteLine($"{prodotto.Id, -5} {prodotto.Nome, -20} {prodotto.Prezzo, -10} {prodotto.Giacenza, -10} {prodotto.Categoria, -20}");
    }
  }

  public Prodotto TrovaProdotto(int id)
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
  public void AggiornaProdotto(int id, Prodotto nuovoProdotto)
  {
    var prodotto = TrovaProdotto(id);
    if (prodotto != null)
    {
      prodotto.Nome = nuovoProdotto.Nome;
      prodotto.Prezzo = nuovoProdotto.Prezzo;
      prodotto.Giacenza = nuovoProdotto.Giacenza;
      prodotto.Categoria = nuovoProdotto.Categoria;
    }
  }
  // metodo per eliminare un prodotto
  public void EliminaProdotto(int id)
  {
    var prodotto = TrovaProdotto(id);
    if (prodotto != null)
    {
      prodotti.Remove(prodotto);
      File.Delete($@"Data/Prodotto{prodotto.Id}.json");
    }
  }

  

}