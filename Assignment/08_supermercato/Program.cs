// Simulazione Supermercato


using System.Runtime.CompilerServices;

List<string> products = new List<string> {"pesto", "pasta", "verdure", "pollo", "latte", "pane", "uova", "pomodori", "patate", "insalata", "tonno", "salmone", "sardine"};

Dictionary<string, int> carrrello = new Dictionary<string, int>();

Dictionary<string, double> prezzi = new Dictionary<string, double>
{
  { "pesto", 2.5 },
  { "pasta", 1.5 },
  { "verdure", 3.5 },
  { "pollo", 5.5 },
  { "latte", 1.5 },
  { "pane", 1.0 },
  { "uova", 2.0 },
  { "pomodori", 2.5 },
  { "patate", 1.5 },
  { "insalata", 1.5 },
  { "tonno", 3.5 },
  { "salmone", 5.5 },
  { "sardine", 2.5 }
};


bool continua = true;

Console.Clear();
while (continua)
{
  Menu();
  string scelta = Console.ReadLine();

  switch (scelta) // if --
  {
    case "1":
      VisualizzaProdotti(products);
      break;
    case "2":
      CercaProdotto(products);
      break;
    case "3":
      AggiungiProdotto(products, carrrello);
      break;
    case "4":
      RimuoviProdotto(carrrello);
      break;
    case "5":
      VisualizzaCarrello(carrrello);
      break;
    case "6":
      ProcediAlPagamento(carrrello);
      continua = false;
      break;
    case "0":
      Esci();
      break;
    default:
      Console.WriteLine("Scelta non valida");
      break;
  }
}

void Menu()
{
  Console.WriteLine("\n1 Visualizza prodotti");
  Console.WriteLine("2 Cerca un prodotto");
  Console.WriteLine("3 Aggiungi prodotto");
  Console.WriteLine("4 Rimuovi prodotto");
  Console.WriteLine("5 Visualizza carrello");
  Console.WriteLine("6 procedi al pagamento");
  Console.WriteLine("0 Esci");
  Console.Write("scegli un opzione: ");
}

void VisualizzaProdotti(List<string> products)
{
  // Console.WriteLine("Prodotti disponibili:");
  // foreach (var item in products)
  // {
  //   Console.Write($"{item}, ");
  // }

  foreach (var item in prezzi)
  {
    Console.Write($"Prodotto: {item.Key} e Prezzo: {item.Value}€ ");
  }
}

void CercaProdotto(List<string> products)
{
  Console.Write("Cerca un prodotto: ");
  string risposta = Console.ReadLine().ToLower();

  if (products.Contains(risposta))
  {
    Console.WriteLine($"Prodotto trovato: {risposta}");
  }
  else
  {
    Console.WriteLine($"Prodotto non trovato {risposta}");
  }

}

void AggiungiProdotto(List<string> products, Dictionary<string, int> carrello)
{
  Console.Write("Aggiungi un prodotto: ");
  string risposta = Console.ReadLine().ToLower();
  if (products.Contains(risposta))
  {
    Console.Write("Quanti ne vuoi?: ");
    int quantita = int.Parse(Console.ReadLine());

    if (carrello.ContainsKey(risposta))
    {
      carrello[risposta] += quantita;
    }
    carrello.Add(risposta, quantita);
    Console.WriteLine($"Prodotto aggiunto {risposta} ne {quantita} al carrello");
  }
  else
  {
    Console.WriteLine($"Prodotto non trovato");
  }
}

void RimuoviProdotto(Dictionary<string, int> carrello)
{
  Console.WriteLine("Carrello Prodotto e Quantita Details:");
  foreach (var item in carrello)
  {
    Console.Write($"{item.Key}: {item.Value} ");
  }
  Console.Write("\nRimuovi un prodotto: ");
  string risposta = Console.ReadLine().ToLower();
  if (carrello.ContainsKey(risposta))
  {
    Console.Write("Quanti ne vuoi rimuovere?: ");
    int quantita = int.Parse(Console.ReadLine());

    if (carrello[risposta] > quantita)
    {
      carrello[risposta] -= quantita;
    }
    else
    {
      carrello.Remove(risposta);
      
    }
    Console.WriteLine($"Prodotto {risposta} ne {quantita} rimosso dal carrello");
  }

}

void VisualizzaCarrello(Dictionary<string, int> carrrello)
{
  Console.WriteLine("*** Prodotti nel carrello details ***");
  foreach (var item in carrrello)
  {
    prezzi.TryGetValue(item.Key, out double valore);
    Console.WriteLine($"Prodotto: {item.Key} e Prezzo unitar: {valore} € e Quantita: {item.Value } = Totale prezzo: {item.Value * valore} Euro");
  }
}

void ProcediAlPagamento(Dictionary<string, int> carrrello)
{
  Console.WriteLine("*** Pagina al pagamento ***");
  double totale = 0;
  foreach (var item in carrrello)
  {
    prezzi.TryGetValue (item.Key, out double valore);
    totale += item.Value * valore;
  }
  Console.WriteLine($"Totale prezzi: {totale} Euro");
}

void Esci()
{
  continua = false;
  Console.WriteLine("Arrivederci!");
}








