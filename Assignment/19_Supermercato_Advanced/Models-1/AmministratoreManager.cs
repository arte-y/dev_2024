
public class AmministratoreAdvancedManager
{
    // puo visualizzare e impostare il ruolo dei dipendenti.

    public AmministratoreAdvancedManager()
    {
        
    }
    public void VisualizzaDipendenti()
    {
        Console.WriteLine("Dipendenti:");
        // implement here
    }

    public void ImpostaRuoloDipendente()
    {
        Console.WriteLine("Imposta ruolo dipendente:");
        // implement here
    }

    public void Logout()
    {
        Console.WriteLine("Logout:");
        // implement here
    }

    public void Run()
    {
        Console.WriteLine("Benvenuto amministratore!");

        bool isRunning = true;

        while (isRunning)
        {
            Console.WriteLine("1. Visualizza dipendenti");
            Console.WriteLine("2. Imposta ruolo dipendente");
            Console.WriteLine("3. Logout");

            int scelta = int.Parse(Console.ReadLine());

            switch (scelta)
            {
                case 1:
                    VisualizzaDipendenti();
                    break;
                case 2:
                    ImpostaRuoloDipendente();
                    break;
                case 3:
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