List<string> partecipanti = new List<string> { "Tamer", "Felipe", "Diego", "Ivan", "Giorgio", "Anita", "Sofia", "Andrea" };

Random rnd = new Random();

partecipanti.Sort();

bool control = false;
for (int i = 0; i < partecipanti.Count; i++)
{
  Console.WriteLine($"Partecipanti: {partecipanti[i]}");
}


do
{

  Console.WriteLine("Vuole inserire un partecipante o eliminare o sorteggiare i partecipanti? (I/E/S)");
  string risposta = Console.ReadLine().ToLower();

  if (risposta == "i")
  {
    Console.Write("Inserice il nome partecipante: ");
    string rispostaI = Console.ReadLine();
    partecipanti.Add(rispostaI);

  }
  else if (risposta == "e")
  {
    Console.Write("Inserice il nome partecipante: ");
    string rispostaE = Console.ReadLine();
    partecipanti.Remove(rispostaE);

  }
  else if (risposta == "s")
  {
    Console.Write("inserice il numero di squadre: ");
    int numeroSquadre = int.Parse(Console.ReadLine());
    List<List<string>> squadre = new List<List<string>>();

    for (int i = 0; i < numeroSquadre; i++)
    {

      squadre.Add(new List<string>());

    }

    for (int i = 0; i < partecipanti.Count; i++)
    {
      squadre[i % numeroSquadre].Add(partecipanti[i]);
      // int index = rnd.Next(partecipanti.Count);
    }

    for (int i = 0; i < squadre.Count; i++)
    {
      Console.WriteLine($"Squadre {i + 1}: {string.Join(",", squadre[i])}");
    }
    break;
  }

} while (true);

Console.WriteLine("sfasf");



#region bla bla bla
// string risposta = null;

// Console.WriteLine("**********************************");
// do
// {
//     if (partecipanti.Count == 0)
//     {
//         Console.WriteLine("non ci sono piu partecipanti da estrare");
//         break;
//     }
//     else
//     {
//         int index = rnd.Next(partecipanti.Count);

//         string partecipante = partecipanti[index];

//         Console.WriteLine(partecipante);

//         partecipanti.RemoveAt(index);
//     }

//     Console.WriteLine("Vuoi estrare un altro partecipante? (S/N)");
//     risposta = Console.ReadLine().ToLower();

// } while (risposta == "s");
#endregion

#region prof ha fatto!
/*
// creo la lista dei partecipanti
List<string> partecipanti = new List<string> { "Partecipante 1", "Partecipante 2", "Partecipante 3", "Partecipante 4", "Partecipante 5", "Partecipante 6", "Partecipante 7", "Partecipante 8", "Partecipante 9", "Partecipante 10" };

// creo un oggetto Random per generare numeri casuali
Random random = new Random();

// pulisco la console
Console.Clear();

// stampo la lista dei partecipanti
Console.WriteLine("Partecipanti:");
foreach (string partecipante in partecipanti)
{
    Console.WriteLine(partecipante);
}

// chiedo all utente se vuole inserire o eliminare un partecipante o sorteggiare i partecipanti
while (true)
{
    Console.WriteLine("Vuoi inserire un partecipante, eliminare un partecipante o sorteggiare i partecipanti? (i/e/s)");
    string risposta = Console.ReadLine();
    // pulisco la console
    Console.Clear();
    if (risposta == "i")
    {
        Console.WriteLine("Inserisci il nome del partecipante:");
        string partecipante = Console.ReadLine();
        partecipanti.Add(partecipante);
    }
    else if (risposta == "e")
    {
        Console.WriteLine("Inserisci il nome del partecipante:");
        string partecipante = Console.ReadLine();
        partecipanti.Remove(partecipante);
    }
    else if (risposta == "s")
    {
        // chiedo all'utente il numero di squadre
        Console.WriteLine("Inserisci il numero di squadre:");
        int numeroSquadre = int.Parse(Console.ReadLine());

        // creo una lista per ogni squadra
        List<string>[] squadre = new List<string>[numeroSquadre];
        for (int i = 0; i < numeroSquadre; i++)
        {
            squadre[i] = new List<string>();
        }

        // calcolo quanti partecipanti ci sono in ogni squadra
        int partecipantiPerSquadra = partecipanti.Count / numeroSquadre;

        // se il numero di partecipanti non è divisibile per il numero di squadre, aggiungo un partecipante in più ad una squadra
        int partecipantiInPiù = partecipanti.Count % numeroSquadre;

        // per ogni squadra
        for (int i = 0; i < numeroSquadre; i++)
        {
            // aggiungo i partecipanti
            for (int j = 0; j < partecipantiPerSquadra; j++)
            {
                // genero un numero casuale tra 0 e il numero di partecipanti rimasti
                int index = random.Next(partecipanti.Count);
                // aggiungo il partecipante alla squadra
                squadre[i].Add(partecipanti[index]);
                // rimuovo il partecipante dalla lista dei partecipanti
                partecipanti.RemoveAt(index);
            }

            // se ci sono partecipanti in più, aggiungo un partecipante in più alla squadra corrente
            if (partecipantiInPiù > 0)
            {
                // genero un numero casuale tra 0 e il numero di partecipanti rimasti
                int index = random.Next(partecipanti.Count);
                // aggiungo il partecipante alla squadra
                squadre[i].Add(partecipanti[index]);
                // rimuovo il partecipante dalla lista dei partecipanti
                partecipanti.RemoveAt(index);
                // decremento il numero di partecipanti in più
                partecipantiInPiù--;
            }

            // stampo i partecipanti della squadra
            Console.WriteLine($"Squadra {i + 1}:");
            foreach (string partecipante in squadre[i])
            {
                Console.WriteLine(partecipante);
            }
            Console.WriteLine();
        }
        break;
    }
    // stampo la lista dei partecipanti
    Console.WriteLine("Partecipanti:");
    foreach (string partecipante in partecipanti)
    {
        Console.WriteLine(partecipante);
    }
}
*/
#endregion
