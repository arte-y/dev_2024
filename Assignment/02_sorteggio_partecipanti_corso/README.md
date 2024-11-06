# Sorteggio Partecipanti

## Versione 1

## Obiettivo

- Scrivere un programma che permetta di sorteggiare i partecipanti del corso da una lista di nomi.
- I nomi vengono gestiti senza un inserimento da parte dell'utente cioe vengono inzializzati bel programma.
- Il programma estrae un partecipante singolo alle volta e lo stampo a video.


```csharp
List<string> ListPart = new List<string>();

ListPart.Add("Andrea");
ListPart.Add("Felipe");
ListPart.Add("Giorgio");
ListPart.Add("Ivan");
ListPart.Add("Anita");
ListPart.Add("Sofia");
ListPart.Add("Diego");
ListPart.Add("Tamer");

var rnd = new Random();
int rndNome = rnd.Next(ListPart.Count);

Console.WriteLine(ListPart[rndNome]);

```

## Comandi di versionamento

```bash
git add --all
git mìcommit -m "sorteggiia partecipente versione 1"
git push -u origin main
```

## Versione 2

## Obiettivo

- Scrivere un programma che permetta di sorteggiare piu volte i partecipante del corso da una lista do nomi
- Iil programma deve chiederer all utente se vuole un altro partecipante.
- I nomi dei partecipanti estrati vengono rimossi della lista.


```csharp
List<string> partecipanti = new List<string> { "Tamer", "Felipe", "Diego", "Ivan", "Giorgio", "Anita", "Sofia", "Andrea" };

Random rnd = new Random();


string risposta = null;

do
{
  if (partecipanti.Count == 0)
  {
    Console.WriteLine("non ci sono piu partecipanti da estrare");
    break;
  }
  else
  {
    int index = rnd.Next(partecipanti.Count);

    string partecipante = partecipanti[index];

    Console.WriteLine(partecipante);

    partecipanti.RemoveAt(index);
  }

  Console.WriteLine("Vuoi estrare un altro partecipante? (S/N)");
  risposta = Console.ReadLine().ToLower();



} while (risposta == "s");

```

```bash
git add --all
git mìcommit -m "sorteggiia partecipente versione 2"
git push -u origin main
```



## Versione 3

## Obiettivo

- Scrivere un programma che permetta di sorteggiare i partecipante del corso da una lista di nomi dividendoli in gruppi
- Il programma deve chiedere all utente il numero di squadre.
- Se il numero dei partecipanti non è divisibile per il numero di suqadre, il partecipanti rimanenti vengono assegnati ad un gruppo in modo casuale.

```csharp
List<string> partecipanti = new List<string> { "Tamer", "Felipe", "Diego", "Ivan", "Giorgio", "Anita", "Sofia", "Andrea" };

Random rnd = new Random();

Console.Write("inserice il numero di squadre: ");
int numeroSquadre =int.Parse(Console.ReadLine());

List<List<string>> squadre = new List<List<string>>();

for (int i = 0; i < numeroSquadre; i++)
{
  squadre.Add(new List<string>());
}

for (int i = 0; i < partecipanti.Count; i++)
{
  squadre[i %numeroSquadre].Add(partecipanti[i]);
}

for (int i = 0; i < squadre.Count; i++)
{
  Console.WriteLine($"Squadre {i+1}: {string.Join(",",squadre[i])}");
}

string risposta = null;

do
{
  if (partecipanti.Count == 0)
  {
    Console.WriteLine("non ci sono piu partecipanti da estrare");
    break;
  }
  else
  {
    int index = rnd.Next(partecipanti.Count);

    string partecipante = partecipanti[index];

    Console.WriteLine(partecipante);

    partecipanti.RemoveAt(index);
  }

  Console.WriteLine("Vuoi estrare un altro partecipante? (S/N)");
  risposta = Console.ReadLine().ToLower();

} while (risposta == "s");
```

```bash
git add --all
git mìcommit -m "sorteggio partecipente versione 3"
git push -u origin main
```

## Versione 4

## Obiettivo

- Scrivere un programma che permetta di sorteggiare i partecipante del corso da una lista di nomi dividendoli in gruppi
- Il programma deve chiedere all utente il numero di squadre.
- Se il numero dei partecipanti non è divisibile per il numero di suqadre, il partecipanti rimanenti vengono assegnati ad un gruppo in modo casuale.

```csharp

```

```bash
git add --all
git mìcommit -m "sorteggiia partecipente versione 4"
git push -u origin main
```
