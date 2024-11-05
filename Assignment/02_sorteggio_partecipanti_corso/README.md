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

// Console.WriteLine(ListPart[rndNome]);

Console.WriteLine("Cioa, vuole vedere partecipante di corso? Dai iniziamo!");

bool control = true;
string control1 = string.Empty;
do
{
    for (int i = rndNome; i < ListPart.Count; i++)
    {
        Console.WriteLine($"Il nome: {ListPart[i]}");
        // ListPart.Remove(ListPart[i]);
        // ListPart.Remove(ListPart[rndNome]);

        if (i <= ListPart.Count)
        {
            Console.WriteLine("voule vedere altr partecipante? (S/N)");
            control1 = Console.ReadLine().ToLower();
        }
        else
        {
            Console.WriteLine("Terminato!");
        }
    }


} while (control1 == "s");

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

