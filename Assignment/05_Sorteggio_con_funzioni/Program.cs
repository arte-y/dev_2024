using System.Diagnostics;

List<string> partecipanti = new List<string> { "Tamer", "Felipe", "Diego", "Ivan", "Giorgio", "Anita", "Sofia", "Andrea" };

//Random rnd = new Random();

partecipanti.Sort();

bool control = false;

partecipante(partecipanti);

do
{

  string risposta = Menu();

  if (risposta == "i")
  {
    InserisciPartecipante(partecipanti);

  }
  else if (risposta == "e")
  {
    EliminaPartecipante(partecipanti);
  }
  else if (risposta == "s")
  {
    Sorteggio(partecipanti);
    break;
  }

} while (true);


#region funzioni

void partecipante(List<string> partecipanti)
{
  for (int i = 0; i < partecipanti.Count; i++)
  {
    Console.WriteLine($"Partecipanti: {partecipanti[i]}");
  }
}

string Menu()
{
  Console.WriteLine("Vuole inserire un partecipante o eliminare o sorteggiare i partecipanti? (I/E/S)");
  string risposta = Console.ReadLine().ToLower();
  return risposta;
}

void InserisciPartecipante(List<string> partecipanti)
{
  Console.Write("Inserice il nome partecipante: ");
  string risposta = Console.ReadLine();
  partecipanti.Add(risposta);
}

void EliminaPartecipante(List<string> partecipanti)
{
  Console.Write("Elemina il nome partecipante: ");
  string risposta = Console.ReadLine();
  partecipanti.Remove(risposta);
}

void Sorteggio(List<string> partecipanti)
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
}

#endregion