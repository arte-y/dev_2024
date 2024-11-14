

using System.Net;

bool giocareDiNuovo = true;
bool contolPunteggio = false;
int punteggioUtente = 100;
int punteggioComputer = 100;


while (giocareDiNuovo)
{
    int utenteDado = UtenteLanciaDado();
    int computerDado = ComputerLanciaDado();

    ControlVinto(utenteDado, computerDado, punteggioComputer, punteggioUtente);

    if (punteggioComputer == 0)
    {
        Console.WriteLine("Il computer ha perso!");
        giocareDiNuovo = false;
    }
    else if (punteggioUtente == 0)
    {
        Console.WriteLine("L'utente ha perso!");
        giocareDiNuovo = false;
    }

    // string risposta = ControlGiocareDiNuovo();
    // if (risposta == "s")
    // {
    //     giocareDiNuovo = true;
    // }
    // else
    // {
    //     Console.WriteLine("Grazie finita!");
    //     break;
    // }

}

#region funzioni

int UtenteLanciaDado()
{
    Random rnd = new Random();
    int utenteDado = rnd.Next(1, 7);
    Console.WriteLine("Utente lancia il dado...");
    Console.ReadLine();
    Thread.Sleep(2000);
    Console.WriteLine($"Il risultato del lancio è: {utenteDado}");
    return utenteDado;
}

int ComputerLanciaDado()
{
    Random rnd = new Random();
    int computerDado = rnd.Next(1, 7);
    Console.WriteLine("Computer lancia il dado...");
    Thread.Sleep(2000);
    Console.WriteLine($"Il risultato del lancio è: {computerDado}");
    return computerDado;
}

void ControlVinto(int utenteDado, int computerDado, int punteggioComputer, int punteggioUtente)
{
    if (utenteDado > computerDado)
    {
        punteggioUtente += 10 + (utenteDado - computerDado);
        punteggioComputer -= 10 + (utenteDado - computerDado);
        Console.WriteLine($"Utente ha vinto! Punteggio: {punteggioUtente}");
    }
    else if (utenteDado < computerDado)
    {
        punteggioUtente -= 10 + (computerDado - utenteDado);
        punteggioComputer += 10 + (computerDado - utenteDado);
        Console.WriteLine($"Il computer ha vinto! Punteggio: {punteggioComputer}");
    }
    else
    {
        Console.WriteLine("Uguale!");
    }

    Console.WriteLine($"L'utente punteggio; {punteggioUtente}");
    Console.WriteLine($"Il computer punteggio: {punteggioComputer}");
}

string ControlGiocareDiNuovo()
{
    Console.WriteLine("Vuole giocare di nuovo? (s/n)");
    string risposta = Console.ReadLine().ToLower();
    return risposta;
}



















#endregion




