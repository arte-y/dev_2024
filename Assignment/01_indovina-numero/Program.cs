Console.Clear();
Random rnd = new Random(); // random e la classe che genera numeri causali
// new e il construttore della classe Random che istanzia un oggetto Random
// random e l'oggetto che possiamo utilizzare
int numeroDaIndovinare =rnd.Next(1,100); // next e il metodo genra numero casuale tra 1 e 100
// vienen generato un intervall semi aperto tra 1 e 101 che comprende il numero iniziale (1) ma esculude il numero finale (101)
// il metodo Next genera un numero casuale compreso tra il minimo incluso e il valore massimo esclude

// verifici che il metodo next abbia enerato il numero casuale stampandolo
// Console.WriteLine(numeroDaIndovinare);
// messagio di inserimento numero
// Console.WriteLine("Indovino il numero (tra 1 e 100)");

// dichiaro una variabile alla quale dopo associero il valore inserimento dall'utente
int numeroInserito=0;

// associo alla variabile il valore inserito dall'utente
numeroInserito = Convert.ToInt32(Console.ReadLine()); // converto il valore inserito dall'utente in un intero perche Console.ReadLine restituisce uan stringa 

// oppure se voglio farlo in un unica istruzione
// int numeroInserito =Convert.ToInt32(Console.ReadLine());

// verifico che il numero inserito sia uguale al numero da indovinare

if (numeroInserito == numeroDaIndovinare)
{
    Console.WriteLine("Complimenti! Hai indovinato il numero");
}
else
{
    Console.WriteLine("Mi dispiace! Non hai indovinato il numero");
}


















// do
// {
//   odev2sayac++;
//   Console.WriteLine($"{odev2sayac} hakkiniz uretilen sayiyi tahmin ediniz");
//   odev2tahmin = int.Parse(Console.ReadLine());
  
// } while (odev2tahmin != odev2uretilenSayi);
// Console.WriteLine($"{odev2sayac}. kere denediniz sayiyi tahamin ettiniz");
// if (tutulan > sayi)
//             {
//                 Console.WriteLine("yukari");
//             }
//             else
//             {
//                 Console.WriteLine("asagi");
//             }