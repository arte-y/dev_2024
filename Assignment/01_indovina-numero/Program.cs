// // ﻿Random random = new Random(); // Random e la classe che genera numeri casuali
// // // new e il costruttore della classe Random che istanzia un oggetto Random
// // // random e l'oggetto Random che possiamo utilizzare
// // int numeroDaIndovinare = random.Next(1, 101); // Next e il metodo che genera un numero casuale tra 1 e 100
// // // viene generato un intervallo semi aperto tra 1 e 101 quindi che comprende il numero iniziale (1) ma esclude il numero finale (101)
// // // il metodo Next genera un numero casuale compreso tra il valore minimo incluso e il valore massimo escluso.

// // // verifico che il metodo next abbia generato il numero casuale stampandolo
// // // Console.WriteLine(numeroDaIndovinare);

// // // messaggio di inserimento numero
// // Console.WriteLine("Indovina il numero (tra 1 e 100): ");

// // // dichiaro una variabile alla quale dopo assegnero il valore inserito dall'utente
// // int numeroInserito;

// // // assegno alla variabile il valore inserito dall'utente
// // numeroInserito = Convert.ToInt32(Console.ReadLine()); // converto il valore inserito dall'utente in un intero perche Console.ReadLine restituisce una stringa
// // // in alternativa al ToInt32 posso usare il metodo Parse
// // // int numeroInserito = int.Parse(Console.ReadLine());
// // // oppure se voglio farlo in un unica istruzione
// // // int numeroInserito = Convert.ToInt32(Console.ReadLine());

// // // verifico che il numero inserito sia uguale al numero da indovinare
// // if (numeroInserito == numeroDaIndovinare)
// // {
// //     // se il numero inserito e uguale al numero da indovinare stampo il messaggio di congratulazioni
// //     Console.WriteLine("Complimenti! Hai indovinato il numero.");
// // }
// // else
// // {
// //     // se il numero inserito non e uguale al numero da indovinare stampo il messaggio di errore
// //     Console.WriteLine("Mi dispiace! Non hai indovinato il numero.");
// //     // stampo il numero da indovinare
// //     Console.WriteLine($"Il numero da indovinare era: {numeroDaIndovinare}");
// // }

// // new page

// // Console.Clear();

// // Random random = new Random(); // Random e la classe che genera numeri casuali
// // int numeroDaIndovinare = random.Next(1, 101); // Next e il metodo che genera un numero casuale tra 1 e 100
// // int numeroInserito;
// // int tentativiMassimi = 5;  
// // int tentativiEffettuati = 0;  
// // bool haIndovinato = false;
// // int numeroUtente = 0;

// // Console.Clear();

// // Console.WriteLine("Indovina il numero (tra 1 e 100). Hai 5 tentativi.");

// // while (tentativiEffettuati < tentativiMassimi && !haIndovinato)  
// // {  
// //     Console.Write("Tentativo {0}: ", tentativiEffettuati + 1);  

// //     // numeroUtente = int.Parse(Console.ReadLine());  
// //     numeroUtente = int.Parse(Console.ReadLine());

// //     tentativiEffettuati++;

// //     if (numeroUtente < numeroDaIndovinare)  
// //     {  
// //         Console.WriteLine("Il numero da indovinare è maggiore.");  
// //     }  
// //     else if (numeroUtente > numeroDaIndovinare)  
// //     {  
// //         Console.WriteLine("Il numero da indovinare è minore.");  
// //     }  
// //     else  
// //     {  
// //         Console.WriteLine("Complimenti! Hai indovinato il numero.");  
// //         haIndovinato = true;  
// //     }

// //     if (!haIndovinato && tentativiEffettuati == tentativiMassimi)  
// //     {  
// //         Console.WriteLine("Hai esaurito i tentativi. Il numero era " + numeroDaIndovinare + ".");  
// //     }  
// // }
// // ***************************************************************************************************************
// // sunum yaptigim bu
// #region benim yaptigim

// // Console.Clear();
// // do
// // {
// //     int difficiltà = 0;
// //     int tentativo = 0;
// //     int puntiMax = 0;
// //     string nomeUtente;

// //     List<int> tentativiUtente = new List<int>(); // per memorizzia i numeri (girilen sayilar icin liste yapildi!)
// //     Dictionary<int, int> punteggiTentativo = new Dictionary<int, int>();
// //     List<string> utenteList = new List<string>();

// //     Console.WriteLine("Inserisce il tuo nome e cognome");
// //     nomeUtente = Console.ReadLine();

// //     Console.WriteLine("Scegli un livelli di difficiltà");
// //     Console.WriteLine("1. Facile (numeri da 1 a 50, 10 tentativi)");
// //     Console.WriteLine("2. Medio(numeri da 1 a 100, 7 tentativi)");
// //     Console.WriteLine("3. Difficile(numeri da 1 a 200, 5 tentativi)");


// //     //string utenteD = Console.ReadLine();
// //     //int utenteS = Convert.ToInt32(utenteD);
// //     int utenteS = 0;

// //     bool successo1 = int.TryParse(Console.ReadLine(), out utenteS);
// //     if (!successo1 || utenteS < 1 || utenteS > 3)
// //     {
// //         Console.WriteLine("Inserisci un numero valido!");
// //         continue;
// //     }
// //     Console.Clear();

// //     switch (utenteS)
// //     {
// //         case 1:
// //             difficiltà = 50;
// //             puntiMax = 100;
// //             tentativo = 10;

// //             break;
// //         case 2:
// //             difficiltà = 100;
// //             puntiMax = 100;
// //             tentativo = 7;
// //             break;
// //         case 3:
// //             difficiltà = 200;
// //             puntiMax = 100;
// //             tentativo = 5;
// //             break;
// //         default:
// //             Console.WriteLine("Erorre! Scegli bene belinn");
// //             break;
// //     }
// //     Random rnd = new Random();
// //     int indovinaNumero = rnd.Next(1, difficiltà);

// //     int ciclio = 0;
// //     // int puntiMax = 100 / tentativo;
// //     Console.WriteLine($"PC ha creato questo numero ({indovinaNumero})");

// //     while (tentativo > 0)
// //     {
// //         ciclio++;
// //         int inseritoNumero = 0;
// //         Console.WriteLine($"il sottoscritto: {nomeUtente} indovina un numero (tra 1 e {difficiltà}) e Hai {tentativo} tentativi.");
// //         //inseritoNumero = int.Parse(Console.ReadLine());
// //         bool successo = int.TryParse(Console.ReadLine(), out inseritoNumero);
// //         if (!successo || inseritoNumero > difficiltà)
// //         {
// //             Console.WriteLine("Inserisci un numero valido!");
// //             continue;
// //         }
// //         int punti;
// //         tentativo--;
// //         punteggiTentativo.Add(tentativo, puntiMax);
// //         tentativiUtente.Add(inseritoNumero); // add liste ciclio! (girilen sayilari listeye ekler ve asagida yazdiririz)
// //         utenteList.Add(nomeUtente);

// //         if (inseritoNumero == indovinaNumero)
// //         {
// //             punti = 100 - (puntiMax * (ciclio - 1));
// //             Console.WriteLine($"Complimenti! {nomeUtente} Hai indovinato il numero {indovinaNumero} e punti {punti}");
// //             break;
// //         }
// //         else
// //         {
// //             if (tentativo == 0)
// //             {
// //                 Console.WriteLine($"Tentativi finiti. Hai perso.!");
// //                 break;
// //             }
// //             if (inseritoNumero < indovinaNumero)
// //             {
// //                 Console.WriteLine("il numero è maggiore");
// //             }
// //             else
// //             {
// //                 Console.WriteLine("il numero è minore");
// //             }
// //         }

// //     }
// //     Console.WriteLine($"{nomeUtente} Hai provato il numero; ");

// //     foreach (var item in utenteList)
// //     {
// //         Console.WriteLine(item);
// //     }

// //     Console.WriteLine("i tentativi e punteggi");
// //     foreach (var item1 in punteggiTentativo)
// //     {
// //         Console.WriteLine($"{item1.Key} /- {item1.Value}");
// //     }
// //     Console.WriteLine($"Il nome e cognome:{nomeUtente} hai provato {tentativiUtente.Count} volte e i tuoi punteggi {puntiMax}");

// //     Console.WriteLine(" \nGame Over");
// //     Console.WriteLine("****************");

// //     Console.Write($"Voresti continuare a giocare? (S/N):");
// //     string risulto = Console.ReadLine().ToLower();
// //     if (risulto == "s")
// //     {
// //         Console.WriteLine("Inizia a nouvo gioco");
// //     }
// //     else if (risulto == "n")
// //     {
// //         Console.WriteLine("Cioa Caro/a");
// //         break;
// //     }
// //     else
// //     {
// //         Console.WriteLine("non valido - Ciao!");
// //         break;
// //     }

// // } while (true);

// #endregion finito *******************

// ******************************************************************************************

// Console.Clear();

// do
// {
//     Console.Clear();

//     int difficiltà = 0;
//     int tentativo = 0;
//     int puntiMax = 0;
//     string nomeUtente;
//     int numeroUtente = 0;


//     Dictionary<string, List<int>> tentativiUtenti = new Dictionary<string, List<int>>(); // creo un dizionario per memorizzare i tentativi degli utenti

//         Console.WriteLine("Inserisci il tuo nome:");
//     nomeUtente = Console.ReadLine();
//     Console.WriteLine("Scegli un livelli di difficiltà");
//     Console.WriteLine("1. Facile (numeri da 1 a 50, 10 tentativi)");
//     Console.WriteLine("2. Medio(numeri da 1 a 100, 7 tentativi)");
//     Console.WriteLine("3. Difficile(numeri da 1 a 200, 5 tentativi)");
//     //string utenteD = Console.ReadLine();
//     //int utenteS = Convert.ToInt32(utenteD);
//     int utenteS = 0;

//     bool successo1 = int.TryParse(Console.ReadLine(), out utenteS);
//     if (!successo1 || utenteS < 1 || utenteS > 3)
//     {
//         Console.WriteLine("Inserisci un numero valido!");
//         continue;
//     }

//     switch (utenteS)
//     {
//         case 1:
//             tentativo = 10;
//             difficiltà = 50;
//             puntiMax = 100 / tentativo;

//             break;
//         case 2:
//             tentativo = 7;
//             difficiltà = 100;
//             puntiMax = 200 / tentativo;
//             break;
//         case 3:
//             tentativo = 5;
//             difficiltà = 200;
//             puntiMax = 300 / tentativo;
//             break;
//         default:
//             Console.WriteLine("Erorre! Scegli bene belinn");
//             break;
//     }
//     Random rnd = new Random();
//     int indovinaNumero = rnd.Next(1, difficiltà);

//     int ciclio = 0;
//     // int puntiMax = 100 / tentativo;
//     Console.WriteLine(indovinaNumero);


//     while (tentativo > 0)
//     {
//         ciclio++;
//         int inseritoNumero = 0;
//         Console.WriteLine($"indovina un numero (tra 1 e {difficiltà}) e Hai {tentativo - 0} tentativi.");
//         //inseritoNumero = int.Parse(Console.ReadLine());
//         bool successo = int.TryParse(Console.ReadLine(), out inseritoNumero);
//         if (!successo || inseritoNumero > difficiltà)
//         {
//             Console.WriteLine("Inserisci un numero valido!");
//             continue;
//         }
//         tentativo--;
//          if (!tentativiUtenti.ContainsKey(nomeUtente))
//         {
//             tentativiUtenti.Add(nomeUtente, new List<int>());
//         }

//         tentativiUtenti[nomeUtente].Add(numeroUtente);
//         if (inseritoNumero == indovinaNumero)
//         {
//             int punti = 100 - (puntiMax * (ciclio - 1));
//             Console.WriteLine($"Complimenti! Hai indovinato il numero {indovinaNumero} e punti {punti}");
//             break;
//         }
//         else
//         {
//             if (tentativo == 0)
//             {
//                 Console.WriteLine($"Tentativi finiti. Hai perso.!");
//                 break;
//             }
//             if (inseritoNumero < indovinaNumero)
//             {
//                 Console.WriteLine("il numero è maggiore");
//             }
//             else
//             {
//                 Console.WriteLine("il numero è minore");
//             }
//         }

//     }
//     // Console.WriteLine($"Hai provato il numero; ");
//     // foreach (var item in tentativiUtente) // per memorizzia - crea una list e poi fai una display con foreach!
//     // {
//     //     Console.Write($"- {item} ");
//     // }
//      Console.WriteLine("Tentativi effettuati: ");

//     foreach (var tentativoUtente in tentativiUtenti)
//     {
//         Console.WriteLine($"{tentativoUtente.Key}: {string.Join(", ", tentativoUtente.Value)}"); // stampo i tentativi degli utenti
//     }

//     Console.WriteLine(" \nGame Over");
//     Console.WriteLine("****************");

//     Console.Write("Voresti continuare a giocare? (S/N):");
//     string risulto = Console.ReadLine().ToLower();
//     if (risulto == "s")
//     {
//         Console.WriteLine("Inizia a nouvo gioco");
//     }
//     else
//     {
//         Console.WriteLine("Cioa Caro/a");
//         break;
//     }

// } while (true);
// ************************

#region prof ha fatto!
Console.Clear();
Random random = new Random();
int numeroDaIndovinare = 0;
int punteggio = 0;
bool haIndovinato = false;
int tentativi = 0;
int numeroUtente = 0;

Dictionary<string, List<int>> tentativiUtenti = new Dictionary<string, List<int>>(); // creo un dizionario per memorizzare i tentativi degli utenti

string risposta = "s";

do
{
    int scelta = 0;

    do
    {
        Console.WriteLine("Scegli il livello di difficolta':");
        Console.WriteLine("1. Facile (1-50, 10 tentativi)");
        Console.WriteLine("2. Medio (1-100, 7 tentativi)");
        Console.WriteLine("3. Difficile (1-200, 5 tentativi)");

        bool successoLivelloDifficolta = int.TryParse(Console.ReadLine(), out scelta);
        // pulisco la console
        Console.Clear();
        if (!successoLivelloDifficolta || scelta < 1 || scelta > 3)
        {
            Console.WriteLine("Scelta non valida.");
        }
    } while (scelta < 1 || scelta > 3);

    switch (scelta)
    {
        case 1:
            numeroDaIndovinare = random.Next(1, 51);
            punteggio = 100;
            tentativi = 10;
            break;
        case 2:
            numeroDaIndovinare = random.Next(1, 101);
            punteggio = 200;
            tentativi = 7;
            break;
        case 3:
            numeroDaIndovinare = random.Next(1, 201);
            punteggio = 300;
            tentativi = 5;
            break;
        default:
            Console.WriteLine("Scelta non valida.");
            break;
    }
    Console.WriteLine($"secret number {numeroDaIndovinare}");

    Console.WriteLine("Inserisci il tuo nome:");
    string nomeUtente = Console.ReadLine();

    

    Console.WriteLine($"Indovina il numero. Punteggio massimo: {punteggio} punti.");

    while (!haIndovinato && tentativi > 0)
    {
        Console.Write("Tentativo: ");
        bool successo = int.TryParse(Console.ReadLine(), out numeroUtente);
        // pulisco la console
        Console.Clear();

        if (!successo)
        {
            Console.WriteLine("Inserisci un numero valido.");
            continue;
        }

        tentativi--;
        // aggiungo il tentativo alla lista del nomeUtente
        if (!tentativiUtenti.ContainsKey(nomeUtente))
        {
            tentativiUtenti.Add(nomeUtente, new List<int>());
        }

        tentativiUtenti[nomeUtente].Add(numeroUtente); // aggiungo il tentativo alla lista del nomeUtente uso [nomeUtente] per accedere alla lista del nomeUtente

        if (numeroUtente < numeroDaIndovinare)
        {
            Console.WriteLine("Il numero da indovinare e' maggiore.");
        }
        else if (numeroUtente > numeroDaIndovinare)
        {
            Console.WriteLine("Il numero da indovinare e' minore.");
        }
        else
        {
            Console.WriteLine($"Hai indovinato! Punteggio: {punteggio}");
            haIndovinato = true;
        }

        if (!haIndovinato && tentativi == 0)
        {
            Console.WriteLine($"Hai esaurito i tentativi. Il numero era {numeroDaIndovinare}.");
        }

    }

    if (haIndovinato)
    {
        // stampa il punteggio dell utente
        Console.WriteLine($"Punteggio: {punteggio}");
    }

    Console.WriteLine("Tentativi effettuati: ");

    foreach (var tentativoUtente in tentativiUtenti)
    {
        Console.WriteLine($"{tentativoUtente.Key}: {string.Join(", ", tentativoUtente.Value)}"); // stampo i tentativi degli utenti
    }

    Console.WriteLine("Vuoi giocare di nuovo? (s/n)");

    risposta = Console.ReadLine();

    Console.Clear();

    while (risposta != "s" && risposta != "S" && risposta != "n" && risposta != "N")
    {
        Console.WriteLine("Risposta non valida. Vuoi giocare di nuovo? (s/n)");
        risposta = Console.ReadLine();
        Console.Clear();
    }

    haIndovinato = false;

    // tentativiUtenti.Clear(); // cancello i tentativi degli utenti

} while (risposta == "s" || risposta == "S");
#endregion