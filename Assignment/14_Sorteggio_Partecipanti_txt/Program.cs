// string path = @"Sort_Part.txt";
// if (!File.Exists(path))
// {
//   File.Create(path).Close();
// }
// else
// {
//   Console.WriteLine("Il file esiste già");
// }

// Console.WriteLine("Quanti nomi vuoi sorteggiare?");
// int risposta = int.Parse(Console.ReadLine());

// string[] partecipanti = new string[risposta];

// for (int i = 0; i < risposta; i++)
// {
//     Console.WriteLine("Inserisci il nome del partecipante:");
//     partecipanti[i] = Console.ReadLine();
// }

// File.WriteAllLines(path, partecipanti);
// string[] sorteggiati = File.ReadAllLines(path);

// Console.WriteLine("I partecipanti sorteggiati sono:");
// foreach (string partecipante in sorteggiati)
// {
//     Console.Write($"{partecipante},");
// }

//***



List<string> partecipanti1 = new List<string> { "Tamer", "Felipe", "Diego", "Ivan", "Giorgio", "Anita", "Sofia", "Andrea" };

string path1 = @"Sort_.txt";
if (!File.Exists(path1))
{
  File.Create(path1).Close();
}
else
{
  Console.WriteLine("Il file esiste già");
}

File.WriteAllLines(path1,partecipanti1);

string[] parteci = File.ReadAllLines(path1);


Console.WriteLine("Quanti partecipanti vuole selezionare:");
int risposta1 = int.Parse(Console.ReadLine());

foreach (string partecipante in parteci)
{
  Console.WriteLine(partecipante);
}


//***




