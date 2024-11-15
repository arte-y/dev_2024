// FUNZIONI
// una funzione è un blocco di codice che esegue un compito specifico
// ci sono funzioni che elaborano i dati ma non restituiscono alcun valore
// ci sono funzioni che restituiscono un valore

// una funzione e composta da:
// - nome
// - parametri

// un esempio di funzione che non restituisce alcun valore(void)
// void NomeFunzione(parametri)
// {
//   codice
// }
// blocco di codice cesterno alla funzione che la chiama

// le funzioni hanno anche di modificatori di accesso come public e private che ne limitano la visibilità
// una funzione public può essere chiamata da qualsiasi parte del programma
// una funzione private può essere chiamata solo all'interno della classe in cui è definita

// quindi una funzione completa di motificatore di accesso potrebbe esser cosi:
// public void NomeFunzione(parametri)
// {
//   codice
// }
// blocco d codice esterno alla funzione che la chiama

// un esempio di funzione void che stampa un messaggio

void StampaMessaggio() //! usa pascal case
{
    Console.WriteLine("funzione void");
}

StampaMessaggio(); // utilizzo della funzione

// esempio di funzione void che stampa un messaggio con un parametro
void StampaMessaggioConParametro(string messaggio) //! usa pascal case
{
    Console.WriteLine(messaggio);
}

StampaMessaggioConParametro("funzione void con parametro"); // utilizzo della funzione

// esempio di funzione che stampa un messaggio cn piu parametri
void StampaMessaggioConPiuParametri(string messaggio1, string messaggio2) //! usa pascal case
{
    Console.WriteLine($"{messaggio1} {messaggio2}");
}
StampaMessaggioConPiuParametri("funzione void con", "piu parametri"); // utilizzo della funzione

// esempio di funzione che restituisce un valore
// una funzione che restituisce un valore deve specificare il tipo di quel valore al posto di void
// poiche prende due interi come  parametri e restituisce la loro somma, il tipo di ritorno e int anziche void
int Somma(int a, int b) //! usa pascal case
{
    return a + b; // restituisce la somma di a e b
}
int risultato = Somma(2, 3); // utilizzo della funzione
Console.WriteLine(risultato); // stampa: 5

// esempio di funzione che restituisce una stringa
string Saluta(string nome) //! usa pascal case
{
    return $"Ciao {nome}!"; // restituisce una stringa con il nome passato come parametro
}
string saluto = Saluta("Studente"); // utilizzo della funzione
Console.WriteLine(saluto); // stampa: Ciao studente

// esempio di funzione che restituisce un booleano
bool ParolaPari(string parola) //! usa pascal case
{
    return parola.Length % 2 == 0; // restituisce true se la lunghezza della parola e un intero pari, false altrimenti
} 
bool risultatoPari = ParolaPari("cane"); // utilizzo della funzione 
Console.WriteLine(risultatoPari); // stampa: true/  false


// esempio di funzione che restituisce piu valori //
// puo essere void anche se restitusce dei valori perche abbiamo usato i parametri out
// in pratica non c'è il return
// una funzione puo restituire piu valori utilizzando i parametri out

void Divisione(int dividendo, int divisore, out int quoziente, out int resto) //! usa pascal case
{
    quoziente = dividendo / divisore; // calcola il quoziente
    resto = dividendo % divisore; // calcola il resto
    // non posso fare un return di due valori, quindi uso i parametri out
}

// ! Prof ha fatto uan esempio con ref - controllo REF (e ref-out diffrenza)

int q, r; // (q=quoziente --- r=resto) dichiaro le variabili che conterranno i valori restituiti dalla funzione
Divisione(10, 3, out q, out r); // utilizzo della funzione
Console.WriteLine($"Quoziente: {q}, Resto: {r}"); // stampa: Quoziente: 3, Resto: 1

Console.Clear();
// esempio di funzione che restituisce un array
// in questo caso viene restituito un array contenente i primi n numeri pari
int[] NumeriPari(int n) //! usa pascal case
// n sta per il numero di elementi dell'array
{
    int[] numeriPari = new int[n]; // dichiaro un array di interi con n elementi
    for (int i = 0; i < n; i++)
    {
        numeriPari[i] = 5 * i; // assegno al i-esimo elemento dell'array il doppio do i in modo ottenere i numeri pari
    }
    return numeriPari; // restituisce l'array di numeri pari
}
int[] numeri = NumeriPari(50); // utilizzo della funzione
foreach (int numero in numeri)
{
    Console.WriteLine(numero); // stampa: 0 2 4 6 8
    // stampo con delay di un secondo
    // System.Threading.Thread.Sleep(300); // !
}


Console.Clear();

// esempio di funzione che restituisce un array di stringhe
// in questo caso viene restituito un  array contenente le parole di lunghezza pari
string[] ParolePari(string[] parole) //! usa pascal case
{
    List<string> parolePari = new List<string>(); // dichiaro una lista di stringhe
    foreach (var item in parole)   // item==parola
    {
        if (item.Length % 2 == 0) // se la lunghezza della parola e un intero pari
        {
            parolePari.Add(item); // aggiungo la parola alla lista
        }
    }
    return parolePari.ToArray(); // restituisce l'array di parole di lunghezza pari
}
string[] parole = { "cane", "gatto", "topo", "elefante", "cavallo" }; // dichiaro un array di stringhe
string[] parolePari = ParolePari(parole); // utilizzo della funzione
foreach (var item in parolePari) // item==parola
{
    Console.WriteLine(item); // stampa: cane gatto topo
}

Console.Clear();

// esempio di funzione che restituisce una lista
// in questo caso viene restituita una lista contenente la versione abbraviata di una serie di nomi

List<string> NomiAbbreviati(List<string> nomi) //! usa pascal case
{
    List<string> nomiAbbreviati = new List<string>(); // dichiaro una lista di stringhe
    foreach (var item in nomi) // item==nome
    {
        string[] parti = item.Split(' '); // divido il nome in parti separate dallo spazio
        string abbreviato = $"{parti[0]} {parti[1][0]}"; // creo una stringa con il nome abbreviato
        nomiAbbreviati.Add(abbreviato); // aggiungo la stringa alla lista
    }
    return nomiAbbreviati; // restituisce la lista di nomi abbreviati
}
List<string> nomiCompleti = new List<string> { "Tamer Yilmaz", "Mario Rossi", "Luca Bianchi", "Paolo Verdi" }; // dichiaro una lista di stringhe
List<string> nomiAbbreviati = NomiAbbreviati(nomiCompleti); // utilizzo della funzione
foreach (var item in nomiAbbreviati) // item==nome
{ 
    Console.WriteLine(item); // stampa: Tamer Y, Mario R, Luca B, Paolo V
}

Console.Clear();

// esempio di funzione che restituisce una lista
// in questo caso viene restituita una lista contenente la versione abbraviata di una serie di nomi

List<string> NomiAbbreviatiConInput(List<string> nomi, int lunghezza) //! usa pascal case
{
    List<string> nomiAbbreviati = new List<string>(); // dichiaro una lista di stringhe
    foreach (var item in nomi) // item==nome
    {
        string[] parti = item.Split(' '); // divido il nome in parti separate dallo spazio
        string abbreviato = $"{parti[0]} {parti[1].Substring(0,lunghezza)}"; // creo una stringa con il nome abbreviato
        nomiAbbreviati.Add(abbreviato); // aggiungo la stringa alla lista
    }
    return nomiAbbreviati; // restituisce la lista di nomi abbreviati
}
List<string> nomiCompletiConInput = new List<string> { "Tamer Yilmaz", "Mario Rossi", "Luca Bianchi", "Paolo Verdi" }; // dichiaro una lista di stringhe
List<string> nomiAbbreviatiConInput = NomiAbbreviatiConInput(nomiCompleti, 2); // utilizzo della funzione
foreach (var item in nomiAbbreviatiConInput) // item==nome
{ 
    Console.WriteLine(item); // stampa: Tamer Yi. Mario Ro. Luca Bi. Paolo Ve.
}

Console.Clear();

// esempio di funzione che restituisce una dizionario
// in questo caso viene restituita una dizionario contenente i valori che corrispondono ad una chiave specifica

Dictionary<string, int> ValoriSpecifici(Dictionary<string, int> dizionario, List<string> chiavi) //! usa pascal case
{
    Dictionary<string, int> valori = new Dictionary<string, int>(); // dichiaro un dizionario di stringhe
    foreach (string chiave in chiavi)
    {
        if (dizionario.ContainsKey(chiave))
        {
            valori.Add(chiave, dizionario[chiave]);
        }
    }
    return valori; // restituisce il dizionario di valori
}
Dictionary<string, int> dizionario = new Dictionary<string, int> { { "uno", 1 }, { "due", 2 }, { "tre", 3 }, { "quattro", 4 } }; // dichiaro un dizionario di stringhe
List<string> chiavi = new List<string> { "uno", "tre", "cinque", "otto" }; // dichiaro una lista di stringhe
Dictionary<string, int> valori = ValoriSpecifici(dizionario, chiavi); // utilizzo della funzione
foreach (KeyValuePair<string, int> item in valori)
{
    Console.WriteLine($"{item.Key}: {item.Value}"); // stampa: uno: 1, tre: 3
}


Console.Clear();

// esempio di funzione che trasmette un valore ad un altra funzione
// in questo caso viene restituita una valore che viene passato ad un altra funzione

int Doppio(int n) //! usa pascal case
{
    return n * 2; // restituisce il doppio di n
                // il primo return e il valore che viene passati alla funzione Quadruplo
}

int Quadruplo(int n) //! usa pascal case
{
    return Doppio(n) * 2; // restituisce il quadruplo di n
                            // utilizza n restituito da Doppio
}

int risultatoQuadruplo = Quadruplo(4); // utilizzo della funzione (2*2*2*2)
Console.WriteLine(risultatoQuadruplo); // stampa:16