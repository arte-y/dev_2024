# Indovina Numero

## Obiettivo

L'obiettivo di questa applicazione e di indovinare un **numero casuale** generato dal computer.

> Passaggi:
1. Il computer genera un numero casuale tra 1 e 100.
2. L'utente inserisce un numero.
3. Il computer confronta il numero inserito con quello generato.



**Esempio di codice**

## Versione 1
Random random = new Random();

int numeroDaIndovinare = random.Next(1, 101);

Console.WriteLine(numeroDaIndovinare);

Console.WriteLine("Indovina il numero (tra 1 e 100): ");

int numeroInserito;

numeroInserito = Convert.ToInt32(Console.ReadLine()); 

if (numeroInserito == numeroDaIndovinare)
{
    Console.WriteLine("Complimenti! Hai indovinato il numero.");
}
else
{
    Console.WriteLine("Mi dispiace! Non hai indovinato il numero.");
    Console.WriteLine($"Il numero da indovinare era: {numeroDaIndovinare}");
}

```csharp
