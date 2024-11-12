### Calcolatrice con funzioni

# Calcolatrice semplice

## Versione 1

## Obiettivo

- implementare le funzioni nella versione semplificata della calcolatrice.

```csharp
double num1 = 0;
double num2 = 0;
bool inputValido = false;


Console.Write("Insercie il nome:");
string nome = Console.ReadLine();

Console.Write("Insercie il cognome:");
string cognome = Console.ReadLine();

NomeCognome(nome, cognome);


while (!inputValido)
{
    try
    {
        Console.WriteLine("Inserisci il primo numero: ");
        num1 = Convert.ToDouble(Console.ReadLine());
        inputValido = true;

    }
    catch (FormatException)
    {
        Console.WriteLine("Inserice un numero valido:");
    }
}
// up:
inputValido = false;
while (!inputValido)
{
    try
    {

        Console.WriteLine("Inserisci il secondo numero: ");
        num2 = Convert.ToDouble(Console.ReadLine());
        inputValido = true;
    }
    catch (FormatException)
    {
        Console.WriteLine("Inserice un numero valido:");
    }
}

do
{
    try
    {


        Console.WriteLine("Inserisci l'operazione (+, -, *, /): ");
        // string operazione = Console.ReadLine();
        char operazione = Console.ReadKey().KeyChar; //! porf. suggest!
        Console.WriteLine();

        inputValido = true;
        if (operazione == '+')
        {
            SommaPiu(num1, num2, operazione.ToString());
        }
        else if (operazione == '-')
        {
            SommaMeno(num1, num2, operazione.ToString());
            
        }
        else if (operazione == '*')
        {
            SommaPer(num1, num2, operazione.ToString());
        }
        else if (operazione == '/')
        {
            if (num2 == 0)
            {
                throw new DivideByZeroException();
                // goto up;

            }
            SommaDiv(num1, num2, operazione.ToString());
        }
        else
        {
            Console.WriteLine("Operazione non valida. Deve essere (+, -, *, /)");
            inputValido = false;
        }

    }
    catch (DivideByZeroException)
    {
        Console.WriteLine("Non puoi dividere per zero");
        inputValido = false;
    }
} while (!inputValido);




void NomeCognome(string nome, string cognome)
{
    Console.WriteLine($"Ciao {nome} {cognome}");
}


double SommaPiu(double a, double b, string operazione)
{
    double risultato = a + b;
    Console.WriteLine($"Il risultato è: {num1} {operazione} {num2} = {risultato}");

    return a + b;
}

double SommaMeno(double a, double b, string operazione)
{
    double risultato = a - b;
    Console.WriteLine($"Il risultato è: {num1} {operazione} {num2} = {risultato}");
    return a - b;
}

double SommaPer(double a, double b, string operazione)
{
    double risultato = a * b;
    Console.WriteLine($"Il risultato è: {num1} {operazione} {num2} = {risultato}");
    return a * b;
}
double SommaDiv(double a, double b, string operazione)
{
    double risultato = a / b;
    Console.WriteLine($"Il risultato è: {num1} {operazione} {num2} = {risultato}");
    return a / b;}  
```

```bash
git add --all
git mìcommit -m "Implementata la versione 1 della calcolatrice con funzioni"
git push -u origin main
```
