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
