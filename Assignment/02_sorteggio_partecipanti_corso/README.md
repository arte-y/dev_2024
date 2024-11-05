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
git mìcommit -m "sorteggiia partecipente"
git push -u origin main
```