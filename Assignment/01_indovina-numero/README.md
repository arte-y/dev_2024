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

## Versione 3

**Obiettivo**
Imposta un numero masssi di tentativi (ad esempio, 5). Se l'utente non indivina entro questi tentativi, ilgiovo termina.
**Istruzioni:**
* Imposta una variabile booleana per tenere traccia se l'utente ha indovinato.
* Mantieni un cantatore di tentativi all'interno del ciclo while.
* Dopo ogni tentativo, decrementa il numero di tentativi rimasti e informane l'utente
* Se i tentativi esauriscono senza che l'utente abbia indovinato, stampa un messaggio du sconfitta e rivela il numero.

**Esempio di codice**
```csharp
Random random = new Random(); // Random e la classe che genera numeri casuali
int numeroDaIndovinare = random.Next(1, 101); // Next e il metodo che genera un numero casuale tra 1 e 100
int numeroInserito;
int tentativiMassimi = 5;  
int tentativiEffettuati = 0;  
bool haIndovinato = false;
int numeroUtente = 0;

Console.Clear();

Console.WriteLine("Indovina il numero (tra 1 e 100). Hai 5 tentativi.");

while (tentativiEffettuati < tentativiMassimi && !haIndovinato)  
{  
    Console.Write("Tentativo {0}: ", tentativiEffettuati + 1);  
    
    // numeroUtente = int.Parse(Console.ReadLine());  
    numeroUtente = int.Parse(Console.ReadLine());
    
    tentativiEffettuati++;

    if (numeroUtente < numeroDaIndovinare)  
    {  
        Console.WriteLine("Il numero da indovinare è maggiore.");  
    }  
    else if (numeroUtente > numeroDaIndovinare)  
    {  
        Console.WriteLine("Il numero da indovinare è minore.");  
    }  
    else  
    {  
        Console.WriteLine("Complimenti! Hai indovinato il numero.");  
        haIndovinato = true;  
    }

    if (!haIndovinato && tentativiEffettuati == tentativiMassimi)  
    {  
        Console.WriteLine("Hai esaurito i tentativi. Il numero era " + numeroDaIndovinare + ".");  
    }  
}
```

## Versione 4

**Obiettivo**
Imposta un numero masssi di tentativi (ad esempio, 5). Se l'utente non indivina entro questi tentativi, ilgiovo termina.
**Istruzioni:**
* Iniziz con puntteggio massimo

**Esempio di codice**
```csharp
do
{
    Random rnd = new Random();
    int indovinaNumero = rnd.Next(1, 100);

    int inseritoNumero = 0;
    int tentativo = 5;
    
    int puntiMax = 100 / tentativo;
    int ciclio =0;

    Console.WriteLine(indovinaNumero);

    while (tentativo > 0)
    {
        ciclio++;
        Console.WriteLine($"indovina un numero (tra 1 e 100) e Hai {tentativo - 0} tentativi.");
        inseritoNumero = int.Parse(Console.ReadLine());
        tentativo--;

        if (inseritoNumero == indovinaNumero)
        {
            int punti = 100 - (puntiMax * (ciclio -1));
            Console.WriteLine($"Complimenti! Hai indovinato il numero {indovinaNumero} e punti {punti}");
            break;
        }
        else
        {
            if (tentativo == 0)
            {
                Console.WriteLine($"finito tentativo");
                break;
            }
            if (inseritoNumero < indovinaNumero)
            {
                Console.WriteLine("maggiore");
            }
            else
            {
                Console.WriteLine("minore");
            }
        }
    }
    Console.WriteLine("Game Over");
    Console.WriteLine("****************");

    Console.Write("vuole continuare a giocare? (S/N):");
    string risulto = Console.ReadLine().ToLower();
    if (risulto == "s")
    {
        Console.WriteLine("inizia a nouvo gioco");
    }
    else
    {
        Console.WriteLine("Cioa Caro/a");
        break;
    }

} while (true);
```