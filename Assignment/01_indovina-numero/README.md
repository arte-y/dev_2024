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

- punto 1
- punto 2

__prova__

_prova_




> **Esempio di codice**

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

> Istruzioni:
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

> **Esempio di codice**
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
Assegna un punteggio all'utente in base al numero di tentativi utilizzati. Più tentativi impiega, minore sarà il punteggio.

**Istruzioni:**
> * Inizia con un punteggio massimo (ad esempio, 100 punti).
> * Ad ogni tentativo fallito, sottrai un certo numero di punti (ad esempio, 2 punti).
> * Alla fine del gioco, mostra il punteggio all'utente.

> **Esempio di codice**
```csharp
do
{
Console.Clear();

Console.WriteLine("Scegli un livelli di difficiltà");
Console.WriteLine("1. Facile (numeri da 1 a 50, 10 tentativi)");
Console.WriteLine("2. Medio(numeri da 1 a 100, 7 tentativi)");
Console.WriteLine("3. Difficile(numeri da 1 a 200, 5 tentativi)");
string utenteD = Console.ReadLine();
int utenteDif =Convert.ToInt32(utenteD);

int difficiltà=0;
int tentativo = 0;
int puntiMax=100;
switch (utenteDif)
{

    case 1:
    tentativo = 10;
    difficiltà =50;
    puntiMax = 100 / tentativo;

    break;
    case 2:
    tentativo = 7;
    difficiltà=100;
    puntiMax = 100 / tentativo;
    break; 
    case 3:
    tentativo = 5;
    difficiltà=200;
    puntiMax = 100 / tentativo;
    break;    
    default:
    Console.WriteLine("Erorre! Scegli bene belinn");
    break;
}  
    Random rnd = new Random();
    int indovinaNumero = rnd.Next(1, difficiltà);    
    int inseritoNumero = 0;
    int ciclio =0;
    // int puntiMax = 100 / tentativo;
    Console.WriteLine(indovinaNumero);
    
    while (tentativo > 0)
    {
        ciclio++;
        Console.WriteLine($"indovina un numero (tra 1 e {difficiltà}) e Hai {tentativo - 0} tentativi.");
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
                Console.WriteLine($"Tentativi finiti. Hai perso.!");
                break;
            }
            if (inseritoNumero < indovinaNumero)
            {
                Console.WriteLine("il numero è maggiore");
            }
            else
            {
                Console.WriteLine("il numero è minore");
            }
        }
    }
    Console.WriteLine("Game Over");
    Console.WriteLine("****************");

    Console.Write("Voresti continuare a giocare? (S/N):");
    string risulto = Console.ReadLine().ToLower();
    if (risulto == "s")
    {
        Console.WriteLine("Inizia a nouvo gioco");
    }
    else
    {
        Console.WriteLine("Cioa Caro/a");
        break;
    }

} while (true);

```
## Versione 5

**Obiettivo**
Livelli di Difficoltà: Permetti all'utente di scegliere tra diversi livelli di difficoltà che modificano il munero di punti sottratti o l'intervallo dei numeri o il numero di tentativi disponibili.
**Istruzioni:**
* Livelli di Difficoltà:
    * Facile: Numeri da 1 a 50, 10 tentativi.
    * Medio: Numeri da 1 a 100, 7 tentativi.
    * Difficile: Numeri da 1 a 200, 5 tentativi.
**Esempio di codice**
```csharp
do
{
Console.Clear();

Console.WriteLine("Scegli un livelli di difficiltà");
Console.WriteLine("1. Facile (numeri da 1 a 50, 10 tentativi)");
Console.WriteLine("2. Medio(numeri da 1 a 100, 7 tentativi)");
Console.WriteLine("3. Difficile(numeri da 1 a 200, 5 tentativi)");
string utenteD = Console.ReadLine();
int utenteDif =Convert.ToInt32(utenteD);

int difficiltà=0;
int tentativo = 0;
int puntiMax=100;
switch (utenteDif)
{

    case 1:
    tentativo = 10;
    difficiltà =50;
    puntiMax = 100 / tentativo;

    break;
    case 2:
    tentativo = 7;
    difficiltà=100;
    puntiMax = 100 / tentativo;
    break; 
    case 3:
    tentativo = 5;
    difficiltà=200;
    puntiMax = 100 / tentativo;
    break;    
    default:
    Console.WriteLine("Erorre! Scegli bene belinn");
    break;
}  
    Random rnd = new Random();
    int indovinaNumero = rnd.Next(1, difficiltà);    
    int inseritoNumero = 0;
    int ciclio =0;
    // int puntiMax = 100 / tentativo;
    Console.WriteLine(indovinaNumero);
    
    while (tentativo > 0)
    {
        ciclio++;
        Console.WriteLine($"indovina un numero (tra 1 e {difficiltà}) e Hai {tentativo - 0} tentativi.");
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
                Console.WriteLine($"Tentativi finiti. Hai perso.!");
                break;
            }
            if (inseritoNumero < indovinaNumero)
            {
                Console.WriteLine("il numero è maggiore");
            }
            else
            {
                Console.WriteLine("il numero è minore");
            }
        }
    }
    Console.WriteLine("Game Over");
    Console.WriteLine("****************");

    Console.Write("Voresti continuare a giocare? (S/N):");
    string risulto = Console.ReadLine().ToLower();
    if (risulto == "s")
    {
        Console.WriteLine("Inizia a nouvo gioco");
    }
    else
    {
        Console.WriteLine("Cioa Caro/a");
        break;
    }

} while (true);

```

## Versione 6

**Obiettivo**
* Storico dei Tentativi: Mostra all'utente tutti i numeri inseriti precedentemente.


**Istruzioni:**

- Utilizza una lista per memorizzare i tentativi dell'utente. I tentativi sono memorizzati fino a quando l'utente indovina il numero o esaurisce i tentativi ma vengono persi quando viene eseguito il codice successivo.



**Esempio di codice**
```csharp
do
{
    Console.Clear();
    int difficiltà = 0;
    int tentativo = 0;
    int puntiMax = 100;
    List<int> tentativiUtente = new List<int>();

    Console.WriteLine("Scegli un livelli di difficiltà");
    Console.WriteLine("1. Facile (numeri da 1 a 50, 10 tentativi)");
    Console.WriteLine("2. Medio(numeri da 1 a 100, 7 tentativi)");
    Console.WriteLine("3. Difficile(numeri da 1 a 200, 5 tentativi)");
    string utenteD = Console.ReadLine();
    int utenteS = Convert.ToInt32(utenteD);



    switch (utenteS)
    {

        case 1:
            tentativo = 10;
            difficiltà = 50;
            puntiMax = 100 / tentativo;

            break;
        case 2:
            tentativo = 7;
            difficiltà = 100;
            puntiMax = 100 / tentativo;
            break;
        case 3:
            tentativo = 5;
            difficiltà = 200;
            puntiMax = 100 / tentativo;
            break;
        default:
            Console.WriteLine("Erorre! Scegli bene belinn");
            break;
    }
    Random rnd = new Random();
    int indovinaNumero = rnd.Next(1, difficiltà);
    int inseritoNumero = 0;
    int ciclio = 0;
    // int puntiMax = 100 / tentativo;
    Console.WriteLine(indovinaNumero);


    while (tentativo > 0)
    {
        ciclio++;
        Console.WriteLine($"indovina un numero (tra 1 e {difficiltà}) e Hai {tentativo - 0} tentativi.");
        inseritoNumero = int.Parse(Console.ReadLine());
        tentativo--;
        tentativiUtente.Add(inseritoNumero);


        if (inseritoNumero == indovinaNumero)
        {
            int punti = 100 - (puntiMax * (ciclio - 1));
            Console.WriteLine($"Complimenti! Hai indovinato il numero {indovinaNumero} e punti {punti}");
            break;
        }
        else
        {
            if (tentativo == 0)
            {
                Console.WriteLine($"Tentativi finiti. Hai perso.!");
                break;
            }
            if (inseritoNumero < indovinaNumero)
            {
                Console.WriteLine("il numero è maggiore");
            }
            else
            {
                Console.WriteLine("il numero è minore");
            }
        }

    }
    foreach (var item in tentativiUtente)
    {
        Console.WriteLine($"Hai provato il numero; {item}");
    }
    Console.WriteLine("Game Over");
    Console.WriteLine("****************");

    Console.Write("Voresti continuare a giocare? (S/N):");
    string risulto = Console.ReadLine().ToLower();
    if (risulto == "s")
    {
        Console.WriteLine("Inizia a nouvo gioco");
    }
    else
    {
        Console.WriteLine("Cioa Caro/a");
        break;
    }

} while (true);
```

### Comandi versionamento
git add --all
git commit -m "Indovina Numero: Versione 6"
git push -u origin main


## Versione 7

**Obiettivo**
* Validazione degli input: Aggiungi controlli per assicurarti che l'utente inserisca un numero valido.


**Istruzioni:**

- Utilizza il metodo int.TryParse per convertire l'input dell'utente in un numero intero.

-Il TryParse funziona cosi:

**Esempio di codice**
```csharp
do
{
    Console.Clear();

    int difficiltà = 0;
    int tentativo = 0;
    int puntiMax = 100;
    List<int> tentativiUtente = new List<int>(); // per memorizzia i numeri (girilen sayilar icin liste yapildi!)

    Console.WriteLine("Scegli un livelli di difficiltà");
    Console.WriteLine("1. Facile (numeri da 1 a 50, 10 tentativi)");
    Console.WriteLine("2. Medio(numeri da 1 a 100, 7 tentativi)");
    Console.WriteLine("3. Difficile(numeri da 1 a 200, 5 tentativi)");
    //string utenteD = Console.ReadLine();
    //int utenteS = Convert.ToInt32(utenteD);
    int utenteS = 0;

    bool successo1 = int.TryParse(Console.ReadLine(), out utenteS);
    if (!successo1 || utenteS < 1 || utenteS > 3)
    {
        Console.WriteLine("Inserisci un numero valido!");
        continue;
    }

    switch (utenteS)
    {
        case 1:
            tentativo = 10;
            difficiltà = 50;
            puntiMax = 100 / tentativo;

            break;
        case 2:
            tentativo = 7;
            difficiltà = 100;
            puntiMax = 100 / tentativo;
            break;
        case 3:
            tentativo = 5;
            difficiltà = 200;
            puntiMax = 100 / tentativo;
            break;
        default:
            Console.WriteLine("Erorre! Scegli bene belinn");
            break;
    }
    Random rnd = new Random();
    int indovinaNumero = rnd.Next(1, difficiltà);

    int ciclio = 0;
    // int puntiMax = 100 / tentativo;
    Console.WriteLine(indovinaNumero);


    while (tentativo > 0)
    {
        ciclio++;
        int inseritoNumero = 0;
        Console.WriteLine($"indovina un numero (tra 1 e {difficiltà}) e Hai {tentativo - 0} tentativi.");
        //inseritoNumero = int.Parse(Console.ReadLine());
        bool successo = int.TryParse(Console.ReadLine(), out inseritoNumero);
        if (!successo || inseritoNumero > difficiltà)
        {
            Console.WriteLine("Inserisci un numero valido!");
            continue;
        }
        tentativo--;
        tentativiUtente.Add(inseritoNumero); // add liste ciclio! (girilen sayilari listeye ekler ve asagida yazdiririz)

        if (inseritoNumero == indovinaNumero)
        {
            int punti = 100 - (puntiMax * (ciclio - 1));
            Console.WriteLine($"Complimenti! Hai indovinato il numero {indovinaNumero} e punti {punti}");
            break;
        }
        else
        {
            if (tentativo == 0)
            {
                Console.WriteLine($"Tentativi finiti. Hai perso.!");
                break;
            }
            if (inseritoNumero < indovinaNumero)
            {
                Console.WriteLine("il numero è maggiore");
            }
            else
            {
                Console.WriteLine("il numero è minore");
            }
        }

    }
    Console.WriteLine($"Hai provato il numero; ");
    foreach (var item in tentativiUtente) // per memorizzia - crea una list e poi fai una display con foreach!
    {
        Console.Write($"- {item} ");
    }

    Console.WriteLine(" \nGame Over");
    Console.WriteLine("****************");

    Console.Write("Voresti continuare a giocare? (S/N):");
    string risulto = Console.ReadLine().ToLower();
    if (risulto == "s")
    {
        Console.WriteLine("Inizia a nouvo gioco");
    }
    else
    {
        Console.WriteLine("Cioa Caro/a");
        break;
    }

} while (true);
```
### Comandi versionamento
```bash
git add --all
git commit -m "Indovina Numero: Versione 7"
git push -u origin main
```




## Versione 8

**Obiettivo**
* Ripetizione del Livello: Chiedi all'utente di inserire il livello di difficoltà finché non sceglie un livello valido.

**Istruzioni:**
Se vogliamo che chieda di nuovo il livello di difficoltà quando la scelta non è valida dobbiamo mettere tutto il codice precedente in un ciclo do-while e fare in modo che il ciclo si ripeta finché la scelta non è valida

Con un semplice while non possiamo fare in modo che il ciclo si ripeta finché la scelta non è valida, perché il ciclo while si ripete finché la condizione è vera, ma non possiamo sapere se la scelta è valida o meno finché non la controlliamo.

Quindi dobbiamo usare un ciclo do-while, che esegue il blocco di codice almeno una volta e poi si ripete finché la condizione è vera.


**Esempio di codice**
```csharp
do
{
    Console.Clear();

    int difficiltà = 0;
    int tentativo = 0;
    int puntiMax = 100;
    List<int> tentativiUtente = new List<int>(); // per memorizzia i numeri (girilen sayilar icin liste yapildi!)

    Console.WriteLine("Scegli un livelli di difficiltà");
    Console.WriteLine("1. Facile (numeri da 1 a 50, 10 tentativi)");
    Console.WriteLine("2. Medio(numeri da 1 a 100, 7 tentativi)");
    Console.WriteLine("3. Difficile(numeri da 1 a 200, 5 tentativi)");
    //string utenteD = Console.ReadLine();
    //int utenteS = Convert.ToInt32(utenteD);
    int utenteS = 0;

    bool successo1 = int.TryParse(Console.ReadLine(), out utenteS);
    if (!successo1 || utenteS < 1 || utenteS > 3)
    {
        Console.WriteLine("Inserisci un numero valido!");
        continue;
    }

    switch (utenteS)
    {
        case 1:
            tentativo = 10;
            difficiltà = 50;
            puntiMax = 100 / tentativo;

            break;
        case 2:
            tentativo = 7;
            difficiltà = 100;
            puntiMax = 100 / tentativo;
            break;
        case 3:
            tentativo = 5;
            difficiltà = 200;
            puntiMax = 100 / tentativo;
            break;
        default:
            Console.WriteLine("Erorre! Scegli bene belinn");
            break;
    }
    Random rnd = new Random();
    int indovinaNumero = rnd.Next(1, difficiltà);

    int ciclio = 0;
    // int puntiMax = 100 / tentativo;
    Console.WriteLine(indovinaNumero);


    while (tentativo > 0)
    {
        ciclio++;
        int inseritoNumero = 0;
        Console.WriteLine($"indovina un numero (tra 1 e {difficiltà}) e Hai {tentativo - 0} tentativi.");
        //inseritoNumero = int.Parse(Console.ReadLine());
        bool successo = int.TryParse(Console.ReadLine(), out inseritoNumero);
        if (!successo || inseritoNumero > difficiltà)
        {
            Console.WriteLine("Inserisci un numero valido!");
            continue;
        }
        tentativo--;
        tentativiUtente.Add(inseritoNumero); // add liste ciclio! (girilen sayilari listeye ekler ve asagida yazdiririz)

        if (inseritoNumero == indovinaNumero)
        {
            int punti = 100 - (puntiMax * (ciclio - 1));
            Console.WriteLine($"Complimenti! Hai indovinato il numero {indovinaNumero} e punti {punti}");
            break;
        }
        else
        {
            if (tentativo == 0)
            {
                Console.WriteLine($"Tentativi finiti. Hai perso.!");
                break;
            }
            if (inseritoNumero < indovinaNumero)
            {
                Console.WriteLine("il numero è maggiore");
            }
            else
            {
                Console.WriteLine("il numero è minore");
            }
        }

    }
    Console.WriteLine($"Hai provato il numero; ");
    foreach (var item in tentativiUtente) // per memorizzia - crea una list e poi fai una display con foreach!
    {
        Console.Write($"- {item} ");
    }

    Console.WriteLine(" \nGame Over");
    Console.WriteLine("****************");

    Console.Write("Voresti continuare a giocare? (S/N):");
    string risulto = Console.ReadLine().ToLower();
    if (risulto == "s")
    {
        Console.WriteLine("Inizia a nouvo gioco");
    }
    else
    {
        Console.WriteLine("Cioa Caro/a");
        break;
    }

} while (true);
```
### Comandi versionamento
```bash
git add --all
git commit -m "Indovina Numero: Versione 8"
git push -u origin main
```

## Versione 9

**Obiettivo**
Pulizia console Usa Console.Clear() per pulire la console tra un gioco e l'altro e tra un tentativo e l altro per rendere il gioco più pulito.

**Istruzioni:**
- Aggiungi Console.Clear() all inizio del gioco per pulire la console prima di iniziare.
- Aggiungi Console.Clear() alla fine del ciclo di gioco per pulire la console tra un gioco e l'altro.
- Aggiungi Console.Clear() dopo ogni tentativo per pulire la console tra un tentativo e l'altro.

**Esempio di codice**
```csharp
do
{
    Console.Clear();

    int difficiltà = 0;
    int tentativo = 0;
    int puntiMax = 100;
    List<int> tentativiUtente = new List<int>(); // per memorizzia i numeri (girilen sayilar icin liste yapildi!)

    Console.WriteLine("Scegli un livelli di difficiltà");
    Console.WriteLine("1. Facile (numeri da 1 a 50, 10 tentativi)");
    Console.WriteLine("2. Medio(numeri da 1 a 100, 7 tentativi)");
    Console.WriteLine("3. Difficile(numeri da 1 a 200, 5 tentativi)");
    //string utenteD = Console.ReadLine();
    //int utenteS = Convert.ToInt32(utenteD);
    int utenteS = 0;

    bool successo1 = int.TryParse(Console.ReadLine(), out utenteS);
    if (!successo1 || utenteS < 1 || utenteS > 3)
    {
        Console.WriteLine("Inserisci un numero valido!");
        continue;
    }

    switch (utenteS)
    {
        case 1:
            tentativo = 10;
            difficiltà = 50;
            puntiMax = 100 / tentativo;

            break;
        case 2:
            tentativo = 7;
            difficiltà = 100;
            puntiMax = 100 / tentativo;
            break;
        case 3:
            tentativo = 5;
            difficiltà = 200;
            puntiMax = 100 / tentativo;
            break;
        default:
            Console.WriteLine("Erorre! Scegli bene belinn");
            break;
    }
    Random rnd = new Random();
    int indovinaNumero = rnd.Next(1, difficiltà);

    int ciclio = 0;
    // int puntiMax = 100 / tentativo;
    Console.WriteLine(indovinaNumero);


    while (tentativo > 0)
    {
        ciclio++;
        int inseritoNumero = 0;
        Console.WriteLine($"indovina un numero (tra 1 e {difficiltà}) e Hai {tentativo - 0} tentativi.");
        //inseritoNumero = int.Parse(Console.ReadLine());
        bool successo = int.TryParse(Console.ReadLine(), out inseritoNumero);
        if (!successo || inseritoNumero > difficiltà)
        {
            Console.WriteLine("Inserisci un numero valido!");
            continue;
        }
        tentativo--;
        tentativiUtente.Add(inseritoNumero); // add liste ciclio! (girilen sayilari listeye ekler ve asagida yazdiririz)

        if (inseritoNumero == indovinaNumero)
        {
            int punti = 100 - (puntiMax * (ciclio - 1));
            Console.WriteLine($"Complimenti! Hai indovinato il numero {indovinaNumero} e punti {punti}");
            break;
        }
        else
        {
            if (tentativo == 0)
            {
                Console.WriteLine($"Tentativi finiti. Hai perso.!");
                break;
            }
            if (inseritoNumero < indovinaNumero)
            {
                Console.WriteLine("il numero è maggiore");
            }
            else
            {
                Console.WriteLine("il numero è minore");
            }
        }

    }
    Console.WriteLine($"Hai provato il numero; ");
    foreach (var item in tentativiUtente) // per memorizzia - crea una list e poi fai una display con foreach!
    {
        Console.Write($"- {item} ");
    }

    Console.WriteLine(" \nGame Over");
    Console.WriteLine("****************");

    Console.Write("Voresti continuare a giocare? (S/N):");
    string risulto = Console.ReadLine().ToLower();
    if (risulto == "s")
    {
        Console.WriteLine("Inizia a nouvo gioco");
    }
    else
    {
        Console.WriteLine("Cioa Caro/a");
        break;
    }

} while (true);
```
### Comandi versionamento
```bash
git add --all
git commit -m "Indovina Numero: Versione 9"
git push -u origin main
```
## Versione 11

**Obiettivo**
** implementazione dizionario **
usa un dizionario per momerizzare i punteggi degli utenti insiemem al numero del tentativo


**Istruzioni:**
- crea un dizionario per memorizzare i punteggi degli utenti insiemem al numero del tentativo in cui hanno indovinato il numero-
- aggiungi il punteggio e il numero del tantativo al dizionario
- alla fine del gioco, stampa i punteggi degli utenti insieme al umero del tentativo un cui hanno indovinato il numero
- cancello i punteggi degli utenti alla fine gi ogni partita

**Esempio di codice**
```csharp
Console.Clear();
Random random = new Random();
int numeroDaIndovinare = 0;
int punteggio = 0;
bool haIndovinato = false;
int tentativi = 0;
int numeroUtente = 0;

Dictionary<string, List<int>> tentativiUtenti = new Dictionary<string, List<int>>(); // creo un dizionario per memorizzare i tentativi degli utenti

string risposta = "s";

do
{
    int scelta = 0;

    do
    {
        Console.WriteLine("Scegli il livello di difficolta':");
        Console.WriteLine("1. Facile (1-50, 10 tentativi)");
        Console.WriteLine("2. Medio (1-100, 7 tentativi)");
        Console.WriteLine("3. Difficile (1-200, 5 tentativi)");

        bool successoLivelloDifficolta = int.TryParse(Console.ReadLine(), out scelta);
        // pulisco la console
        Console.Clear();
        if (!successoLivelloDifficolta || scelta < 1 || scelta > 3)
        {
            Console.WriteLine("Scelta non valida.");
        }
    } while (scelta < 1 || scelta > 3);

    switch (scelta)
    {
        case 1:
            numeroDaIndovinare = random.Next(1, 51);
            punteggio = 100;
            tentativi = 10;
            break;
        case 2:
            numeroDaIndovinare = random.Next(1, 101);
            punteggio = 200;
            tentativi = 7;
            break;
        case 3:
            numeroDaIndovinare = random.Next(1, 201);
            punteggio = 300;
            tentativi = 5;
            break;
        default:
            Console.WriteLine("Scelta non valida.");
            break;
    }

    Console.WriteLine("Inserisci il tuo nome:");
    string nomeUtente = Console.ReadLine();

    Console.WriteLine("Indovina il numero. Punteggio massimo: 100 punti.");

    while (!haIndovinato && tentativi > 0)
    {
        Console.Write("Tentativo: ");
        bool successo = int.TryParse(Console.ReadLine(), out numeroUtente);
        // pulisco la console
        Console.Clear();

        if (!successo)
        {
            Console.WriteLine("Inserisci un numero valido.");
            continue;
        }

        tentativi--;
        // aggiungo il tentativo alla lista del nomeUtente
        if (!tentativiUtenti.ContainsKey(nomeUtente))
        {
            tentativiUtenti.Add(nomeUtente, new List<int>());
        }

        tentativiUtenti[nomeUtente].Add(numeroUtente); // aggiungo il tentativo alla lista del nomeUtente uso [nomeUtente] per accedere alla lista del nomeUtente

        if (numeroUtente < numeroDaIndovinare)
        {
            Console.WriteLine("Il numero da indovinare e' maggiore.");
        }
        else if (numeroUtente > numeroDaIndovinare)
        {
            Console.WriteLine("Il numero da indovinare e' minore.");
        }
        else
        {
            Console.WriteLine($"Hai indovinato! Punteggio: {punteggio}");
            haIndovinato = true;
        }

        if (!haIndovinato && tentativi == 0)
        {
            Console.WriteLine($"Hai esaurito i tentativi. Il numero era {numeroDaIndovinare}.");
        }

    }

    if (haIndovinato)
    {
        // stampa il punteggio dell utente
        Console.WriteLine($"Punteggio: {punteggio}");
    }

    Console.WriteLine("Tentativi effettuati: ");

    foreach (var tentativoUtente in tentativiUtenti)
    {
        Console.WriteLine($"{tentativoUtente.Key}: {string.Join(", ", tentativoUtente.Value)}"); // stampo i tentativi degli utenti
    }

    Console.WriteLine("Vuoi giocare di nuovo? (s/n)");

    risposta = Console.ReadLine();

    Console.Clear();

    while (risposta != "s" && risposta != "S" && risposta != "n" && risposta != "N")
    {
        Console.WriteLine("Risposta non valida. Vuoi giocare di nuovo? (s/n)");
        risposta = Console.ReadLine();
        Console.Clear();
    }

    haIndovinato = false;

    // tentativiUtenti.Clear(); // cancello i tentativi degli utenti

} while (risposta == "s" || risposta == "S");
```
## Grafici Mermaid

https://mermaid.js.org/

https://jojozhuang.github.io/tutorial/mermaid-cheat-sheet/

## flowchart basic Indivina Numero

``` mermaid
graph TD
    Start --> SelectDifficulty
    SelectDifficulty --> EnterName
    EnterName --> InputNum
    InputNum --> CheckNum
    CheckNum -- "Yes" --> Win
    CheckNum -- "No, too low" --> TooLow
    CheckNum -- "No, too high" --> TooHigh
    TooLow --> AttemptsLeft
    TooHigh --> AttemptsLeft
    AttemptsLeft --> |"If attempts left"| InputNum
    AttemptsLeft --> |"If no attempts left"| ShowAttempts
    Win --> Score
    Score --> ShowAttempts
    ShowAttempts --> PlayAgain
    PlayAgain -- "Yes" --> Start
    PlayAgain -- "No" --> End
```
