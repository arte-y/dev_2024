// Gestione File Txt

// LEGGERE UN CONTENUTO DA UN FILE TXT

string path =@"test.txt"; // in questo caso il file è nella stessa cartella del programma

string[] lines = File.ReadAllLines(path); // legge tutte le righe del file e le mette in un array di stringhe
foreach (string line in lines)
{
    Console.WriteLine(line); // stampa tutte le righe
}

string [] nomi = new string [lines.Length]; // crea un array di stringa con lunghezza del numero di right del file
for (int i = 0; i < lines.Length; i++)
{
  nomi[i] = lines [i]; // assegna ad ogni elemento dell'array di stringhe il valore della riga corrispondente
}
foreach (string nome in nomi)
{
  Console.WriteLine(nome); // stampa la riga
}

// SCRIVERE UN CONTENUTO DA UN TXT E STAMPARE SOLO LE RIGHE CHE INIZIANO CON UNA DETERMINATA LETTERA

foreach (string line in lines)
{
    if (line.StartsWith("n")) // se la riga inizia con la lettera A
    {
        Console.WriteLine(line); // stampa la riga
    }
}

Console.Clear();

// SCRIVERE UN CONTENUTO DA UN TXT E STAMPARE SOLO LE RIGHE CHE INIZIANO CON UNA DETERMINATA LETTERA
// se nessun nome inizia con la lettera scelta da un messaggio di errore

string path1 = @"test.txt"; 
string[] lines1 = File.ReadAllLines(path1);

bool isControl=true;

foreach (string line in lines1)
{
    if (line.StartsWith("t"))
    {
        Console.WriteLine(line);
        isControl=false;
    }
}
if (isControl)
Console.WriteLine("Errore");

// LEGGERE UN CONTENUTO DA UN FILE TXT E STAMPARE SOLO LE RIGHE CHE CONTENGONO UNA DETERMINATA LETTERA
// SE NESSUN NOME CONTIENE LA LETTERA SCELTA STAMPA UN MESSAGGIO DI ERRORE
// CREARE UN TXT CON LE RIGHE CHE INIZIANO CON LA LETTERA SCELTA

string path2 = @"testOutput.txt"; // in questo caso il file è nella stessa cartella del programma
File.Create(path2).Close(); // crea il file e lo chiude subito

foreach (string line in lines)
{
    if (line.StartsWith("t")) // se la riga contiene la lettera A
    {
        File.AppendAllText(path2, line + "\n"); // scrive la riga nel file
        isControl=false;
    }
}
if (isControl)
{
    Console.WriteLine("Errore1");
}
Console.Clear();

// AGGIUNGERE UNA RIGA DI TESTO IN UNA POZIONE SPECIFICA
// stampa la lunghezza dell array
Console.WriteLine(lines.Length);
lines[lines.Length - 2] += "indirizzo"; // aggiunge "indirizzo" alla penultima riga
File.WriteAllLines(path2, lines); // scrive tutte le righe nel file

// Aggiungere una riga di testo in una pozisione specifica usando l'accento circonflesso

lines [^ 2] += "numero di telefono"; // aggiunge "numero di telefono" alla penultima riga
File.WriteAllLines(path2, lines); // scrive tutte le righe nel file

// Sovrasscrive una riga di testo in una posizione specifica

lines[lines.Length -2] = "numero di telefono"; // sovrascrive la penultima riga
File.WriteAllLines(path2, lines); // scrive tutte le righe nel file

