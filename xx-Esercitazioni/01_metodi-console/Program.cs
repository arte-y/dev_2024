// See https://aka.ms/new-console-template for more information
// questo e un commento a riga singola

/* questo e un commento multi-riga
prova quaalcosa 
*/

// il metodo Console.WriteLine stampa a video il testo passato come argomento
Console.WriteLine("Hello, World!");

Console.WriteLine("Hello, World!"); // questo e un commento a fine riga

// il metodo Console.ReadLine legge una riga di testo da tastiera
Console.WriteLine("Inserisci il tuo nome");
string nome = Console.ReadLine(); // legge una riga di testo da testiera e la assegna alla veriable nome
// stampo il nome cncatenato con una stringa
Console.WriteLine("Ciao " + nome + "!"); // con il segno + posso concatenare stringhe con variabili
// stampo il nome concatenato con una stringa utilizzando l interpolazione
Console.WriteLine($"Ciao {nome} !"); // con l'interpolazione posso concatenare stringe variabili
Console.WriteLine("Inserici il tuo cognome");
string cognome = Console.ReadLine();
Console.WriteLine($"Ciao {nome} {cognome}!"); // con l'interpolazione posso concatenare piu variabili in modo semplificato
Console.WriteLine($"Ciao {nome.ToUpper()}!"); // il metodo ToUpper () transforma una stringa in maiuscolo
Console.WriteLine($"Ciao {nome.ToLower()}!"); // il metodo ToLower () transforma una stringa in maiuscolo
// chiedo all utente di inserire l eta

Console.WriteLine("Inserisci la tua eta:");
// leggo l eta tastiera e la assegno alla variabile eta
string eta = Console.ReadLine();
// converto l interno eta in stringa e la assegno alla varibile eta

// stampo eta
Console.WriteLine($"Hai {eta} anni");
// stampo nome cognome ed ate concatenati
Console.WriteLine($"Ciao {nome} {cognome} hai {eta} anni");

// dichiaro una variablile intera etaInt
int etaInt = 29; // inizializzo la veribile etaInt con il valore 29
string etaStr = etaInt.ToString();
// concateno etaInt cocn una stringa
Console.WriteLine($"Hai {etaInt} anni");

/* di metodi di console permettono di gestire l output o l input (il dialogo con l utente) attraverso la console
WriteLine() stampa a video una stringa
ReadLine () legge una stringa da tastiera

ho utilizzato due variabili di tipo string per memorizzare il nome e il cognome dell utente
ho utilizzato una variabili di tipo int per momerizzare l eta dell utente

il metodo ToUpper() tasforma uan stringa in maiuscolo
il metodo ToLower() tasforma uan stringa in minuscolo

ho pravato ad utilizzare la varibile intera direttamente ma mi ha dato errore parche doveva essere convertita in stringa
ho utilizzato il metodo ToString() per convirtire un intero in una stringa e l ho interpolata
*/
