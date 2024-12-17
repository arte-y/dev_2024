using System.Security.Cryptography.X509Certificates;

class Program
{
  static void Main(string[] args)
  {
    ProdottoRepository prodottoRepository = new ProdottoRepository();
    ClienteRepository clienteRepository = new ClienteRepository();

    List<Prodotto> prodotti = prodottoRepository.CaricaProdotti();
    ProdottoManager manager = new ProdottoManager(prodotti);
    ClientManager clientManager = new ClientManager();
    List<Prodotto> carrello = new List<Prodotto>();



    Console.WriteLine("Benvenuto nel Supermercato!");


    Console.WriteLine("Log In");
    string userName = Utilities.LeggiStringa("\nUserName: ");
    string password = Utilities.LeggiStringa("\nPassword: ");

    Console.Clear();
    if (userName == "1" && password == "1")
    {
      Console.WriteLine("Admin!");
      bool continua = true;
      while (continua)
      {
        Console.WriteLine("\nMenu:");
        Console.WriteLine("1. Visualizza Prodotti");
        Console.WriteLine("2. Aggiungi Prodotto");
        Console.WriteLine("3. Trova Prodotto per ID");
        Console.WriteLine("4. Aggiorna Prodotto");
        Console.WriteLine("5. Elimina Prodotto");
        Console.WriteLine("6. Esci");

        string scelta = Utilities.LeggiIntero("\nScelta: ", 1, 6).ToString();
        // pulisco la console
        Console.Clear();

        switch (scelta)
        {
          case "1":
            Console.WriteLine("Prodotti:");
            manager.StampaProdottoIncolonnati();
            break;
          case "2":
            string nome = Utilities.LeggiStringa("\nnome: ");

            decimal prezzo = Utilities.LeggiDecimale("\nprezzo: ");

            int giacenza = Utilities.LeggiIntero("\ngiacenza: ");

            string categoria = Utilities.LeggiStringa("\nCategoria: ");

            manager.AggiungiProdotto(new Prodotto { Nome = nome, Prezzo = prezzo, Giacenza = giacenza, Categoria = categoria });

            break;
          case "3":
            int idProdotto = Utilities.LeggiIntero("\nID: ");

            Prodotto prodottoTrovato = manager.TrovaProdotto(idProdotto);
            if (prodottoTrovato != null)
            {
              Console.WriteLine($"Prodotto trovato: Id: {idProdotto}: {prodottoTrovato.Nome}");
            }
            else
            {
              Console.WriteLine($"\nProdotto non trovato per ID {idProdotto}");
            }
            break;
          case "4":
            int idProdottoAggiornare = Utilities.LeggiIntero("\nID: ");

            string nomeNuovo = Utilities.LeggiStringa("\nNome: ");

            decimal prezzoNuovo = Utilities.LeggiDecimale("\nPrezzo: ");

            int giacenzaNuovo = Utilities.LeggiIntero("\nGiacenza: ");

            string categoriaNuovo = Utilities.LeggiStringa("\nCategoria: ");

            manager.AggiornaProdotto(idProdottoAggiornare, new Prodotto { Nome = nomeNuovo, Prezzo = prezzoNuovo, Giacenza = giacenzaNuovo, Categoria = categoriaNuovo });
            break;
          case "5":

            int idProdottoEliminare = Utilities.LeggiIntero("\nID: ");

            manager.EliminaProdotto(idProdottoEliminare);
            break;
          case "6":
            prodottoRepository.SalvaProdotti(manager.OttieniProdotti());
            continua = false;
            break;
          default:
            Console.WriteLine("Scelta non valida. Riprova.");
            break;
        }
      }

    }
    else if (userName == "2" && password == "2")
    {

      Console.WriteLine("Cliente!");
      bool isRunning = true;
      do
      {
        Console.WriteLine("\nMenu:");
        Console.WriteLine("1. Visualizza Prodotti");
        Console.WriteLine("2. Cerca Prodotto e Aggiungi al Carrello");
        Console.WriteLine("3. Visualizza Carrello");
        Console.WriteLine("4. Rimuovi dal Carrello");
        Console.WriteLine("5. Acquista");
        Console.WriteLine("6. Visualizza Storico Acquisti");
        Console.WriteLine("7. Esci");

        string scelta = Utilities.LeggiIntero("\nScelta: ", 1, 7).ToString();
        Console.Clear();
        switch (scelta)
        {
          case "1":
            Console.WriteLine("Prodotti:");
            manager.StampaProdottoIncolonnati();
            break;

          case "2":
            Console.WriteLine("Cerca Prodotto e Aggiungi al Carrello:");
            int idProdotto = Utilities.LeggiIntero("\nID: ");
            Prodotto prodottoTrovato = manager.TrovaProdotto(idProdotto);
            if (prodottoTrovato != null)
            {
              Console.WriteLine($"Prodotto trovato: Id: {idProdotto}: {prodottoTrovato.Nome} Prezzo: {prodottoTrovato.Prezzo} Giacenza: {prodottoTrovato.Giacenza} Categoria: {prodottoTrovato.Categoria}");
              Console.WriteLine("Aggiungi al Carrello? (s/n)");
              string conferma = Utilities.LeggiStringa("Conferma: ");
              if (conferma == "s")
              {
                Console.WriteLine("Quante unità vuoi aggiungere al carrello?");
                int quantita = Utilities.LeggiIntero("Quantità: ");

                int quantitaDisponibile = prodottoTrovato.Giacenza;

                if (quantitaDisponibile < quantita)
                {
                  Console.WriteLine("Quantita non disponibile");
                }
                else
                {
                  Prodotto prodotto = new Prodotto
                  {
                    Id = prodottoTrovato.Id,
                    Nome = prodottoTrovato.Nome,
                    Prezzo = prodottoTrovato.Prezzo,
                    Giacenza = quantita,
                    Categoria = prodottoTrovato.Categoria
                  };

                  prodottoTrovato.Giacenza = quantitaDisponibile - quantita;

                  clientManager.AggiungiProdottoAlCarrello(prodotto);

                  clienteRepository.SalvaCarrello(clientManager.OttieniCarrello());
                  Console.WriteLine("Prodotto aggiunto al carrello");


                }
              }
            }
            else
            {
              Console.WriteLine($"\nProdotto non trovato per ID {idProdotto}");
            }

            break;
          case "3":
            Console.WriteLine("Carrello:");
            clientManager.VisualizzaCarrello();
            break;
          case "4":

            Console.WriteLine("Rimuovi dal Carrello:");
            int prodottoR = Utilities.LeggiIntero("\nID: ");
            clientManager.RimuoviProdottoDalCarrello(prodottoR);
            clienteRepository.SalvaCarrello(clientManager.OttieniCarrello());
            Console.WriteLine("Prodotto rimosso dal carrello");

            break;
          case "5":
            Console.WriteLine("Acquista:");
            clientManager.Acquista();
            break;
          case "6":
            Console.WriteLine("Storico Acquisti:");
            clientManager.VisualizzaStoricoAcquisti();
            break;
          case "7":
            isRunning = false;
            break;
          default:
            Console.WriteLine("Scelta non valida. Riprova.");
            break;
        }
      } while (isRunning);
    }

    else if ("Cassiere" == userName && "cassiere" == password)
    {
      Console.WriteLine("cassiere!");
    }
    else if (userName == "magazziniere" && password == "magazziniere")
    {
      Console.WriteLine("Magazziniere");
    }
    else
    {
      Console.WriteLine("Utente non riconosciuto");
    }
  }
}
