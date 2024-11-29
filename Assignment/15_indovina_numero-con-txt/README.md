# Indovina numero Con txt

## Obiettivo

Implementare la persistenza del dioco "indovina numero" su file di testo (versione con funzioni)

- Implementare una funzione che criva l'elenco dei tentativi fatti dall'utente su file di testo.

- Il programma chiede all'utente di inserire il proprio nome ad usa (input utente) per creare un file di testo con il nome dell'utente (esempio "nomeutente.txt")



Codice il programma 
```csharp
Console.Clear();
Random random = new Random();
int numeroDaIndovinare = 0;
int punteggio = 0;
bool haIndovinato = false;
int tentativi = 0;
int numeroUtente = 0;

Dictionary<string, List<int>> tentativiUtenti = new Dictionary<string, List<int>>(); // creo un dizionario per memorizzare i tentativi degli utenti
string risposta = "s";

string nomeUtente1 = string.Empty;

do
{
    int scelta = 0;
    do
    {
        Menudifficolta();

        bool successoLivelloDifficolta = int.TryParse(Console.ReadLine(), out scelta);
        
        // pulisco la console
        Console.Clear();

        if (!successoLivelloDifficolta || scelta < 1 || scelta > 3)
        {
            Console.WriteLine("Scelta non valida.");
        }
        
    } while (scelta < 1 || scelta > 3);

    switch (scelta)
    {
        case 1:
            SceltaUno();
            break;
        case 2:
            SceltaDue();
            break;
        case 3:
            SceltaTre();
            break;
        default:
            Console.WriteLine("Scelta non valida.");
            break;
    }

    // !Console.WriteLine($"Ecco secret number {numeroDaIndovinare}");
    nomeUtente1 = NomeIndovinaTentativo();
    StampaIndovinato();

    StampaTentativiUtenti();

    GiocareDiNuovo();

    GiocareDiNuovoRisposta();

    haIndovinato = false;

} while (risposta == "s" || risposta == "S");



#region funzioni

void Menudifficolta()
{
    Console.WriteLine("Scegli il livello di difficolta':");
    Console.WriteLine("1. Facile (1-50, 10 tentativi)");
    Console.WriteLine("2. Medio (1-100, 7 tentativi)");
    Console.WriteLine("3. Difficile (1-200, 5 tentativi)");
}

void SceltaUno()
{
    numeroDaIndovinare = random.Next(1, 51);
    punteggio = 100;
    tentativi = 10;
}

void SceltaDue()
{
    numeroDaIndovinare = random.Next(1, 101);
    punteggio = 200;
    tentativi = 7;
}

void SceltaTre()
{
    numeroDaIndovinare = random.Next(1, 201);
    punteggio = 300;
    tentativi = 5;
}

string NomeIndovinaTentativo()
{
    Console.WriteLine("Inserisci il tuo nome e cognome:");
    string nomeUtente = Console.ReadLine();
    string nomeUtente1 = nomeUtente.Split(' ') [1];

    Console.WriteLine($"Indovina il numero. Punteggio massimo: {punteggio} punti.");
    while (!haIndovinato && tentativi > 0)
    {
        Console.Write("Tentativo: ");
        bool successo = int.TryParse(Console.ReadLine(), out numeroUtente);
        // pulisco la console
        Console.Clear();

        if (!successo)
        {
            Console.WriteLine("Inserisci un numero valido.");
            continue;
        }

        tentativi--;
        // aggiungo il tentativo alla lista del nomeUtente
        if (!tentativiUtenti.ContainsKey(nomeUtente1))
        {
            tentativiUtenti.Add(nomeUtente1, new List<int>());
        }

        tentativiUtenti[nomeUtente1].Add(numeroUtente); // aggiungo il tentativo alla lista del nomeUtente uso [nomeUtente] per accedere alla lista del nomeUtente

        if (numeroUtente < numeroDaIndovinare)
        {
            Console.WriteLine("Il numero da indovinare e' maggiore.");
        }
        else if (numeroUtente > numeroDaIndovinare)
        {
            Console.WriteLine("Il numero da indovinare e' minore.");
        }
        else
        {
            Console.WriteLine($"Hai indovinato! Punteggio: {punteggio}");
            haIndovinato = true;
        }

        if (!haIndovinato && tentativi == 0)
        {
            Console.WriteLine($"Hai esaurito i tentativi. Il numero era {numeroDaIndovinare}.");
        }
    }
    return nomeUtente1;
}

void StampaIndovinato()
{
        if (haIndovinato)
    {
        // stampa il punteggio dell utente
        Console.WriteLine($"Punteggio: {punteggio}");
    }
}

void StampaTentativiUtenti()
{
    Console.WriteLine("Tentativi effettuati: ");

    foreach (var tentativoUtente in tentativiUtenti)
    {
        Console.WriteLine($"Sig: {tentativoUtente.Key}: {string.Join(", ", tentativoUtente.Value)}"); // stampo i tentativi degli utenti
    }
}

void GiocareDiNuovo()
{
    Console.WriteLine("Vuoi giocare di nuovo? (s/n)");
    risposta = Console.ReadLine();
    Console.Clear();
}

void GiocareDiNuovoRisposta()
{
    while (risposta != "s" && risposta != "S" && risposta != "n" && risposta != "N")
    {
        Console.WriteLine("Risposta non valida. Vuoi giocare di nuovo? (s/n)");
        risposta = Console.ReadLine();
        Console.Clear();
    }
}

#endregion


#region con txt

Console.Clear();

string path = @$"{nomeUtente1}.txt";
if (!File.Exists(path))
{
    File.Create(path).Close();
}
else
{
    Console.WriteLine("Il file esiste già");
}

foreach (var tentativoUtente in tentativiUtenti)
{
    File.AppendAllText(path, $"Sig: {tentativoUtente.Key}: {string.Join(", ", tentativoUtente.Value)}\n");
}

Console.WriteLine("Tentativi salvati su file.");



#endregion
```
```bash
git add --all
git commit -m "indovina numero versione 1 con txt"
git push -u origin main
```
