# Indovina Numero

## Obiettivo

L'obiettivo di questa applicazione e di indovinare un **numero casuale** generato dal computer.

> Passaggi:
1. Il computer genera un numero casuale tra 1 e 100.
2. L'utente inserisce un numero.
3. Il computer confronta il numero inserito con quello generato.
4. Se il numero inserito è uguale a quello generato, l'utente ha indovinato.
5. Altrimenti, il computer fornisce un suggerimento (maggiore o minore) e l'utente può inserire un nuovo numero.
6. Il gioco termina quando l'utente indovina il numero o quando raggiunge il numero massimo di tentativi.


**Esempio di codice**

## Versione 1

```csharp
Random random = new Random(); // Random e la classe che genera numeri casuali

int numeroDaIndovinare = random.Next(1, 101); // Next e il metodo che genera un numero casuale tra 1 e 100

Console.WriteLine("Indovina il numero (tra 1 e 100): ");


int numeroInserito;

numeroInserito = Convert.ToInt32(Console.ReadLine()); // converto il valore inserito dall'utente in un intero perche Console.ReadLine restituisce una stringa

if (numeroInserito == numeroDaIndovinare)
{
    // se il numero inserito e uguale al numero da indovinare stampo il messaggio di congratulazioni
    Console.WriteLine("Complimenti! Hai indovinato il numero.");
}
else
{
    // se il numero inserito non e uguale al numero da indovinare stampo il messaggio di errore
    Console.WriteLine("Mi dispiace! Non hai indovinato il numero.");
    // stampo il numero da indovinare
    Console.WriteLine($"Il numero da indovinare era: {numeroDaIndovinare}");
}

```

### Comandi versionamento
```bash
git add --all
git commit -m "version2"
git push -u origin main
```
## Versione 2

**Obiettivo**
Modifica il programma precedente per fornire all'utente suggerimenti dopo ogni tentativo, indicando se il numero da indovinare è maggiore o minore di quello inserito.

 Istruzioni:
1. Usa un ciclo while per permettere all'utente di continuare a tentare finché non indovina.
2. Dopo ogni tentativo errato, indica se il numero da indovinare è maggiore o minore di quello inserito.
3. Quando l'utente indovina, esci dal ciclo e stampa un messaggio di congratulazioni.

## Versione 2
```csharp
Random random = new Random(); // Random e la classe che genera numeri casuali
int numeroDaIndovinare = random.Next(1, 101); // Next e il metodo che genera un numero casuale tra 1 e 100

Console.Clear();

Console.WriteLine("Indovina il numero (tra 1 e 100): ");

int numeroInserito;

numeroInserito = 0; // Inizializzo a 0 per entrare nel ciclo while

while (numeroInserito != numeroDaIndovinare)
{
    numeroInserito = Convert.ToInt32(Console.ReadLine());
    
    if (numeroInserito < numeroDaIndovinare)
    {
        Console.WriteLine("Il numero da indovinare e' maggiore");
    }
    else
    {
        Console.WriteLine("Il numero da indovinare e' minore");
    }

    Console.WriteLine("Riprova: ");
    
}

Console.WriteLine("Hai indovinato! Il numero da indovinare era: " + numeroDaIndovinare);
```