// ﻿Random random = new Random(); // Random e la classe che genera numeri casuali
// // new e il costruttore della classe Random che istanzia un oggetto Random
// // random e l'oggetto Random che possiamo utilizzare
// int numeroDaIndovinare = random.Next(1, 101); // Next e il metodo che genera un numero casuale tra 1 e 100
// // viene generato un intervallo semi aperto tra 1 e 101 quindi che comprende il numero iniziale (1) ma esclude il numero finale (101)
// // il metodo Next genera un numero casuale compreso tra il valore minimo incluso e il valore massimo escluso.

// // verifico che il metodo next abbia generato il numero casuale stampandolo
// // Console.WriteLine(numeroDaIndovinare);

// // messaggio di inserimento numero
// Console.WriteLine("Indovina il numero (tra 1 e 100): ");

// // dichiaro una variabile alla quale dopo assegnero il valore inserito dall'utente
// int numeroInserito;

// // assegno alla variabile il valore inserito dall'utente
// numeroInserito = Convert.ToInt32(Console.ReadLine()); // converto il valore inserito dall'utente in un intero perche Console.ReadLine restituisce una stringa
// // in alternativa al ToInt32 posso usare il metodo Parse
// // int numeroInserito = int.Parse(Console.ReadLine());
// // oppure se voglio farlo in un unica istruzione
// // int numeroInserito = Convert.ToInt32(Console.ReadLine());

// // verifico che il numero inserito sia uguale al numero da indovinare
// if (numeroInserito == numeroDaIndovinare)
// {
//     // se il numero inserito e uguale al numero da indovinare stampo il messaggio di congratulazioni
//     Console.WriteLine("Complimenti! Hai indovinato il numero.");
// }
// else
// {
//     // se il numero inserito non e uguale al numero da indovinare stampo il messaggio di errore
//     Console.WriteLine("Mi dispiace! Non hai indovinato il numero.");
//     // stampo il numero da indovinare
//     Console.WriteLine($"Il numero da indovinare era: {numeroDaIndovinare}");
// }

// new page

// Console.Clear();

// Random random = new Random(); // Random e la classe che genera numeri casuali
// int numeroDaIndovinare = random.Next(1, 101); // Next e il metodo che genera un numero casuale tra 1 e 100
// int numeroInserito;
// int tentativiMassimi = 5;  
// int tentativiEffettuati = 0;  
// bool haIndovinato = false;
// int numeroUtente = 0;

// Console.Clear();

// Console.WriteLine("Indovina il numero (tra 1 e 100). Hai 5 tentativi.");

// while (tentativiEffettuati < tentativiMassimi && !haIndovinato)  
// {  
//     Console.Write("Tentativo {0}: ", tentativiEffettuati + 1);  
    
//     // numeroUtente = int.Parse(Console.ReadLine());  
//     numeroUtente = int.Parse(Console.ReadLine());
    
//     tentativiEffettuati++;

//     if (numeroUtente < numeroDaIndovinare)  
//     {  
//         Console.WriteLine("Il numero da indovinare è maggiore.");  
//     }  
//     else if (numeroUtente > numeroDaIndovinare)  
//     {  
//         Console.WriteLine("Il numero da indovinare è minore.");  
//     }  
//     else  
//     {  
//         Console.WriteLine("Complimenti! Hai indovinato il numero.");  
//         haIndovinato = true;  
//     }

//     if (!haIndovinato && tentativiEffettuati == tentativiMassimi)  
//     {  
//         Console.WriteLine("Hai esaurito i tentativi. Il numero era " + numeroDaIndovinare + ".");  
//     }  
// }




// Evde yaptigim

// do
// {
//     int gues = 1;
//     int guesNumber = 0;
//     Random rdn = new Random();
//     guesNumber = rdn.Next(1, 10); //computer give a number

//     while (true)
//     {
//         Console.WriteLine("Please insert your guess number");
//         string guesNumberUser = Console.ReadLine(); // user gues a number--
//         int guesNumberUser1;

//         if (!int.TryParse(guesNumberUser, out guesNumberUser1)) // una domanda! perhcè non so come posso farlo...!
//         {
//             Console.WriteLine("Invalid input! Please insert a valid number");
//             continue;
//         }

//         if (guesNumber == guesNumberUser1) // user and computer gues number --
//         {
//             Console.WriteLine("Congratulations, you guessed correctly.");
//             break;
//         }
//         else
//         {
//             gues++;
//             Console.Write("You guessed wrong, try again. / ");
//         }
//         if (guesNumber > guesNumberUser1) // computer number > from user number
//         {
//             Console.WriteLine("GO-UP");
//         }
//         else
//         {
//             Console.WriteLine("GO-DOWN");
//         }
//     }
//     Console.WriteLine("Game Over!");

//     Console.Write("Would you like to continue the game? (y/n): ");
//     string result = Console.ReadLine().ToLower();

//     if (result == "y")
//     {
//         Console.WriteLine("Starting a new game ...");
//     }
//     else if (result == "n")
//     {
//         Console.WriteLine("Thank you. See you again!");
//         break; // finish the game

//     }
//     else
//     {
//         Console.WriteLine("Error!");
//         break; //invalid input. finish game
//     }
// } while (true);
//evde yaptigim son


// sunum yaptigim bu

Console.Clear();


Console.WriteLine("Scegli un livelli di difficiltà");
Console.WriteLine("1. Facile (numeri da 1 a 50, 10 tentativi)");
Console.WriteLine("2. Medio(numeri da 1 a 100, 7 tentativi)");
Console.WriteLine("3. Difficile(numeri da 1 a 200, 5 tentativi)");
string utenteD = Console.ReadLine();
int utenteDif =Convert.ToInt32(utenteD);

switch (utenteDif)
{

    case 1:
        Random rnd = new Random();
    int indovinaNumero = rnd.Next(1, 50);

    int inseritoNumero = 0;
    int tentativo = 10;
    
    int puntiMax = 100 / tentativo;
    break;
    case 2:
    break; 
    case 3:
    break;    
    default:
    break;
}



do
{
    Random rnd = new Random();
    int indovinaNumero = rnd.Next(1, 100);

    int inseritoNumero = 0;
    int tentativo = 5;
    
    int puntiMax = 100 / tentativo;
    int ciclio =0;

    Console.WriteLine(indovinaNumero);

    while (tentativo > 0)
    {
        ciclio++;
        Console.WriteLine($"indovina un numero (tra 1 e 100) e Hai {tentativo - 0} tentativi.");
        inseritoNumero = int.Parse(Console.ReadLine());
        tentativo--;

        if (inseritoNumero == indovinaNumero)
        {
            int punti = 100 - (puntiMax * (ciclio -1));
            Console.WriteLine($"Complimenti! Hai indovinato il numero {indovinaNumero} e punti {punti}");
            break;
        }
        else
        {
            if (tentativo == 0)
            {
                Console.WriteLine($"finito tentativo");
                break;
            }
            if (inseritoNumero < indovinaNumero)
            {
                Console.WriteLine("maggiore");
            }
            else
            {
                Console.WriteLine("minore");
            }
        }
    }
    Console.WriteLine("Game Over");
    Console.WriteLine("****************");

    Console.Write("vuole continuare a giocare? (S/N):");
    string risulto = Console.ReadLine().ToLower();
    if (risulto == "s")
    {
        Console.WriteLine("inizia a nouvo gioco");
    }
    else
    {
        Console.WriteLine("Cioa Caro/a");
        break;
    }

} while (true);

// hocanin eklemesi 

