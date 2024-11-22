# Generatore di Password

## Obiettivo

- programma in c# che genera una password sicura basata sui seguenti criteri:
- La lunghezza della password deve essere comprese tra 8 e 20 caratteri (scelta dall'utente).
- 1 lettera maiuscola
- 1 lettera minuscola
- 1 numero
- 1 carattere speciale (es: @. #, ! ecc.).

- La password generata non deve contenere spazi.

## Suggerimenti

 - usa la classe Random per generare caretteri casuali.
 - puoi creare gruppi di caratteri (lettere maiuscole, minuscole, numero e caratteri speciali) e slezionare casualmente un carattere da ciascun gruppo-
 - 

## Versione 1

```csharp
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
```

```bash
git add --all
git commit -m "Versione1"
git push -u origin main
```
