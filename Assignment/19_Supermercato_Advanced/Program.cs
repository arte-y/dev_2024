// Versione nuova - 18/12/2024

// Repository
CassaRepository cassaRepository = new CassaRepository();
CategoriaRepository categoriaRepository = new CategoriaRepository();
ClienteRepository clienteRepository = new ClienteRepository();
DipendenteRipository dipendenteRipository = new DipendenteRipository();
ProdottoRepository prodottoRepository = new ProdottoRepository();
PurchasesRepository purchasesRepository = new PurchasesRepository();

// Manager
AmministratoreManager amministratoreManager = new AmministratoreManager();
CassiereManager cassiereManager = new CassiereManager();
ClienteManager clienteManager = new ClienteManager();
MagazziniereManager magazziniereManager = new MagazziniereManager();

//*

Console.WriteLine("Benvenuto nel Supermercato!");

Console.WriteLine("Log In");
string userName = InputManager.LeggiStringa("\nUserName: ");
string password = InputManager.LeggiStringa("\nPassword: ");

Console.Clear();

if (userName == "1" && password == "1")
{
  Console.WriteLine("Ammistratore!");

  Console.WriteLine("Menu:");
  Console.WriteLine("1. Visualizza Dipendenti");
  Console.WriteLine("2. Imposta Ruolo Dipendente");
  string scelta = InputManager.LeggiStringa("\nScelta: ");
  Console.Clear();

  if (scelta == "1")
  {

    Console.WriteLine("Dipendenti:");
    amministratoreManager.VisualizzaDipendenti();

  }
  else if (scelta == "2")
  {

    Console.WriteLine("Imposta Ruolo Dipendente:");
    string userNameDipendente = InputManager.LeggiStringa("\nUserName: ");    
    amministratoreManager.ImpostaRuoloDipendente(userNameDipendente);

  }

}
else if (userName == "2" && password == "2")
{
  Console.WriteLine("Cliente!");
  Console.WriteLine("Menu:");
  Console.WriteLine("1. Visualizza Prodotti");
  Console.WriteLine("2. Cerca Prodotto e Aggiungi al Carrello");
  Console.WriteLine("Rimuove un Prodotto da Carrello");
  Console.WriteLine("Cambia Stato dell Ordine");
  Console.WriteLine("Esci");
}
else if (userName == "3" && password == "3")
{
  Console.WriteLine("Cassiere!");
  Console.WriteLine("Menu:");
  
}
else if (userName == "4" && password == "4")
{
  Console.WriteLine("Magazziniere!");
  Console.WriteLine("Menu");

  Console.WriteLine("Visualizza Prodotti da Magazino");
  Console.WriteLine("Aggiunge un prodotto al Magazzino");
  Console.WriteLine("Modifica un prodotto da Magazzino");
  Console.WriteLine("Rimuove un prodotto dal Magazzino");
  Console.WriteLine("Esci");
}
else
{
  Console.WriteLine("Utente non riconosciuto");
}























//! vecchia versione -
// class Program
// {
//   static void Main(string[] args)
//   {
//     ProdottoRepository prodottoRepository = new ProdottoRepository();
//     ClienteRepository clienteRepository = new ClienteRepository();

//     List<Prodotto> prodotti = prodottoRepository.CaricaProdotti();
//     ProdottoManager manager = new ProdottoManager(prodotti);
//     ClienteManager clientManager = new ClienteManager();
//     List<Prodotto> carrello = new List<Prodotto>();



//     Console.WriteLine("Benvenuto nel Supermercato!");


//     Console.WriteLine("Log In");
//     string userName = InputManager.LeggiStringa("\nUserName: ");
//     string password = InputManager.LeggiStringa("\nPassword: ");

//     Console.Clear();
//     if (userName == "1" && password == "1")
//     {
//       Console.WriteLine("Admin!");
//       bool continua = true;
//       while (continua)
//       {
//         Console.WriteLine("\nMenu:");
//         Console.WriteLine("1. Visualizza Prodotti");
//         Console.WriteLine("2. Aggiungi Prodotto");
//         Console.WriteLine("3. Trova Prodotto per ID");
//         Console.WriteLine("4. Aggiorna Prodotto");
//         Console.WriteLine("5. Elimina Prodotto");
//         Console.WriteLine("6. Esci");

//         string scelta = InputManager.LeggiIntero("\nScelta: ", 1, 6).ToString();
//         // pulisco la console
//         Console.Clear();

//         switch (scelta)
//         {
//           case "1":
//             Console.WriteLine("Prodotti:");
//             manager.StampaProdottoIncolonnati();
//             break;
//           case "2":
//             string nome = InputManager.LeggiStringa("\nnome: ");

//             double prezzo = InputManager.LeggiDouble("\nprezzo: ");

//             int giacenza = InputManager.LeggiIntero("\ngiacenza: ");

//             string categoria = InputManager.LeggiStringa("\nCategoria: ");

//             manager.AggiungiProdotto(new Prodotto { Nome = nome, Prezzo = prezzo, Giacenza = giacenza, Categoria = categoria });

//             break;
//           case "3":
//             int idProdotto = InputManager.LeggiIntero("\nID: ");

//             Prodotto prodottoTrovato = manager.TrovaProdotto(idProdotto);
//             if (prodottoTrovato != null)
//             {
//               Console.WriteLine($"Prodotto trovato: Id: {idProdotto}: {prodottoTrovato.Nome}");
//             }
//             else
//             {
//               Console.WriteLine($"\nProdotto non trovato per ID {idProdotto}");
//             }
//             break;
//           case "4":
//             int idProdottoAggiornare = InputManager.LeggiIntero("\nID: ");

//             string nomeNuovo = InputManager.LeggiStringa("\nNome: ");

//             double prezzoNuovo = InputManager.LeggiDouble("\nPrezzo: ");

//             int giacenzaNuovo = InputManager.LeggiIntero("\nGiacenza: ");

//             string categoriaNuovo = InputManager.LeggiStringa("\nCategoria: ");

//             manager.AggiornaProdotto(idProdottoAggiornare, new Prodotto { Nome = nomeNuovo, Prezzo = prezzoNuovo, Giacenza = giacenzaNuovo, Categoria = categoriaNuovo });
//             break;
//           case "5":

//             int idProdottoEliminare = InputManager.LeggiIntero("\nID: ");

//             manager.EliminaProdotto(idProdottoEliminare);
//             break;
//           case "6":
//             prodottoRepository.SalvaProdotti(manager.OttieniProdotti());
//             continua = false;
//             break;
//           default:
//             Console.WriteLine("Scelta non valida. Riprova.");
//             break;
//         }
//       }

//     }
//     else if (userName == "2" && password == "2")
//     {

//       Console.WriteLine("Cliente!");
//       bool isRunning = true;
//       do
//       {
//         Console.WriteLine("\nMenu:");
//         Console.WriteLine("1. Visualizza Prodotti");
//         Console.WriteLine("2. Cerca Prodotto e Aggiungi al Carrello");
//         Console.WriteLine("3. Visualizza Carrello");
//         Console.WriteLine("4. Rimuovi dal Carrello");
//         Console.WriteLine("5. Acquista");
//         Console.WriteLine("6. Visualizza Storico Acquisti");
//         Console.WriteLine("7. Esci");

//         string scelta = InputManager.LeggiIntero("\nScelta: ", 1, 7).ToString();
//         Console.Clear();
//         switch (scelta)
//         {
//           case "1":
//             Console.WriteLine("Prodotti:");
//             manager.StampaProdottoIncolonnati();
//             break;

//           case "2":
//             Console.WriteLine("Cerca Prodotto e Aggiungi al Carrello:");
//             int idProdotto = InputManager.LeggiIntero("\nID: ");
//             Prodotto prodottoTrovato = manager.TrovaProdotto(idProdotto);
//             if (prodottoTrovato != null)
//             {
//               Console.WriteLine($"Prodotto trovato: Id: {idProdotto}: {prodottoTrovato.Nome} Prezzo: {prodottoTrovato.Prezzo} Giacenza: {prodottoTrovato.Giacenza} Categoria: {prodottoTrovato.Categoria}");
//               Console.WriteLine("Aggiungi al Carrello? (s/n)");
//               string conferma = InputManager.LeggiStringa("Conferma: ");
//               if (conferma == "s")
//               {
//                 Console.WriteLine("Quante unità vuoi aggiungere al carrello?");
//                 int quantita = InputManager.LeggiIntero("Quantità: ");

//                 int quantitaDisponibile = prodottoTrovato.Giacenza;

//                 if (quantitaDisponibile < quantita)
//                 {
//                   Console.WriteLine("Quantita non disponibile");
//                 }
//                 else
//                 {
//                   Prodotto prodotto = new Prodotto
//                   {
//                     Id = prodottoTrovato.Id,
//                     Nome = prodottoTrovato.Nome,
//                     Prezzo = prodottoTrovato.Prezzo,
//                     Giacenza = quantita,
//                     Categoria = prodottoTrovato.Categoria
//                   };

//                   prodottoTrovato.Giacenza = quantitaDisponibile - quantita;

//                   clienteManager.AggiungiProdottoAlCarrello(prodotto);

//                   clienteRepository.SalvaCarrello(clientManager.OttieniCarrello());
//                   Console.WriteLine("Prodotto aggiunto al carrello");


//                 }
//               }
//             }
//             else
//             {
//               Console.WriteLine($"\nProdotto non trovato per ID {idProdotto}");
//             }

//             break;
//           case "3":
//             Console.WriteLine("Carrello:");
//             clientManager.VisualizzaCarrello();
//             break;
//           case "4":

//             Console.WriteLine("Rimuovi dal Carrello:");
//             int prodottoR = InputManager.LeggiIntero("\nID: ");
//             clientManager.RimuoviProdottoDalCarrello(prodottoR);
//             clienteRepository.SalvaCarrello(clientManager.OttieniCarrello());
//             Console.WriteLine("Prodotto rimosso dal carrello");

//             break;
//           case "5":
//             Console.WriteLine("Acquista:");
//             clientManager.Acquista();
//             break;
//           case "6":
//             Console.WriteLine("Storico Acquisti:");
//             clientManager.VisualizzaStoricoAcquisti();
//             break;
//           case "7":
//             isRunning = false;
//             break;
//           default:
//             Console.WriteLine("Scelta non valida. Riprova.");
//             break;
//         }
//       } while (isRunning);
//     }

//     else if ("Cassiere" == userName && "cassiere" == password)
//     {
//       Console.WriteLine("cassiere!");
//     }
//     else if (userName == "magazziniere" && password == "magazziniere")
//     {
//       Console.WriteLine("Magazziniere");
//     }
//     else
//     {
//       Console.WriteLine("Utente non riconosciuto");
//     }
//   }
// }
