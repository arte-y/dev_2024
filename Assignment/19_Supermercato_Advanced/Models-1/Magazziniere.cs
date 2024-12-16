
// public class Magazziniere
// {
//     private ProdottoRepository prodottoRepository;

//     private int prossimoId;

//     private List<Prodotto> prodotti;

//     private ProdottoAdvancedManager manager;

//     public Magazziniere(List<Prodotto> prodotti)
//     {
//         this.prodotti = prodotti;
//         manager = new ProdottoAdvancedManager(prodotti);
//         prodottoRepository = new ProdottoRepository();
//         foreach (var prodotto in prodotti)
//         {
//             if (prodotto.Id >= prossimoId)
//             {
//                 prossimoId = prodotto.Id + 1;
//             }
//         }

//     }

//     public void AggiungiProdotto(Prodotto prodotto)
//     {
//         manager.AggiungiProdotto(prodotto);
//     }

//     public List<Prodotto> OttieniProdotti()
//     {
//         return prodotti;
//     }

//     public void StampaProdotto()
//     {
//         manager.StampaProdottoIncolonnati();
//     }

//     public Prodotto TrovaProdotto(int id)
//     {
//         return manager.TrovaProdotto(id);
//     }

//     public void AggiornaProdotto(int id, Prodotto nuovoProdotto)
//     {
//         manager.AggiornaProdotto(id, nuovoProdotto);
//     }

//     public void EliminaProdotto(int id)
//     {
//         manager.EliminaProdotto(id);
//     }

//     public void Run()
//     {
//         bool isRunning = true;
//         do
//         {
            
        
//         Console.WriteLine("Magazziniere");
//         Console.WriteLine("1 aggiungere un prodotto");
//         Console.WriteLine("2 visualizzare i prodotti");
//         Console.WriteLine("3 cercare un prodotto");
//         Console.WriteLine("4 aggiornare un prodotto");
//         Console.WriteLine("5 eliminare un prodotto");
//         Console.WriteLine("6 uscire");

//         int scelta = int.Parse(Console.ReadLine());

//         switch (scelta)
//         {
//             case 1:
//                 string nome = InputManager.LeggiStringa("\nnome: ");

//                 decimal prezzo = InputManager.LeggiDecimale("\nprezzo: ");

//                 int giacenza = InputManager.LeggiIntero("\ngiacenza: ");

//                 string descrizione = InputManager.LeggiStringa("\ndescrizione: ");

//                 manager.AggiungiProdotto(new Prodotto { Nome = nome, Prezzo = prezzo, Giacenza = giacenza, Categoria = descrizione });
//                 break;
//             case 2:
//                 StampaProdotto();
//                 break;
//             case 3:
//                 int idProdotto = InputManager.LeggiIntero("\nID: ");

//                 Prodotto prodottoTrovato = manager.TrovaProdotto(idProdotto);
//                 if (prodottoTrovato != null)
//                 {
//                     Console.WriteLine($"Prodotto trovato: Id: {idProdotto}: {prodottoTrovato.Nome}");
//                 }
//                 else
//                 {
//                     Console.WriteLine($"\nProdotto non trovato per ID {idProdotto}");
//                 }
//                 break;
//             case 4:
//                 int idProdottoAggiornare = InputManager.LeggiIntero("\nID: ");

//                 string nomeNuovo = InputManager.LeggiStringa("\nNome: ");

//                 decimal prezzoNuovo = InputManager.LeggiDecimale("\nPrezzo: ");

//                 int giacenzaNuovo = InputManager.LeggiIntero("\nGiacenza: ");

//                 string descrizioneNuovo = InputManager.LeggiStringa("\nDescrizione: ");

//                 manager.AggiornaProdotto(idProdottoAggiornare, new Prodotto { Nome = nomeNuovo, Prezzo = prezzoNuovo, Giacenza = giacenzaNuovo, Categoria = descrizioneNuovo });
//                 break;
//             case 5:

//                 int idProdottoEliminare = InputManager.LeggiIntero("\nID: ");

//                 manager.EliminaProdotto(idProdottoEliminare);
//                 break;
//             case 6:
//                 Console.WriteLine("Arrivederci");
//                 prodottoRepository.SalvaProdotti(manager.OttieniProdotti());
//                 isRunning = false;
//                 break;
//             default:
//                 Console.WriteLine("Scelta non valida");
//                 break;

//         }
//         } while (true);
//     }
// }
