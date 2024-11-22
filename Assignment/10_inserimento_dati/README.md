# Inserimento di dati

## Versione 1

## Obiettivo

- Programma in C# che calcola alcune statistiche sui punteggi inseriti dell'utente

- L'utente deve poter terminare l'inserimento dei punteggi quando l'utente inserisce un numero negativo

- Dopo l'inserimento il programma deve calcolare e mostrare
  - il numero totale di punteggi inseriti
  - il punteggio piu alto
  - il punteggio piu basso
  - la media dei punteggio
- se l'utente inserisce solo un numero negativo, il programma deve stampare un messaggio di errore e terminare





## Suggerimento

- usa una lista per memorizzare i punteggi inseriti dall'utente

- controllo come vengono gestiti gli input

- usa i metodi della liberira Math

```csharp

List<double> memorizzarePunteggio = new List<double>();

Console.WriteLine("Inserisci i punteggi, per terminare inserisci un punteggio negativo");

InsericePunteggi();

QualeOperazione();

TuttiPunteggi();


#region Funzioni

void InsericePunteggi()
{
  while (true)
  {
    Console.Write("Inserisci un puntteggi: ");
    double punteggio = double.Parse(Console.ReadLine());

    if (punteggio < 0)
    {
      break;
    }
    memorizzarePunteggio.Add(punteggio);
  }

}

void QualeOperazione()
{
  do
  {
    Console.WriteLine("Quole operazione vuoi vedere? Som, Max, Min, Avg");
    string operazione = Console.ReadLine().ToLower();

    if (operazione == "som" && memorizzarePunteggio.Count > 0)
    {
      double sommaPunteggio = memorizzarePunteggio.Sum();
      Console.WriteLine($"La somma dei punteggi è {sommaPunteggio}");
    }
    else if (operazione == "max" && memorizzarePunteggio.Count > 0)
    {
      double maxPunteggio = memorizzarePunteggio.Max();
      Console.WriteLine($"Il punteggio massimo è {maxPunteggio}");
    }
    else if (operazione == "min" && memorizzarePunteggio.Count > 0)
    {
      double minPunteggio = memorizzarePunteggio.Min();
      Console.WriteLine($"Il punteggio minimo è {minPunteggio}");
    }
    else if (operazione == "avg" && memorizzarePunteggio.Count > 0)
    {
      double mediaPunteggio = memorizzarePunteggio.Average();
      Console.WriteLine($"Il punteggio medio è {mediaPunteggio:F2}");
    }
    else
    {
      Console.WriteLine("Operazione non valida");
    }
    Console.WriteLine("Vuoi fare un'altra operazione? s/n");
    string risposta = Console.ReadLine().ToLower();
    if (risposta == "n")
    {
      break;
    }

  } while (true);
}

void TuttiPunteggi()
{
  Console.WriteLine("hai inserito i seguenti punteggi");

  foreach (double item in memorizzarePunteggio)
  {
    Console.Write($"{item} ");
  }
}

#endregion

```

```bash
git add --all
git commit -m "inserimento di dati versione 1"
git push -u origin main
```