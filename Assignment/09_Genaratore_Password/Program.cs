// Generatore di Password

//! un altro modo

// Random random = new Random();
// string password1 = string.Empty;

// int lunghezza1 = random.Next(8, 20);

// for (int i = 0; i < lunghezza1; i++)
// {
//   char p1 = (char)random.Next(33, 127);
//   password1 += p1;
// }
// Console.WriteLine($"Computer ha creato un password:{password1}");

//! prima

// Random rnd = new Random();
// string password = string.Empty;

// Console.WriteLine("Per creare un password deve inserire:");

// Console.Write("Metti una lettera maiuscola: ");
// char letteraMaiuscola = Console.ReadLine().ToUpper()[0];
// password += letteraMaiuscola;

// Console.Write("Metti una lettera minuscola: ");
// char letteraMinuscola = Console.ReadLine().ToLower()[0];
// password += letteraMinuscola;

// Console.Write("Metti un numero: ");
// char numero = Console.ReadLine()[0];
// password += numero;

// Console.Write("Metti un simbolo: ");
// char simbolo = Console.ReadLine()[0];
// password += simbolo;

// int lunghezza =20;
// lunghezza -= 4;
// lunghezza = rnd.Next(8,20);


// for (int i = 0; i < lunghezza; i++)
// {
//   char p = (char)rnd.Next(33, 127);
//   password += p;
// }

// password = new string(password.OrderBy(i => rnd.Next()).ToArray());

// Console.WriteLine($"Computer ha creato un password:{password}");


//! creo di nuovo


string maiuscola = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
string minuscola = "abcdefghijklmnopqrstuvwxyz";
string numeri = "0123456789";
string simboli = "!@#$%^&*()_+";

string caratteri = maiuscola + minuscola + numeri + simboli;

Random rnd1 = new Random();
string password1 = string.Empty;
Console.WriteLine("Decidi la lunghezza della password tra 8 e 20 caratteri");

int lunghezza1;
while (true)
{
    lunghezza1 = int.Parse(Console.ReadLine());
    if (lunghezza1 < 8 || lunghezza1 > 20)
    {
        Console.WriteLine("Devi inserire un numero tra 8 e 20");
    }
    else
    {
        break;
    }
}

password1 += maiuscola[rnd1.Next(maiuscola.Length)];
password1 += minuscola[rnd1.Next(minuscola.Length)];
password1 += numeri[rnd1.Next(numeri.Length)];
password1 += simboli[rnd1.Next(simboli.Length)];

for (int i = 4; i < lunghezza1; i++)
{
    char p = caratteri[rnd1.Next(caratteri.Length)];
    password1 += p;
}

// per fare mix-password!
password1 = new string(password1.OrderBy(c => rnd1.Next()).ToArray());

Console.WriteLine("Controlliamo la sicurezza della password");
// controllo sicurezze e anche count i carretteri.

int countMaiuscola = 0;
int countMinuscola = 0;
int countNumeri = 0;
int countSimboli = 0;

foreach (char item in password1)
{
    if (maiuscola.Contains(item)) countMaiuscola++;
    if (minuscola.Contains(item)) countMinuscola++;
    if (numeri.Contains(item)) countNumeri++;
    if (simboli.Contains(item)) countSimboli++;
}

bool controlloNull = string.IsNullOrWhiteSpace(password1);

if (countMaiuscola > 0 && countMinuscola > 0 && countNumeri > 0 && countSimboli > 0 && !controlloNull)
{
    Console.WriteLine("La password è sicura");
    Console.WriteLine($"Computer ha creato un password: {password1}");
}
else
{
    Console.WriteLine("La password non è sicura e prova di nuovo");
}

Console.WriteLine("dettagli di sicurezza della password");
Console.Write($"Maiscola: {countMaiuscola}");
Console.Write($"\nMinuscola: {countMinuscola}");
Console.Write($"\nNumeri: {countNumeri}");
Console.Write($"\nSimboli: {countSimboli}");
