
public class ClientAdvancedManager
{
    private List<Prodotto> prodotti;

    public ClientAdvancedManager()
    {
        
    }
    

    public void VisualizzaProdotti()
    {
        Console.WriteLine("Prodotti disponibili:");
        // implement qui
    }

    public void CercaProdotto()
    {
        Console.WriteLine("Cerca prodotto:");
        // implement qui
    }

    public void AggiungiAlCarrello()
    {
        Console.WriteLine("Aggiungi al carrello:");
        // implement qui
    }

    public void RimuoviDalCarrello()
    {
        Console.WriteLine("Rimuovi dal carrello:");
        // implement qui
    }

    public void ModificaAlCarrello()
    {
        Console.WriteLine("Modifica al carrello:");
        // implement qui
    }

    public void VisualizzaCarrello()
    {
        Console.WriteLine("Carrello:");
        // implement qui
    }

    // stato dell'ordine che significa che l'ordine è stato effettuato

    public void StatoOrdine()
    {
        Console.WriteLine("Stato ordine:");
        // implement qui


    }

    public void Paga()
    {
        Console.WriteLine("Paga:");
        // implement qui

    }

    public void Logout()
    {
        Console.WriteLine("Logout:");
        // implement qui
    }

    public void Run()
    {
        Console.WriteLine("Benvenuto al supermercato!");

        bool isRunning = true;

        while (isRunning)
        {
            Console.WriteLine("1. Visualizza prodotti");
            Console.WriteLine("2. Cerca prodotto");
            Console.WriteLine("3. Aggiungi al carrello");
            Console.WriteLine("4. Rimuovi dal carrello");
            Console.WriteLine("5. Modifica al carrello");
            Console.WriteLine("6. Visualizza carrello");
            Console.WriteLine("7. Stato ordine");
            Console.WriteLine("8. Paga");
            Console.WriteLine("9. Logout");

            string scelta = Console.ReadLine();

            switch (scelta)
            {
                case "1":
                    VisualizzaProdotti();
                    break;
                case "2":
                    CercaProdotto();
                    break;
                case "3":
                    AggiungiAlCarrello();
                    break;
                case "4":
                    RimuoviDalCarrello();
                    break;
                case "5":
                    ModificaAlCarrello();
                    break;
                case "6":
                    VisualizzaCarrello();
                    break;
                case "7":
                    StatoOrdine();
                    break;
                case "8":
                    Paga();
                    break;
                case "9":
                    Logout();
                    isRunning = false;
                    break;
                default:
                    Console.WriteLine("Scelta non valida");
                    break;
            }
        }
    }



}