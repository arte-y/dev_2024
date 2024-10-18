// CONDIZIONI
// le principali istruzione di controllo sono:
// if
// else
// else if
// swicth

// pulisce la console
Console.Clear();
// ESEMPIO ID IF
// se una condizone viene soddifatta un blocco di codice
int v = 10;

if (v > 5)
{
    Console.WriteLine("v e maggiore di 5");
}

// ESEMPIO DI IF ELSE
// se una condizone viene soddifatta un blocco di codice altrimenti (ne esegue) en altro

int w = 10; 
if (w > 5)
{
    Console.WriteLine("w e maggiore di 5");
}
else
{
    Console.WriteLine("w e maggiore o uguale a 5");
}

// ESEMPIO DI IF ELSE IF
// // se una condizone viene soddifatta un blocco di codice altrimenti un altro se nessuna condizione  

int x = 10; 
if ( x > 5)
{
    Console.WriteLine("x e maggiore di 5");
}
else if (x == 5) 
{
    Console.WriteLine("x e uguale a 5");
}
else 
{
    Console.WriteLine("x e minore di 5");
}

// ESEMPIO DI SWICTH
// esegue un blocco di codice in base al valore di una variabile
int y = 10;
switch (y)
{
    case 5:
    Console.WriteLine("y e uguale a 5");
    break;
    case 10:
    Console.WriteLine("y e uguale a 10");
    break;
    default:
    Console.WriteLine("y non e ne 5 ne 10");
    break;
}

// esempio di switch con stringhe
string z="Ciao";
switch (z)
{
    case "ciao":
        Console.WriteLine("z e uguale a cioa");
        break;
    case "mondo":
        Console.WriteLine("z u uguale a mondo");
        break;
    default:
    Console.WriteLine("z non e ne ciao ne mondo");
    break;
}

// esempio di switch con bool
bool a = true;
switch (a)
{
    case true:
    Console.WriteLine("a e true");
    break;
    case false:
    Console.WriteLine("a e false");
    break;
    default:
    Console.WriteLine("a non e true ne false");
    break;
}


// Esempio-1
Console.Clear();    

Console.WriteLine("Inserice una parola Genovese!");
string g2 = Console.ReadLine().ToLower();


if (g2=="belin")
{
    Console.WriteLine($"Va bien, Sei di Genvoese! perhcè hai detto {g2}!");
}
else
{
    Console.WriteLine("Non sei di Genovese!");
}

// Esempio-2
Console.Clear();
Dictionary<string, int> voti = new Dictionary<string, int>(); 
voti.Add("Tamer", 90);
voti.Add("Mario", 85);
voti.Add("Irene", 50);
voti.Add("Jane", 70);
voti.Add("Anto", 75);
voti.Add("Francesco", 40);


foreach (var item in voti) 
{
    Console.WriteLine($"Name: {item.Key}, Vote: {item.Value}"); 
}

// Esempio-3
Console.Clear();
Console.WriteLine("Metti il nome di mese");
string meseNome = Console.ReadLine().ToLower();

switch (meseNome)
{
    case "dicembre":
    case "gennaio":
    case "febbraio":
    Console.WriteLine("Stagione Inverno");
    break;
    case "marzo":
    case "aprile":
    case "maggio":
    Console.WriteLine("Stagione Primavera");
    break;
    case "giugno":
    case "luglio":
    case"agosto":
    Console.WriteLine("Stagione Estate");
    break;
    case "settembre":
    case "ottobre":
    case "novembre":
    Console.WriteLine("Stagione autom");
    break;
    default:
    break;
}




