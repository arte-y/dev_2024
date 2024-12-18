public class MagazziniereManager
{
//puo visualizzare tutti prodotti, aggiungere modificare o rimuovere prodotti dal magazzino.
    private ProdottoRepository prodottoRepository;
    private List<Prodotto> magazzino;

    public MagazziniereManager()
    {
        prodottoRepository = new ProdottoRepository();
        magazzino = new List<Prodotto>();
    }
    
    public void AggiungiProdotto(Prodotto prodotto)
    {
        magazzino.Add(prodotto);
    }

    public void RimuoviProdotto(Prodotto prodotto)
    {
        magazzino.Remove(prodotto);
    }

    public void ModificaProdotto(Prodotto prodotto)
    {
        magazzino.Add(prodotto);
    }

    public void VisualizzaProdotti()
    {
        foreach (var prodotto in magazzino)
        {
            Console.WriteLine(prodotto);
        }
    }
}