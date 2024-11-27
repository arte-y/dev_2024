List<Dictionary<string, string>> rubrica = new List<Dictionary<string, string>>();

bool isTrue = true;

Console.Clear();
while (true)
{
  Console.WriteLine("\n--- Rubrica ---");
  Console.WriteLine("1. Aggiungi un contatto");
  Console.WriteLine("2. Visualizza tutti i contatti");
  Console.WriteLine("3. Cerca un contatto per nome");
  Console.WriteLine("4. Modifica un contatto per nome");
  Console.WriteLine("5. Cancella un contatto per nome");
  Console.WriteLine("6. Esci");
  Console.Write("Scegli un'opzione: ");
  string scelta = Console.ReadLine();

  if (scelta == "1")
    AggiungiContatto();
  else if (scelta == "2")
    VisualizzaContatti();
  else if (scelta == "3")
    CercaContatto();
  else if (scelta == "4")
    ModificaContatto();
  else if (scelta == "5")
    CancellaContatto();
  else if (scelta == "6")
    break;
  else
    Console.WriteLine("Opzione non valida. Riprova.");
}

void AggiungiContatto()
{
  Dictionary<string, string> contatto = new Dictionary<string, string>();

  Console.Write("Inserisci il nome: ");
  contatto["nome"] = Console.ReadLine();

  Console.Write("Inserisci il cognome: ");
  contatto["cognome"] = Console.ReadLine();

  Console.Write("Inserisci l'indirizzo: ");
  contatto["indirizzo"] = Console.ReadLine();

  Console.Write("Inserisci il numero di telefono: ");
  contatto["numero_telefono"] = Console.ReadLine();

  rubrica.Add(contatto);
  Console.WriteLine("Contatto aggiunto con successo!");
}

void VisualizzaContatti()
{
  if (rubrica.Count == 0)
  {
    Console.WriteLine("La rubrica è vuota.");
  }
  else
  {
    Console.WriteLine("\n--- Contatti ---");
    for (int i = 0; i < rubrica.Count; i++)
    {
      var contatto = rubrica[i];
      Console.WriteLine($"Nome: {contatto["nome"]}, Cognome: {contatto["cognome"]}, Indirizzo: {contatto["indirizzo"]}, Numero di Telefono: {contatto["numero_telefono"]}");
    }
  }
}

void CercaContatto()
{
  Console.Write("Inserisci il nome da cercare: ");
  string nome = Console.ReadLine().ToLower(); // Küçük harfe çeviriyoruz
  bool trovato = false;

  for (int i = 0; i < rubrica.Count; i++)
  {
    if (rubrica[i]["nome"].ToLower() == nome) // Karşılaştırmayı küçük harflerle yapıyoruz
    {
      var contatto = rubrica[i];
      Console.WriteLine($"Nome: {contatto["nome"]}, Cognome: {contatto["cognome"]}, Indirizzo: {contatto["indirizzo"]}, Numero di Telefono: {contatto["numero_telefono"]}");
      trovato = true;
    }
  }

  if (!trovato)
  {
    Console.WriteLine("Nessun contatto trovato.");
  }
}

void ModificaContatto()
{
  Console.Write("Inserisci il nome del contatto da modificare: ");
  string nome = Console.ReadLine().ToLower();
  bool trovato = false;

  for (int i = 0; i < rubrica.Count; i++)
  {
    if (rubrica[i]["nome"].ToLower() == nome)
    {
      var contatto = rubrica[i];
      Console.WriteLine("Insserici il nuovo nome (lascia vuoto per non modificare): ");
      string nuovoNome = Console.ReadLine();
      if (!string.IsNullOrWhiteSpace(nuovoNome))
        contatto["nome"] = nuovoNome;

      Console.Write("Inserisci il nuovo cognome (lascia vuoto per non modificare): ");
      string nuovoCognome = Console.ReadLine();
      if (!string.IsNullOrWhiteSpace(nuovoCognome))
        contatto["cognome"] = nuovoCognome;

      Console.Write("Inserisci il nuovo indirizzo (lascia vuoto per non modificare): ");
      string nuovoIndirizzo = Console.ReadLine();
      if (!string.IsNullOrWhiteSpace(nuovoIndirizzo))
        contatto["indirizzo"] = nuovoIndirizzo;

      Console.Write("Inserisci il nuovo numero di telefono (lascia vuoto per non modificare): ");
      string nuovoTelefono = Console.ReadLine();
      if (!string.IsNullOrWhiteSpace(nuovoTelefono))
        contatto["numero_telefono"] = nuovoTelefono;

      Console.WriteLine("Contatto modificato con successo!");
      trovato = true;
      break;
    }
  }

  if (!trovato)
  {
    Console.WriteLine("Contatto non trovato.");
  }
}

void CancellaContatto()
{
  Console.Write("Inserisci il nome del contatto da cancellare: ");
  string nome = Console.ReadLine().ToLower();
  bool trovato = false;

  for (int i = 0; i < rubrica.Count; i++)
  {
    if (rubrica[i]["nome"].ToLower() == nome)
    {
      rubrica.RemoveAt(i);
      Console.WriteLine("Contatto cancellato con successo!");
      trovato = true;
      break;
    }
  }

  if (!trovato)
  {
    Console.WriteLine("Contatto non trovato.");
  }
}
