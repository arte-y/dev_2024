
public class CassiereAdvancedManager
{

    // puo registrare i prodotti acquistati da un cliente che ha degli acquisti in stato completato e calcolare il totale da pagare generando lo scontrino

    public CassiereAdvancedManager()
    {
        
    }

    public void RegistraAcquisto()
    {
        Console.WriteLine("Registra acquisto:");
        // implement here
    }

    public void CalcolaTotale()
    {
        Console.WriteLine("Calcola totale:");
        // implement here
    }

    public void GeneraScontrino()
    {
        Console.WriteLine("Genera scontrino:");
        // implement here
    }

    public void Logout()
    {
        Console.WriteLine("Logout:");
        // implement here
    }

    public void Run()
    {
        Console.WriteLine("Benvenuto cassiere!");

        bool isRunning = true;

        while (isRunning)
        {
            Console.WriteLine("1. Registra acquisto");
            Console.WriteLine("2. Calcola totale");
            Console.WriteLine("3. Genera scontrino");
            Console.WriteLine("4. Logout");

            int scelta = int.Parse(Console.ReadLine());

            switch (scelta)
            {
                case 1:
                    RegistraAcquisto();
                    break;
                case 2:
                    CalcolaTotale();
                    break;
                case 3:
                    GeneraScontrino();
                    break;
                case 4:
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