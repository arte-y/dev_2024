# Metodo Verifica Input

## Versione 1


## Obiettivo

- programma in c# che contiene una serie di metodi generici per la verifica degli input

- un metodo per la verifica di un numero intero
- un metodo per la verifica di un numero decimale
- un metodo per la verifica di una stringa non vuota
- un metodo per la verifica di un numero sia compresso in un intervallo
- un metodo per la verifica di un char non vuoto
- un metodo per la verifica di un numero

```csharp
﻿Console.Clear();
int controlInt = VerificaIntero();
Console.WriteLine($"*** Hai inserito il numero: {controlInt} ***");

decimal controlDec = VerificaDecimale();
Console.WriteLine($"*** Hai inserito il numero decimale: {controlDec} ***");

string controlString = VerificaStringa();
Console.WriteLine($"*** Hai inserito la stringa: {controlString} ***");

char controlChar = VerificaChar();
Console.WriteLine($"*** Hai inserito il carattere: {controlChar} ***");



#region METODI
int VerificaIntero()
{
  int risposta=0;
  bool isInt = false;
  do
  {
    try
    {
      Console.WriteLine("Inserisci un numero intero: ");
      risposta = Convert.ToInt32(Console.ReadLine());
      break;      
    }
    catch (FormatException)
    {
      Console.WriteLine("Errore! Inserisci un numero intero.");
      continue;
    }
    
  } while (!isInt);

  return risposta;
  
}

decimal VerificaDecimale()
{
  decimal risposta =0;
  bool isDecimal = false;
  do
  {
    try
    {
      Console.WriteLine("Inserisci un numero decimale: ");
      risposta = Convert.ToDecimal(Console.ReadLine());
    }
    catch (FormatException)
    {
      Console.WriteLine("Errore! Inserisci un numero decimale.");
      continue;
    }
    if (!risposta.ToString().Contains(","))
    {
      Console.WriteLine("Errore! Inserisci un numero decimale.");
      continue;
    }
    break;

  } while (!isDecimal);
  return risposta;
}

string VerificaStringa()
{
  string risposta=string.Empty;
  bool isString = false;
  do
  {
    try
    {
      Console.WriteLine("Inserisci una stringa: ");
      risposta = Console.ReadLine();
    }
    catch (FormatException)
    {
      Console.WriteLine("Errore! Inserisci una stringa.");
      continue;
    }
    if (string.IsNullOrWhiteSpace(risposta))
    {
      Console.WriteLine("Errore! stringa vuota.");
      continue;
    }
    break;
  } while (!isString);
  return risposta;
}

char VerificaChar()
{
  char risposta ='\0';
  bool isChar = false;
  do
  {
    try
    {
      Console.WriteLine("Inserisci un carattere Char: ");
      risposta = Convert.ToChar(Console.ReadLine());
    }
    catch (FormatException)
    {
      Console.WriteLine("Errore! Inserisci un carattere.");
      continue;
    }
    if (risposta.ToString().Length > 1)
    {
      Console.WriteLine("Errore! Inserisci un solo carattere.");
      continue;
    }
    if (char.IsWhiteSpace(risposta) || char.IsDigit(risposta) || char.IsPunctuation(risposta) || char.IsSymbol(risposta))
    {
      Console.WriteLine("Errore! Char vuoto o (numero, punteggiatura, simbolo).");
      continue;
    }
    break;
  } while (!isChar);
  return risposta;
}

#endregion
```

```bash
git add --all
git commit "versione1 motodo verifica"
git push -u origin main
```
