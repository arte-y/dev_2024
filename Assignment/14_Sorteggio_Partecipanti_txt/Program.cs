string path = @"Sort_Part.txt";
if (!File.Exists(path))
{
  File.Create(path).Close();
}
else
{
  Console.WriteLine("Il file esiste già");
}



Console.WriteLine("Quanti nomi vuoi sorteggiare?");
int risposta = int.Parse(Console.ReadLine());

string[] partecipanti = new string[risposta];

for (int i = 0; i < risposta; i++)
{
    Console.WriteLine("Inserisci il nome del partecipante:");
    partecipanti[i] = Console.ReadLine();
}


File.WriteAllLines(path, partecipanti);
string[] sorteggiati = File.ReadAllLines(path);

Console.WriteLine("I partecipanti sorteggiati sono:");
foreach (string partecipante in sorteggiati)
{
    Console.Write($"{partecipante},");
}



