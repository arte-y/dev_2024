public class ClienteManager
{
    // Può aggiungere o rimuovere prodotti e cambiare lo stato dell ordine
    private ProdottoRepository prodottoRepository;
    private ClienteRepository clienteRepository;
    private List<Purchases> storicoAcquisti;
    private List<Prodotto> carrello;
    private int prossimoId;

    public ClienteManager()
    {
        prodottoRepository = new ProdottoRepository();
        clienteRepository = new ClienteRepository();
        carrello = new List<Prodotto>();
        storicoAcquisti = new List<Purchases>();
        prossimoId = 1;
    }
    public void AggiungiProdotto(Prodotto prodotto)
    {
        carrello.Add(prodotto);
    }

    public void RimuoviProdotto(Prodotto prodotto)
    {
        carrello.Remove(prodotto);
    }

    public void CambiaStatoOrdine(Purchases ordine, bool stato)
    {
        ordine.Stato = stato;
    }
}

//! vecchio codice
// public class ClientManager
// {
//     private ProdottoRepository repository;
//     private List<Prodotto> carrello;
//     private List<Purchases> storicoAcquisti;
//     private int prossimoId;

//     public ClientManager()
//     {
//         repository = new ProdottoRepository();
//         carrello = new List<Prodotto>();
//         storicoAcquisti = new List<Purchases>();
//         prossimoId = 1;
//     }

//     public void VisualizzaCarrello()
//     {
//         Console.WriteLine("Carrello:");
//         Console.WriteLine($"{"ID",-5} {"Nome",-20} {"Prezzo",-10} {"Giacenza",-10} {"Categoria",-20}");
//         Console.WriteLine(new string('-', 50)); // Linea separatrice
//         foreach (var prodotto in carrello)
//         {
//             Console.WriteLine($"{prodotto.Id,-5} {prodotto.Nome,-20} {prodotto.Prezzo,-10} {prodotto.Giacenza,-10} {prodotto.Categoria,-20}");
//         }
//     }

//     public void AggiungiProdottoAlCarrello(Prodotto prodotto)
//     {
//         carrello.Add(prodotto);
//     }

//     public Prodotto TrovaProdotto(int id)
//     {
//         return carrello.FirstOrDefault(p => p.Id == id);
//     }

//     public void ModificaAlCarrello(int id, Prodotto nuovoProdotto)
//     {
//         var prodotto = TrovaProdotto(id);
//         if (prodotto != null)
//         {
//             prodotto.Id = nuovoProdotto.Id;
//             prodotto.Nome = nuovoProdotto.Nome;
//             prodotto.Prezzo = nuovoProdotto.Prezzo;
//             prodotto.Giacenza = nuovoProdotto.Giacenza;
//             prodotto.Categoria = nuovoProdotto.Categoria;
//         }
//     }

//     public void RimuoviProdottoDalCarrello(int id)
//     {
//         var prodottoDaRimuovere = carrello.FirstOrDefault(p => p.Id == id);
//         if (prodottoDaRimuovere != null)
//         {
//             carrello.Remove(prodottoDaRimuovere);
//         }
//     }

//     public void Acquista()
//     {
//         double totale = 0;
//         foreach (var prodotto in carrello)
//         {
//             totale += prodotto.Prezzo;
//         }
//         Console.WriteLine($"Totale: {totale}");
//         Console.WriteLine("Confermi l'acquisto? (s/n)");
//         string conferma = InputManager.LeggiStringa("Conferma:");
//     }

//     public void VisualizzaStoricoAcquisti()
//     {
//         Console.WriteLine("Storico Acquisti:");
//         Console.WriteLine($"{"ID",-5} {"Nome",-20} {"Prezzo",-10} {"Giacenza",-10} {"Categoria",-20}");
//         Console.WriteLine(new string('-', 50)); // Linea separatrice
//         foreach (var acquisto in storicoAcquisti)
//         {
//             Console.WriteLine($"{acquisto.Id,-5} {acquisto,-20} {acquisto,-10} {acquisto,-10} {acquisto,-20}"); //! manca qualcosa qui!!!!
//         }
//     }

//     public void AggiungiAcquisto(Purchases acquisto)
//     {
//         acquisto.Id = prossimoId;
//         storicoAcquisti.Add(acquisto);
//     }

//     public List<Prodotto> OttieniCarrello()
//     {
//         return carrello;
//     }
// }