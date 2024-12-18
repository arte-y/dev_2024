
public class InputManager
{
    public static int LeggiIntero(string messaggio, int min = int.MinValue, int max = int.MaxValue)
    {
        int valore;
        while (true)
        {
            Console.WriteLine($"{messaggio}");
            string input = Console.ReadLine();

            if (int.TryParse(input, out valore) && valore >= min && valore <= max)
            {
                return valore;
            }
            else
            {
                Console.WriteLine($"inserice un valore intero compreso tra {min} e {max}."); // messahio di errore
            }
        }
    }

    public static double LeggiDouble(string messaggio, double min = double.MinValue, double max = double.MaxValue)
    {
        double valore;
        while (true)
        {
            Console.WriteLine($"{messaggio}");
            string input = Console.ReadLine();

            if (double.TryParse(input, out valore) && valore >= min && valore <= max)
            {
                return valore;
            }
            else
            {
                Console.WriteLine($"inserice un valore double compreso tra {min} e {max}."); // messahio di errore
            }
        }
    }

    public static decimal LeggiDecimale(string messaggio, decimal min = decimal.MinValue, decimal max = decimal.MaxValue)
    {
        decimal valore;
        while (true)
        {
            Console.WriteLine($"{messaggio}");
            string input = Console.ReadLine();

            if (input.Contains("."))
            {
                input = input.Replace(".", ",");
            }

            if (decimal.TryParse(input, out valore) && valore >= min && valore <= max)
            {
                return valore;
            }
            else
            {
                Console.WriteLine($"Inserisci un valore decimale compreso tra {min} e {max}.");
            }
        }
    }

    public static string LeggiStringa(string messaggio, bool obbligatorio = true)
    {
        while (true)
        {
            Console.WriteLine($"{messaggio}");
            string input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input) || !obbligatorio)
            {
                return input;
            }
            else
            {
                Console.WriteLine("Il valore non può essere vuoto. Riprova.");
            }
        }
    }

    public static bool LeggiConferma(string messaggio)
    {
        while (true)
        {
            Console.WriteLine($"{messaggio} (s/n)");
            string input = Console.ReadLine().ToLower();
            if (input == "s" || input == "si")
            {
                return true;
            }
            if (input == "n" || input == "no")
            {
                return false;
            }
            Console.WriteLine("Errore: Rispondere 's' o 'n'.");

        }
    }


}