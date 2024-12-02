// Gestione Files CSV

// Esempio di file CSV:

// nome, cognoe, eta
// Mario, Rossi, 30
// Luigi, Bianchi, 25

// prodotto,quantita,prezzo
// Macchina, 2, 55
// Penna, 10, 2
// Quaderno, 5, 3
// Mouse, 2, 10

// LEGGERE UN CONTENUTO DA UN FILE CSV

string path =@"test.csv"; // in questo caso il file è nella stessa cartella del programma
string[] lines = File.ReadAllLines(path); // legge tutte le righe del file e le mette in un array di stringhe

foreach (string line in lines)
{
    Console.WriteLine(line); // stampa tutte le righe del file
}

// crea una lista di stringhe partenendo dal file CSV

List<string> list = new List<string>();

foreach (var line in lines)
{
    list.Add(line);
}

// creare un file CSV con il nome del file che corrisponde al nome della prima colonna 
// ed il contento del file che corrisponde al contenuto delle altre colonne disponibili

// string[][] data =  new string[lines.Length][];

// for (int i = 0; i < lines.Length; i++)
// {
//     data[i] = lines[i].Split(',');
// }

// for (int i = 0; i < data.Length; i++)
// {
//     string fileName = data[i][0] + ".csv";
//     File.Create(fileName).Close();
// }

// for (int i = 0; i < data.Length; i++)
// {
//     string fileName = data[i][0] + ".csv";
//     File.AppendAllText(fileName, data[i][1] + "\n");
// }

// salvare csv in un file CSV inserice, prodotto, quantita, prezzo in un file CSV con il nome del file che corrisponde al nome della prima colonna 
Console.Clear();

// ! important -inizia
// string path5 = @"test5.csv";

// File.Create(path5).Close();

// while (true)
// {
//     Console.WriteLine("Inserisci il prodotto");
//     string prodotto = Console.ReadLine();

//     Console.WriteLine("Inserisci la quantita");
//     string quantita = Console.ReadLine();

//     Console.WriteLine("Inserisci il prezzo");
//     string prezzo = Console.ReadLine();

//     File.AppendAllText(path5,$"\n{prodotto}, {quantita}, {prezzo}");

//     Console.WriteLine("Vuoi inserire un altro prodotto? (s/n)");
//     string risposta = Console.ReadLine();

//     if (risposta == "n")
//     {
//         break;
//     }
// }

//! important-finit

// eliminare un elemento spiifico da un file CSV

// string[] lines1 = File.ReadAllLines(path);

// foreach (string line in lines1)
// {
//     Console.WriteLine(line); // stampa tutte le righe del file
// }

// Console.WriteLine("Quale prodotto vuoi eliminare?");
// int index = int.Parse(Console.ReadLine());

// List<string> List = new List<string>(lines);
// list.RemoveAt(index - 1);

// File.WriteAllLines(path, list);

//! eliminare un prodotto da un file CSV - inizia
Console.WriteLine("inserici il nome del prodotto che vuoi eliminare");
string prodottoDaEliminare = Console.ReadLine();

string[] lines2 = File.ReadAllLines(path);

File.Create(path).Close();

foreach (var item in lines)
{
  string[] data2 = item.Split(',');
  if (data2[0] != prodottoDaEliminare)
  {
      File.AppendAllText(path,item + "\n");
  }
}
Console.WriteLine("Prodotto eliminato");

//! eliminare un prodotto da un file CSV - finit



//! modificare un prodotto da un file CSV - inizia

Console.WriteLine("inserici il nome del prodotto che vuoi modificare");
string prodottoDaModificare = Console.ReadLine();
string[] lines4 = File.ReadAllLines(path);
File.Create(path).Close();

foreach (var item in lines)
{
  string[] data3 = item.Split(',');
  if (data3[0] == prodottoDaModificare)
  {
      Console.WriteLine("Inserisci la nuova quantita");
      string quantita2 = Console.ReadLine();

      Console.WriteLine("Inserisci il nuovo prezzo");
      string prezzo2 = Console.ReadLine();

      File.AppendAllText(path,$"{prodottoDaModificare}, {quantita2}, {prezzo2}\n");
  }
  else
  {
      File.AppendAllText(path,item + "\n");
  }
}
//! modificare un prodotto da un file CSV - finit







