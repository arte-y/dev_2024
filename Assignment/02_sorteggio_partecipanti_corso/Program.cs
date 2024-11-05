// Lista di partecipante di corso dev2024

List<string> partecipanti = new List<string> { "Tamer", "Felipe", "Diego", "Ivan", "Giorgio", "Anita", "Sofia", "Andrea" };

Random rnd = new Random();

Console.WriteLine("inserice il numero di squadre: ");
int numeroSquadre =int.Parse(Console.ReadLine());


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


// ****************************************************************************************


Console.WriteLine("Divide squadre che vuole creare squadre da questo gruppo");
int divisoU =int.Parse(Console.ReadLine());


List<string> ListPart = new List<string>
{"Tamer", "Andrea", "Felipe", "Ivan", "Anita", "Sofia", "Giorgio", "Diego"};

var rnd = new Random();
int rndNome = rnd.Next(ListPart.Count);

int diviso = ListPart.Count / divisoU;

if (diviso%2==1)
Console.WriteLine("diviso bene");
else
Console.WriteLine("fuori di gruppo uno persone");

Console.WriteLine(diviso);
// Console.WriteLine(ListPart[rndNome]);

Console.WriteLine("Cioa, vuole vedere partecipante di corso? Dai iniziamo!");

bool control = true;
string control1 = string.Empty;
do
{
    for (int i = rndNome; i < ListPart.Count; i++)
    {
        Console.WriteLine($"Il nome: {ListPart[i]}");
        // ListPart.Remove(ListPart[i]);
        // ListPart.Remove(ListPart[rndNome]);

        if (i <= ListPart.Count)
        {
            Console.WriteLine("voule vedere altr partecipante? (S/N)");
            control1 = Console.ReadLine().ToLower();
        }
        else
        {
            Console.WriteLine("Terminato!");
        }
    }


} while (control1 == "s");



// Console.WriteLine("Vuole vedere tutte le partecipante?(s/n)");
// string control2 = Console.ReadLine();

// if (control2 == "s")
// {
//     for (int i = rndNome; i < ListPart.Count; i++)
//     {
//         Console.WriteLine($"Il nome: {ListPart[i]}");
//     }
// }
// else
//     Console.WriteLine("Good Bye");
