using System.Security.Cryptography.X509Certificates;

class Program
{
  static void Main(string[] args)
  {
    Repository repository = new Repository();
    List<Prodotto> prodotti = repository.CaricaProdotti();
    ProdottoManager manager = new ProdottoManager(prodotti);


    ClientManager clientManager = new ClientManager();


    Console.WriteLine("Benvenuto nel Supermercato!");


    Console.WriteLine("Log In");
    string userName = Utilities.LeggiStringa("\nUserName: ");
    string password = Utilities.LeggiStringa("\nPassword: ");

    Console.Clear();
    if (userName == "admin" && password == "admin")
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
            repository.SalvaProdotti(manager.OttieniProdotti());
            continua = false;
            break;
          default:
            Console.WriteLine("Scelta non valida. Riprova.");
            break;
        }
      }

    }
    else if (userName == "cliente" && password == "cliente")
    {
      List<Prodotto> carrello = new List<Prodotto>();

      List<Purchases> storicoAcquisti = new List<Purchases>();

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
            string nomeProdotto = Utilities.LeggiStringa("\nNome Prodotto: ");
            Prodotto prodottoTrovato = manager.TrovaProdotto(nomeProdotto);
            if (prodottoTrovato != null)
            {
              Console.WriteLine($"Prodotto trovato: {nomeProdotto}");
              Console.WriteLine("Vuoi aggiungerlo al carrello? (s/n)");

              string conferma = Console.ReadLine();
              if (conferma == "s")
              {
                Console.WriteLine("Aggiungi al Carrello:");
                if (clientManager.TrovaProdotto(nomeProdotto) != null)
                {
                  string nome = Utilities.LeggiStringa("\nnome: ");

                  decimal prezzo = Utilities.LeggiDecimale("\nprezzo: ");

                  int giacenza = Utilities.LeggiIntero("\ngiacenza: ");

                  string categoria = Utilities.LeggiStringa("\nCategoria: ");

                  clientManager.AggiungiProdottoAlCarrello(new Prodotto { Nome = nome, Prezzo = prezzo, Giacenza = giacenza, Categoria = categoria });

                }
                else
                {
                  Console.WriteLine("Prodotto non trovato");
                }
              }

            }
            else
            {
              Console.WriteLine("Prodotto non trovato");
            }

            break;
          case "3":
            Console.WriteLine("Carrello:");
            clientManager.VisualizzaCarrello();
            break;
          case "4":
            Console.WriteLine("Rimuovi dal Carrello:");
            string rimuoveC = Utilities.LeggiStringa("\nNome Prodotto: ");
            clientManager.RimuoviProdottoDalCarrello(rimuoveC);
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
