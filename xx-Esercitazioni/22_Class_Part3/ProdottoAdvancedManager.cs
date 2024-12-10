
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
