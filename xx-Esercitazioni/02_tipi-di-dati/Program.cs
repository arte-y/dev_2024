// i tipi di dati semplici -- TIPI DI DATI SEMPLICI

// variabili di tipo intero
int eta =10; // dichiarazione e inizializzazione di una variabile di tipo intero 

int eta2; // dichirazione di una variabile di tipo intero
eta2 = 20; // inizializzazione di una variabile di tipo intero


// variabili di tipo decimale
double altezza = 1.70; // dichiarazione e inizializzazione di una variabile di tipo decimale

// variabili di tipo carattere
char iniziale = 'M'; // dichiarazione di inizializzazione di una variabile di tipo carattere

// variabili di tipo stringa
string nome = "Mario"; //dichiarazione e inizializzazione di una variabile di tipo stringa

// variabili di tipo booleano
bool maggiorenne = true; //dichiarazzione e inizializzazione variabile di tipo booleano

// variabile var
// var e una parola chiave che permette di dichiarare una variabile senza specificare il tipo
// il tipo viene dedotto dal valore assegnato alla variabile
// var pero necessita di essere inizializzata al momento della dichiarazione
var cognome = "Rossi"; // dichiarazione e inizializzazione di una variabile var

// variabili di tipo dynamic
// dynamic e una parola chiave che permette di dichiarare una variabile il cui tipo viene assegnato a runtime
// il tipo di una variabile dynamic puo essere cambiato durante l esecuzione del programma
dynamic altezza2 = 1.70; // dichiarazione e inizializzazione di una variabile di tipo dynamic

// quindi

//variabili di tipo data
DateTime dataNascita = new DateTime(2000, 1, 1); // dichiarazzione e inizializzazione di una variabile di tipo data

// esempio di utilizzo di una variabile attraverso i metodi di console
Console.WriteLine($"La variabile eta contiene il valore {eta}"); // outout: la variabile eta contiene il valore 10
Console.WriteLine($"La variabile altezza contiene il valore {altezza}"); // output: la variabile altezza contiene il valore 1.70


// ricevo l input l utente e lo salvo in una variabile
Console.WriteLine("Incerisci il tuo nome: ");
string nomeUtente = Console.ReadLine();

Console.WriteLine($"Ciao {nomeUtente}!"); //  output: Caio Mario!

// I TIPI DI DATI COMPLESSI (o strutture di dati) 
// un insieme di dati dello stesso tipo

// ARRAY

int[] numeri = new int[5]; // dichiazarione e inizializzazione di un array di interi di 5 elementi
                        // new e una parola chiave ceh serve un nuovo oggetto (costruttore)

// inserimento di balori nell array

numeri[0] = 10;
numeri[1] = 20; 
numeri[2] = 30;
numeri[3] = 40;
numeri[4] = 50;

// inserimento di valori multipli nell array
int [] numeri2 = new int [] {10, 20, 30, 40, 50}; //dichiazarione e inizializzazione diuan array interi di 5 elementi

// la caratteristica principale degli array e che sono di dimensione fissa

// LISTA
List<int> numeri3 = new List<int> {}; // dichiarazzione di una lista di interi
                                    // le liste sono i dimensione variabile 

// inserimento di valori nella lista
numeri3.Add(10);  // inserico il valore nella lista usando il metedo Add
numeri3.Add(20);
numeri3.Add(30);
numeri3.Add(40);
numeri3.Add(50);

// METODI DI STRINGA
// i tipi di dato stringa hanno metodi che permettono di eseguire delle operrazioni su di esso o di ottenere informazioni si du essi

// lenght
// prende la lunghezza della stringa

string nome2 = "Nome1";
int lunghezza = nome2.Length; // output: 5

// isnullorwhitespace
// verifica se la stringa e nulla o vuota
string nome3 = "Nome1";
Console.WriteLine(string.IsNullOrWhiteSpace(nome3)); // output: false

// tolower
// converte la stringa in minuscolo
string nome4 = "Nome1";
Console.WriteLine(nome4.ToLower()); // output: nome1

// toupper
// converte la stringa in maiuscolo
string nome5 = "Nome1";
Console.WriteLine(nome5.ToUpper()); // output: NOME1

// trim
// rimuove gli spazi bianchi all inizio e alla fine della stringa
string nome6 = " Nome1 ";
Console.WriteLine(nome6.Trim()); // output: Nome1

// split //! importante 
// divide la stringa in sottostringhe in base a un separatore
string nome7 = "Mario,Luigi,Peach";
string[] nomi1 = nome7.Split(','); // output: ["Mario", "Luigi", "Peach"]

foreach (string nomes in nomi1)
{
    Console.WriteLine(nomes);
}

// replace //! importante
// sostituisce una sottostringa con un altra
string nome8 = "Mario";
Console.WriteLine(nome8.Replace("Mario", "Luigi")); // output: Luigi

// substring //! importante
// restituisce una sottostringa
string nome9 = "Tamer";
Console.WriteLine(nome9.Substring(0, 3)); // output: Tam

// contains
// verifica se una stringa contiene un altra stringa
string nome10 = "Yilmaz";
Console.WriteLine(nome10.Contains("Yilmaz")); // output: true

// indexof
// restituisce l indice della prima occorrenza di una sottostringa
// se la sottostringa non e presente restituisce -1
// se trova piu occorrenze restituisce l indice della prima occorrenza
string nome11 = "Tamer";
Console.WriteLine(nome11.IndexOf("Tamer")); // output: 0

// lastindexof
// restituisce l indice dell ultima occorrenza di una sottostringa
// se non trova la sottostringa restituisce -1
// parte dalla fine della stringa in questo caso la "o" si trova in pozizione 3 partendo dalla fine della stringa
string nome12 = "Nome1";
Console.WriteLine(nome12.LastIndexOf("o")); // output: 3

// startswith
// verifica se la stringa inizia con una sottostringa
string nome13 = "Nome1";
Console.WriteLine(nome13.StartsWith("Nome")); // output: true

// endswith
// verifica se la stringa finisce con una sottostringa
string nome14 = "Nome1";
Console.WriteLine(nome14.EndsWith("1")); // output: true

// tostring
// converte un oggetto in una stringa
// dovrebbe funzionare con gli int, double, char ed altri tipi di dato
int eta3 = 10;
Console.WriteLine(eta3.ToString()); // output: 10

// parse
// converte una stringa in un tipo di dato
// se la conversione non e riuscita viene generata un eccezione di tipo FormatException ed il programma si blocca
string eta4 = "10";
int eta5 = int.Parse(eta4); // output: 10

// try parse
// converte una stringa in un tipo di dato e restituisce un valore booleano che indica se la conversione e riucita
// se la conversione non e riuscita il valore convertito e 0
string eta6 = "10";
int eta7;
// bool conversioneRiuscita = int.TryParse(eta6, out eta7);
if (int.TryParse(eta6, out eta7))
{
    Console.WriteLine(eta7); // output: 10
}
else
{
    Console.WriteLine("Conversione non riuscita");
}


// convert
// converte un tipo di dato in un altro tipo di dato
// se la conversione non e riuscita viene generata un eccezione di tipo InvalidCastException ed il programma si blocca
string eta8 = "10";
Console.WriteLine(Convert.ToInt32(eta8)); // output: 10

// concatenazione con string.format //** utile
string nome15 = "Mario";
string cognome2 = "Rossi";
Console.WriteLine(string.Format("Ciao {0} {1}", nome15, cognome2)); // output: Ciao Mario Rossi

// conversione esplicita
double altezza3 = 1.70;
int altezza4 = (int)altezza3; // output: 1

// conversione con metodi
int eta9 = 10;
string eta10 = eta9.ToString(); // output: "10"



//**********************************************************

//inserimento di valori miltipili nella lista
List<int> numeri4 = new List<int> {10, 20, 30, 40, 50 }; // dichiazarione e inizializzazione di una lista interi

// sia le liste che gli array sono collezioni di dati che possono di Int, Double, Char, String, ecc.
// esempio di lista di stringhe
List<string> nomi = new List<string> {"Mario", "Luigi", "Peach",}; // dichiazarione e inizializzazione di una lista ineteri

//DIZIONARIO
Dictionary<string, int> voti = new Dictionary<string, int> (); // dichiazarione di un dizionario con chiave di tipo stringa e un valore intero
// in questo caso string e la chiave ed int al valore

// BEST PRACTICES PER LA DICHIARAZIONE DI VARIABILI
//dichiarare le varibili con nomi significativi
// dichiarare le varibili con la notazione CamelCase o PascalCase
// esempio camel case etaStudente
// esempio pascal case EtaStudente

