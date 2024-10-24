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
// ***************************************************************************************************************
// sunum yaptigim bu



do
{
    Console.Clear();

    int difficiltà = 0;
    int tentativo = 0;
    int puntiMax = 100;
    List<int> tentativiUtente = new List<int>(); // per memorizzia i numeri (girilen sayilar icin liste yapildi!)

    Console.WriteLine("Scegli un livelli di difficiltà");
    Console.WriteLine("1. Facile (numeri da 1 a 50, 10 tentativi)");
    Console.WriteLine("2. Medio(numeri da 1 a 100, 7 tentativi)");
    Console.WriteLine("3. Difficile(numeri da 1 a 200, 5 tentativi)");
    //string utenteD = Console.ReadLine();
    //int utenteS = Convert.ToInt32(utenteD);
    int utenteS = 0;

    bool successo1 = int.TryParse(Console.ReadLine(), out utenteS);
    if (!successo1 || utenteS < 1 || utenteS > 3)
    {
        Console.WriteLine("Inserisci un numero valido!");
        continue;
    }

    switch (utenteS)
    {
        case 1:
            tentativo = 10;
            difficiltà = 50;
            puntiMax = 100 / tentativo;

            break;
        case 2:
            tentativo = 7;
            difficiltà = 100;
            puntiMax = 100 / tentativo;
            break;
        case 3:
            tentativo = 5;
            difficiltà = 200;
            puntiMax = 100 / tentativo;
            break;
        default:
            Console.WriteLine("Erorre! Scegli bene belinn");
            break;
    }
    Random rnd = new Random();
    int indovinaNumero = rnd.Next(1, difficiltà);

    int ciclio = 0;
    // int puntiMax = 100 / tentativo;
    Console.WriteLine(indovinaNumero);


    while (tentativo > 0)
    {
        ciclio++;
        int inseritoNumero = 0;
        Console.WriteLine($"indovina un numero (tra 1 e {difficiltà}) e Hai {tentativo - 0} tentativi.");
        //inseritoNumero = int.Parse(Console.ReadLine());
        bool successo = int.TryParse(Console.ReadLine(), out inseritoNumero);
        if (!successo || inseritoNumero > difficiltà)
        {
            Console.WriteLine("Inserisci un numero valido!");
            continue;
        }
        tentativo--;
        tentativiUtente.Add(inseritoNumero); // add liste ciclio! (girilen sayilari listeye ekler ve asagida yazdiririz)

        if (inseritoNumero == indovinaNumero)
        {
            int punti = 100 - (puntiMax * (ciclio - 1));
            Console.WriteLine($"Complimenti! Hai indovinato il numero {indovinaNumero} e punti {punti}");
            break;
        }
        else
        {
            if (tentativo == 0)
            {
                Console.WriteLine($"Tentativi finiti. Hai perso.!");
                break;
            }
            if (inseritoNumero < indovinaNumero)
            {
                Console.WriteLine("il numero è maggiore");
            }
            else
            {
                Console.WriteLine("il numero è minore");
            }
        }

    }
    Console.WriteLine($"Hai provato il numero; ");
    foreach (var item in tentativiUtente) // per memorizzia - crea una list e poi fai una display con foreach!
    {
        Console.Write($"- {item} ");
    }

    Console.WriteLine(" \nGame Over");
    Console.WriteLine("****************");

    Console.Write("Voresti continuare a giocare? (S/N):");
    string risulto = Console.ReadLine().ToLower();
    if (risulto == "s")
    {
        Console.WriteLine("Inizia a nouvo gioco");
    }
    else
    {
        Console.WriteLine("Cioa Caro/a");
        break;
    }

} while (true);



// ****************************************************************************************

