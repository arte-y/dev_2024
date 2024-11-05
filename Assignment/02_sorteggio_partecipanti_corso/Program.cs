// Lista di partecipante di corso dev2024

List<string> ListPart = new List<string>();

ListPart.Add("Andrea");
ListPart.Add("Felipe");
ListPart.Add("Giorgio");
ListPart.Add("Ivan");
ListPart.Add("Anita");
ListPart.Add("Sofia");
ListPart.Add("Diego");
ListPart.Add("Tamer");

var rnd = new Random();
int rndNome = rnd.Next(ListPart.Count);

Console.WriteLine(ListPart[rndNome]);


Console.WriteLine("Cioa, vuole vedere partecipante di corso? Dai iniziamo!");


bool control = true;
string control1 = string.Empty;
do
{

    for (int i = 0; i < ListPart.Count; i++)
    {
        Console.WriteLine(ListPart[i]);
        if (control)
        {
            Console.WriteLine("voui vedere altr partecipante? (S/N)");
            control1 = Console.ReadLine().ToLower();
        }
        else
        {
            Console.WriteLine("Terminato!");
        }
    }


} while (control1 == "s");