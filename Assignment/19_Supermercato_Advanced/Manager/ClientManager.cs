
public class ClientManager
{
    private Repository repository;
    private List<Prodotto> carrello;
    private List<Purchases> storicoAcquisti;
    private int prossimoId;

    public ClientManager()
    {
        repository = new Repository();
        carrello = new List<Prodotto>();
        storicoAcquisti = new List<Purchases>();
        prossimoId = 1;
    }

    public void VisualizzaCarrello()
    {
        Console.WriteLine("Carrello:");
        Console.WriteLine($"{"ID",-5} {"Nome",-20} {"Prezzo",-10} {"Giacenza",-10} {"Categoria",-20}");
        Console.WriteLine(new string('-', 50)); // Linea separatrice
        foreach (var prodotto in carrello)
        {
            Console.WriteLine($"{prodotto.Id,-5} {prodotto.Nome,-20} {prodotto.Prezzo,-10} {prodotto.Giacenza,-10} {prodotto.Categoria,-20}");
        }
    }

    public void AggiungiProdottoAlCarrello(Prodotto prodotto)
    {
        carrello.Add(prodotto);
    }

    public Prodotto TrovaProdotto(string nome)
    {
        foreach (var prodotto in carrello)
        {
            if (prodotto.Nome == nome)
            {
                return prodotto;
            }
        }
        return null;
    }

    // modifica un prodotto esistente dentro di carrello
    public void ModificaAlCarrello(int id, Prodotto nuovoProdotto)
    {
        var prodotto = TrovaProdotto(nuovoProdotto.Nome);
        if (prodotto != null)
        {
            prodotto.Nome = nuovoProdotto.Nome;
            prodotto.Prezzo = nuovoProdotto.Prezzo;
            prodotto.Giacenza = nuovoProdotto.Giacenza;
            prodotto.Categoria = nuovoProdotto.Categoria;
        }
    }

    public void RimuoviProdottoDalCarrello(string nome)
    {
        foreach (var prodotto in carrello)
        {
            if (prodotto != null)
            {
                carrello.Remove(prodotto);
            }
        }
    }

    public void Acquista()
    {
        decimal totale = 0;
        foreach (var prodotto in carrello)
        {
            totale += prodotto.Prezzo;
        }
        Console.WriteLine($"Totale: {totale}");
        Console.WriteLine("Confermi l'acquisto? (s/n)");
        string conferma = Console.ReadLine();
    }

    public void VisualizzaStoricoAcquisti()
    {
        Console.WriteLine("Storico Acquisti:");
        Console.WriteLine($"{"ID",-5} {"Nome",-20} {"Prezzo",-10} {"Giacenza",-10} {"Categoria",-20}");
        Console.WriteLine(new string('-', 50)); // Linea separatrice
        foreach (var acquisto in storicoAcquisti)
        {
            Console.WriteLine($"{acquisto.Id,-5} {acquisto.Cliente.UserName,-20} {acquisto.Prodotto.Nome,-10} {acquisto.Prodotto.Prezzo,-10} {acquisto.Quantita,-20} {acquisto.DataAcquisto,-20}");
        }
    }

    public void AggiungiAcquisto(Purchases acquisto)
    {
        acquisto.Id = prossimoId;
        storicoAcquisti.Add(acquisto);
    }

    public void SalvaCarrello()
    {
        repository.SalvaProdotti(carrello);
    }

    public void CaricaCarrello()
    {
        carrello = repository.CaricaProdotti();
    }

}
