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
// Generatore di Password


string maiuscola = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
string minuscola = "abcdefghijklmnopqrstuvwxyz";
string numeri = "0123456789";
string simboli = "!@#$%^&*()_+";

string caratteri = maiuscola + minuscola + numeri + simboli;

Random rnd1 = new Random();
string password1 = string.Empty;

Console.WriteLine("Decidi la lunghezza della password tra 8 e 20 caratteri");
int lunghezza1 = int.Parse(Console.ReadLine());
if (lunghezza1 < 8 || lunghezza1 > 20)
{
  Console.WriteLine("Devi inserire un numero tra 8 e 20");
  return;
}
else
{
  for (int i = 0; i < lunghezza1; i++)
  {
    char p = caratteri[rnd1.Next(0, caratteri.Length)];
    password1 += p;
  }
}

Console.WriteLine("Controlliamo la sicurezza della password");
if(maiuscola.Contains(password1) == password1.Contains(maiuscola)&& minuscola.Contains(password1) == password1.Contains(minuscola)&&numeri.Contains(password1) ==password1.Contains(numeri)&& simboli.Contains(password1)==password1.Contains(simboli))
{
  Console.WriteLine("Password sicura");
}
else
{
  Console.WriteLine("Password non sicura");
}

Console.WriteLine($"Computer ha creato un password:{password1}");


```

```bash
git add --all
git commit -m "Versione1"
git push -u origin main
```
