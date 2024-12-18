public class CassiereManager
{
    private CassaRepository cassaRepository;	
    private List<Purchases> _Acquisti;



    private double totale;

    public CassiereManager()
    {
        cassaRepository = new CassaRepository();
        _Acquisti = new List<Purchases>();
    }

    public void RegistraAcquisto(Cliente cliente)
    {
        if (cliente.StoricoAcquisti.Count > 0)
        {
            foreach (var acquisto in cliente.StoricoAcquisti)
            {
                if (acquisto.Stato == true)
                {
                    _Acquisti.Add(acquisto);
                }
            }
        }
    }

    public void CalcolaTotale()
    {
        foreach (var acquisto in _Acquisti)
        {
            double sommaPrd = 0;
            foreach (var prodotto in acquisto.Prodotti)
            {
                sommaPrd += prodotto.Prezzo;
            }
            totale += sommaPrd;
            // // _Totale += acquisto.Prodotti.Sum(x => x.Prezzo); lambda expression ile de yapabilirsin
        }

        Console.WriteLine($"Totale: {totale}");
    }

    public void GeneraScontrino()
    {
        //Eski yaptigimizi da ekleyebilirsin....
        Console.WriteLine("Scontrino:");
        foreach (var acquisto in _Acquisti)
        {
            Console.WriteLine($"Cliente: {acquisto.Cliente.UserName} Data: {acquisto.DataAcquisto}");
            Console.WriteLine("Prodotti:");
            foreach (var prodotto in acquisto.Prodotti)
            {
                Console.WriteLine($"Nome: {prodotto.Nome} Prezzo: {prodotto.Prezzo}");
            }
            Console.WriteLine($"Totale: {totale}");
        }

    }

}