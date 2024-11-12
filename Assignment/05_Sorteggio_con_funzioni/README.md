# Sorteggio Partecipanti Funzioni

## Versione 1

## Obiettivo
- Implementare le funzioni nel programma che simula il sorteggio dei partecipanti.

Programma originale:

```csharp
﻿List<string> partecipanti = new List<string> { "Tamer", "Felipe", "Diego", "Ivan", "Giorgio", "Anita", "Sofia", "Andrea" };

Random rnd = new Random();

partecipanti.Sort();

bool control = false;
for (int i = 0; i < partecipanti.Count; i++)
{
  Console.WriteLine($"Partecipanti: {partecipanti[i]}");
}


do
{

  Console.WriteLine("Vuole inserire un partecipante o eliminare o sorteggiare i partecipanti? (I/E/S)");
  string risposta = Console.ReadLine().ToLower();

  if (risposta == "i")
  {
    Console.Write("Inserice il nome partecipante: ");
    string rispostaI = Console.ReadLine();
    partecipanti.Add(rispostaI);

  }
  else if (risposta == "e")
  {
    Console.Write("Inserice il nome partecipante: ");
    string rispostaE = Console.ReadLine();
    partecipanti.Remove(rispostaE);

  }
  else if (risposta == "s")
  {
    Console.Write("inserice il numero di squadre: ");
    int numeroSquadre = int.Parse(Console.ReadLine());
    List<List<string>> squadre = new List<List<string>>();

    for (int i = 0; i < numeroSquadre; i++)
    {

      squadre.Add(new List<string>());

    }

    for (int i = 0; i < partecipanti.Count; i++)
    {
      squadre[i % numeroSquadre].Add(partecipanti[i]);
      // int index = rnd.Next(partecipanti.Count);
    }

    for (int i = 0; i < squadre.Count; i++)
    {
      Console.WriteLine($"Squadre {i + 1}: {string.Join(",", squadre[i])}");
    }
    break;
  }

} while (true);
```

### Funzioni che e possibile implementare

- `void partecipante(List<string> partecipanti)`
- `string Menu`
- `void InserisciPartecipante(List<string> partecipanti)`
- `void EliminaPartecipante(List<string> partecipanti)`
- `void Sorteggio(List<string> partecipanti)`

### Codice completo

```csharp
﻿using System.Diagnostics;

List<string> partecipanti = new List<string> { "Tamer", "Felipe", "Diego", "Ivan", "Giorgio", "Anita", "Sofia", "Andrea" };

//Random rnd = new Random();

partecipanti.Sort();

bool control = false;

partecipante(partecipanti);

do
{

  string risposta = Menu();

  if (risposta == "i")
  {
    InserisciPartecipante(partecipanti);

  }
  else if (risposta == "e")
  {
    EliminaPartecipante(partecipanti);
  }
  else if (risposta == "s")
  {
    Sorteggio(partecipanti);
    break;
  }

} while (true);


#region funzioni

void partecipante(List<string> partecipanti)
{
  for (int i = 0; i < partecipanti.Count; i++)
  {
    Console.WriteLine($"Partecipanti: {partecipanti[i]}");
  }
}

string Menu()
{
  Console.WriteLine("Vuole inserire un partecipante o eliminare o sorteggiare i partecipanti? (I/E/S)");
  string risposta = Console.ReadLine().ToLower();
  return risposta;
}

void InserisciPartecipante(List<string> partecipanti)
{
  Console.Write("Inserice il nome partecipante: ");
  string risposta = Console.ReadLine();
  partecipanti.Add(risposta);
}

void EliminaPartecipante(List<string> partecipanti)
{
  Console.Write("Elemina il nome partecipante: ");
  string risposta = Console.ReadLine();
  partecipanti.Remove(risposta);
}

void Sorteggio(List<string> partecipanti)
{
      Console.Write("inserice il numero di squadre: ");
    int numeroSquadre = int.Parse(Console.ReadLine());
    List<List<string>> squadre = new List<List<string>>();

    for (int i = 0; i < numeroSquadre; i++)
    {

      squadre.Add(new List<string>());

    }

    for (int i = 0; i < partecipanti.Count; i++)
    {
      squadre[i % numeroSquadre].Add(partecipanti[i]);
      // int index = rnd.Next(partecipanti.Count);
    }

    for (int i = 0; i < squadre.Count; i++)
    {
      Console.WriteLine($"Squadre {i + 1}: {string.Join(",", squadre[i])}");
    }
}

#endregion
```
## Comandi di versionamento

```bash
git add --all
git commit -m "Implementate funzioni nel programma che simula il sorteggio dei partecipanti"
git push -u origin main
```


## Grafici Mermaid

https://mermaid.js.org/

https://jojozhuang.github.io/tutorial/mermaid-cheat-sheet/

## flowchart basic Indivina Numero

``` mermaid
graph TD
    Start --> CreaListaPartecipante
    CreaListaPartecipante-- "Lista Sort o Sorteggio" --> ShowList
    ShowList --> Inserice
    ShowList --> Elemina
    ShowList --> Sorted
    ShowList -- "again" --> Inserice
    ShowList -- "again" --> Elemina
    

```
