#region  versione 1

// Console.WriteLine("Inserisci il primo numero: ");
// long num1 = long.Parse(Console.ReadLine());

// Console.WriteLine("Inserisci il secondo numero: ");
// long num2 = long.Parse(Console.ReadLine());

// Console.WriteLine("Inserisci l'operazione (+, -, *, /): ");
// // string operazione = Console.ReadLine();
// char operazione = Console.ReadKey().KeyChar; // porf. suggest!
// Console.WriteLine();

// if (operazione =='+')
// {
//     long risultato = num1 + num2;
//     Console.WriteLine($"Il risultato è: {num1} {operazione} {num2} = {risultato}");
// }
// else if (operazione == '-')
// {
//     long risultato2 = num1 - num2;
//     Console.WriteLine($"Il risultato è: {num1} {operazione} {num2} = {risultato2}");
// }
// else if (operazione == '*')
// {
//     long risultato3 = num1 * num2;   
//     Console.WriteLine($"Il risultato è: {num1} {operazione} {num2} = {risultato3}");
// }
// else if (operazione == '/')
// {
//     long risultato4 = num1 / num2;
//     Console.WriteLine($"Il risultato è: {num1} {operazione} {num2}  {risultato4}");
// }
// else
// {
//     Console.WriteLine("Operazione non valida");
// }
#endregion

#region Versione 2


using System.Data;

double num1 = 0;
double num2 = 0;
bool inputValido = false;


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
            double risultato = num1 + num2;
            Console.WriteLine($"Il risultato è: {num1} {operazione} {num2} = {risultato}");
        }
        else if (operazione == '-')
        {
            double risultato2 = num1 - num2;
            Console.WriteLine($"Il risultato è: {num1} {operazione} {num2} = {risultato2}");
        }
        else if (operazione == '*')
        {
            double risultato3 = num1 * num2;
            Console.WriteLine($"Il risultato è: {num1} {operazione} {num2} = {risultato3}");
        }
        else if (operazione == '/')
        {
            if (num2 == 0)
            {
                throw new DivideByZeroException();
                // goto up;

            }
            double risultato4 = num1 / num2;
            Console.WriteLine($"Il risultato è: {num1} {operazione} {num2} = {risultato4}");
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

// finally
// {
//     Console.WriteLine("il blocco finally");
// }
#endregion

#region Versione 3


#endregion

