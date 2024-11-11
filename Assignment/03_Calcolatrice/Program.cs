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


bool inputValido = false;


try
{
    Console.WriteLine("Calcolatrice");
    Console.WriteLine("Inserisci il primo numero: ");
    double num1 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Inserisci il secondo numero: ");
    double num2 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Inserisci l'operazione (+, -, *, /): ");
    // string operazione = Console.ReadLine();
    char operazione = Console.ReadKey().KeyChar; //! porf. suggest!
    Console.WriteLine();

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
        double risultato4 = num1 / num2;
        Console.WriteLine($"Il risultato è: {num1} {operazione} {num2}  {risultato4}");
    }
    else
    {
        Console.WriteLine("Operazione non valida. Deve essere (+, -, *, /)");
    }
}
catch (FormatException)
{
    Console.WriteLine("Errore: Inserire un numero valido");
}
catch (DivideByZeroException)
{
    Console.WriteLine("Errore: Divisione per zero");
}
catch (OverflowException)
{
    Console.WriteLine("Errore: Numero troppo grande");
}
catch (Exception)
{
    Console.WriteLine("Errore generico");
}
// finally
// {
//     Console.WriteLine("il blocco finally");
// }


#endregion