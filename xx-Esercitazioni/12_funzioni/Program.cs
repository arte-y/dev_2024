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

