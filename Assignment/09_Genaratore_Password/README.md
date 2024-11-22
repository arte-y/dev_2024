# Generatore di Password

## Versione 1

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
 - puoi creare gruppi di caratteri (lettere maiuscole, minuscole, numero e caratteri speciali) e slezionare casualmente un carattere da ciascun gruppo

 Codice Programma
```csharp
string maiuscola = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
string minuscola = "abcdefghijklmnopqrstuvwxyz";
string numeri = "0123456789";
string simboli = "!@#$%^&*()_+";
string caratteri = maiuscola + minuscola + numeri + simboli;
Random rnd1 = new Random();
string password1 = string.Empty;
int lunghezza1 = 0;

LunghezzaPassword();

CreaPassword();

int countMaiuscola = 0;
int countMinuscola = 0;
int countNumeri = 0;
int countSimboli = 0;

ControlloSicurezza();

DettagliSicurezza();


#region Funzioni

void LunghezzaPassword()
{
    Console.WriteLine("Decidi la lunghezza della password tra 8 e 20 caratteri");
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
}

void CreaPassword()
{
    password1 += maiuscola[rnd1.Next(maiuscola.Length)];
    password1 += minuscola[rnd1.Next(minuscola.Length)];
    password1 += numeri[rnd1.Next(numeri.Length)];
    password1 += simboli[rnd1.Next(simboli.Length)];
    
    for (int i = 0; i < lunghezza1; i++)
    {
        char p = caratteri[rnd1.Next(caratteri.Length)];
        password1 += p;
    }
    password1 = new string(password1.OrderBy(c => rnd1.Next()).ToArray());
}

void ControlloSicurezza()
{
    foreach (char item in password1)
    {
        if (maiuscola.Contains(item)) countMaiuscola++;
        if (minuscola.Contains(item)) countMinuscola++;
        if (numeri.Contains(item)) countNumeri++;
        if (simboli.Contains(item)) countSimboli++;
    }

    bool controlloNull = string.IsNullOrWhiteSpace(password1);

    Console.WriteLine($"Computer ha creato un password: {password1}");

    Console.WriteLine("Controlliamo la sicurezza della password ...");
    
    Thread.Sleep(2000);

    if (countMaiuscola > 0 && countMinuscola > 0 && countNumeri > 0 && countSimboli > 0 && !controlloNull)
    {
        Console.WriteLine("La password è sicura");
    }
    else
    {
        Console.WriteLine("La password non è sicura e prova di nuovo");
    }
}

void DettagliSicurezza()
{
    Console.WriteLine("Dettagli di sicurezza della password ...");
    Thread.Sleep(2000);
    Console.Write($"Maiscola: {countMaiuscola}");
    Console.Write($"\nMinuscola: {countMinuscola}");
    Console.Write($"\nNumeri: {countNumeri}");
    Console.Write($"\nSimboli: {countSimboli}");
}

#endregion
```

```bash
git add --all
git commit -m "Versione1"
git push -u origin main
```

## Versione 2

## Obiettivo

