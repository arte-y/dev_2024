# Calcolatrice semplice

## Versione 1

## Obiettivo

- Scrivere un programma che simuli una calcolatrice semplice.
- l'utente deve poter inserice due numeri e selezionare un operatore matematico (+,-+,/)
- Il programma deve sesguire lìoperazione selezionata e stampare il risultato.
- Il pogramma non gestisce nessun tipo di errore o di eccezione

```csharp
// chiedi all'utente di inserisce due numeri

// chiedi all'utente di selezionare un operatore matematico

// esegui l'operazione selezionata

// stampa il risultato
Console.WriteLine("Inserisci il primo numero: ");
long num1 = long.Parse(Console.ReadLine());

Console.WriteLine("Inserisci il secondo numero: ");
long num2 = long.Parse(Console.ReadLine());

Console.WriteLine("Inserisci l'operazione (+, -, *, /): ");
// string operazione = Console.ReadLine();
char operazione = Console.ReadKey().KeyChar; // porf. suggest!
Console.WriteLine();

if (operazione =='+')
{
    long risultato = num1 + num2;
    Console.WriteLine($"Il risultato è: {num1} {operazione} {num2} = {risultato}");
}
else if (operazione == '-')
{
    long risultato2 = num1 - num2;
    Console.WriteLine($"Il risultato è: {num1} {operazione} {num2} = {risultato2}");
}
else if (operazione == '*')
{
    long risultato3 = num1 * num2;   
    Console.WriteLine($"Il risultato è: {num1} {operazione} {num2} = {risultato3}");
}
else if (operazione == '/')
{
    long risultato4 = num1 / num2;
    Console.WriteLine($"Il risultato è: {num1} {operazione} {num2}  {risultato4}");
}
else
{
    Console.WriteLine("Operazione non valida");
}

```

```bash
git add --all
git mìcommit -m "calcolatrice_semplice_Versione_1"
git push -u origin main

```

# Versione 2

## Obiettivo

- Aggiungere la gestione degli errori per evitare crash del programma.
- Se l'utente inserice un valore non numerico, il programma deve stampare un messaggio di errore dicendo di inserice un numero valido
- Se l'utente inserice un valore non numerico, il programma deve stampare un messaggio di errore dicendo di selezionare un operatore valido
- Se l'utente tenta di dividere per zero, il programma deve stampare un messaggio di errore dicendo che la divisione per zero non è consentita
- Il programma deve usare i blocchi try-catch per gestire gli errori
- num* era(long) --- now(double ---- Convert.ToDouble...)

```csharp

```

```bash
git add --all
git commit -m "calcolatrice_semplice_Versione2"
git push -u origin main
```