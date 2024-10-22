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

// int tentativiMassimi =5;
// int tentativiEffettuati = 0;
// bool haIndovinato = false;



// do
// {
//     Random random = new Random(); // Random e la classe che genera numeri casuali
//     int numeroDaIndovinare = random.Next(1, 100); // Next e il metodo che genera un numero casuale tra 1 e 100

//     int numeroInserito;
//     int tentativo = 5;
//     // numeroInserito = 0; // Inizializzo a 0 per entrare nel ciclo while

//     while (tentativo > 0)
//     {
//         Console.WriteLine("Indovina il numero (tra 1 e 100): ");
//         numeroInserito = Convert.ToInt32(Console.ReadLine());
//         tentativo--;

//         if (numeroDaIndovinare == numeroInserito)
//         {
//             Console.WriteLine($"Hai indovinato! Il numero da indovinare era: {numeroDaIndovinare}");
//             break;
//         }
//         else
//         {

//             if (numeroInserito < numeroDaIndovinare)
//             {
//                 Console.WriteLine("Il numero da indovinare e' maggiore");
//             }
//             else
//             {
//                 Console.WriteLine("Il numero da indovinare e' minore");
//             }
//         }

//     }

//     Console.WriteLine("Game over");

//     Console.Write("vuole continuare a giocare? (S/N):");
//     string risulto = Console.ReadLine().ToLower();
//     if (risulto == "s")
//     {
//         Console.WriteLine("inizia a nouvo gioco");
//     }
//     else
//     {
//         Console.WriteLine("Cioa Caro/a");
//         break;
//     }

// } while (true);














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

do
{
    Random rnd = new Random();
    int indovinaNumero = rnd.Next(1, 10);

    int inseritoNumero = 0;
    int tentativo = 5;

    while (tentativo > 0)
    {
        Console.WriteLine($"indovina un numero (tra 1 e 100) e Hai {tentativo - 0} tentativi.");
        inseritoNumero = int.Parse(Console.ReadLine());
        tentativo--;

        if (inseritoNumero == indovinaNumero)
        {

            Console.WriteLine($"Complimenti! Hai indovinato il numero {indovinaNumero}");
            break;
        }
        else
        {
            if (tentativo == 0)
            {
                Console.WriteLine("finito tentativo");
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

