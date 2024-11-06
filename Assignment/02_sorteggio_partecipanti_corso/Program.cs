List<string> partecipanti = new List<string> { "Tamer", "Felipe", "Diego", "Ivan", "Giorgio", "Anita", "Sofia", "Andrea" };

Random rnd = new Random();

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
}

for (int i = 0; i < squadre.Count; i++)
{
    Console.WriteLine($"Squadre {i + 1}: {string.Join(",", squadre[i])}");
}



Console.WriteLine("Vorrei aggiungere una persona? (S/N)");
string rispost = Console.ReadLine().ToLower();

if (rispost == "s")
{
    Console.WriteLine("scrive il nome");
    string addNome = Console.ReadLine();
    partecipanti.Add(addNome);
}
foreach (var item in partecipanti)
{
    Console.WriteLine(item);
}

Console.WriteLine("Faccimo un* squadr con nuovo nome");

for (int k = numeroSquadre; k < partecipanti.Count; k++)
{
    squadre[k % numeroSquadre].Add(partecipanti[k]);
}

for (int j = 0; j < squadre.Count; j++)
{
    Console.WriteLine($"Squadre {j + 1}: {string.Join(",", squadre[j])}");
}








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

#region prof ha fatto!
// // 
// // creo la lista dei partecipanti
// List<string> partecipanti1 = new List<string> { "partecipante1", "partecipante 2","partecipante3", "partecipante 4","partecipante1", "partecipante 5","partecipante6", "partecipante 7", "partecipante8" };
// // creo un oggetto random per generare numeri casuali
// Random rnd1 = new Random();
// // chiedo all'uttente il numero di squadre
// Console.WriteLine("Inserici il numero di squadre");
// int numeroSquadre1 = int.Parse(Console.ReadLine());
// // creo un array di lista per stringhe per le squadre
// List<string>[] squadre1 = new List<string>[numeroSquadre1];
// // per ogni squadra creo un lista vuoto
// for (int i = 0; i < numeroSquadre1; i++)
// {
//     squadre1[i] = new List<string>();
// }
// // calcolo quanti partecipanti ci sono in ogni squadra
// int partecipantiPerSquadra1 = partecipanti1.Count / numeroSquadre1;
// // se il numero di partecipani non è divisibile per il numero di squadre aggiungo un partecipante un piu ad un squadra
// // calcolo quanti partecipanti ci sono in piu(partecipanti rimanenti)
// int partecipantiInPiu = partecipanti1.Count % numeroSquadre1;
// // per ogni squadra
// for (int i = 0; i < numeroSquadre1; i++)
// {
//     // per ogni partecipante delle squadre
//     for (int j = 0; j < partecipantiPerSquadra1; j++)
//     {

//         // genero un numero casuale tra 0 e il numero di partecipanti rimasti in modo da assegnare un partecipante di quelli rimasti ad una squadra
//         int index1 = rnd1.Next(partecipanti1.Count);
//         // aggiungo il partecipante alla squadra
//         squadre1[i].Add(partecipanti1[index1]);
//         // rimuovo il partecipante della lista dei patecipante
//         partecipanti1.RemoveAt(index1);
//     }

//     // se ci sono partecipanti in piu, aggiungo un partecipante in piu alla sqadra corrente
//     if (partecipantiInPiu > 0)
//     {
//         // genero un numero casuale tra 0 e il partecipanti rimasti
//         int index1 = rnd1.Next(partecipanti1.Count);
//         // aggiungo il partecipante alla squadra
//         squadre1[i].Add(partecipanti1[index1]);
//         // rimuovo il partecipante della lista dei patecipanti
//         partecipanti1.RemoveAt(index1);
//         // decremento il numero di partecipanti in piu
//         partecipantiInPiu--;
//     }
// // ad ogni squadra stampo i partecipanti della squadra
// Console.WriteLine($"Squadra {i +1}:");
// foreach (var item in squadre1[+1])
// {
//     Console.WriteLine(item);
// }
// }
#endregion