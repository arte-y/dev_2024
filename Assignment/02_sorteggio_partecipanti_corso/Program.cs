List<string> partecipanti = new List<string> { "Tamer", "Felipe", "Diego", "Ivan", "Giorgio", "Anita", "Sofia", "Andrea" };

Random rnd = new Random();

Console.Write("inserice il numero di squadre: ");
int numeroSquadre =int.Parse(Console.ReadLine());

List<List<string>> squadre = new List<List<string>>();

for (int i = 0; i < numeroSquadre; i++)
{
  squadre.Add(new List<string>());
}

for (int i = 0; i < partecipanti.Count; i++)
{
  squadre[i %numeroSquadre].Add(partecipanti[i]);
}

for (int i = 0; i < squadre.Count; i++)
{
  Console.WriteLine($"Squadre {i+1}: {string.Join(",",squadre[i])}");
}

string risposta = null;

do
{
  if (partecipanti.Count == 0)
  {
    Console.WriteLine("non ci sono piu partecipanti da estrare");
    break;
  }
  else
  {
    int index = rnd.Next(partecipanti.Count);

    string partecipante = partecipanti[index];

    Console.WriteLine(partecipante);

    partecipanti.RemoveAt(index);
  }

  Console.WriteLine("Vuoi estrare un altro partecipante? (S/N)");
  risposta = Console.ReadLine().ToLower();

} while (risposta == "s");