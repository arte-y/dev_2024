Dictionary<string, string> Rubrica = new Dictionary<string, string>();

string contatto = string.Empty;

bool isRisposta = false;

Console.Clear();
do
{

  Console.WriteLine("Quale operazione vuole fare?");
  Console.WriteLine("1. Aggiungi contatto");
  Console.WriteLine("2. Cerca contatto");
  Console.WriteLine("3. Elimina contatto");
  Console.WriteLine("4. Modifica contatto");
  Console.WriteLine("5. Visualizza rubrica");
  Console.WriteLine("6. Esci");

  int scelta = Convert.ToInt32(Console.ReadLine());

  switch (scelta)
  {
    case 1:
      AggiungeContatto();
      break;
    case 2:
      CercaContatto();
      break;
    case 3:
      EleminaContatto();
      break;
    case 4:
      ModificaContatto();
      break;
    case 5:
      VisualizzaRubrica();
      break;
    case 6:
      break;
    default:
      Console.WriteLine("Scelta non valida");
      break;
  }

  Console.WriteLine("Vuoi fare un'altra operazione? (s/n)");
  string risposta = Console.ReadLine().ToLower();
  if (risposta == "s")
  {
    Console.Clear();
  }
  else
  {
    isRisposta = true;
  }
} while (!isRisposta);




#region funzioni

void AggiungeContatto()
{
  Console.WriteLine("Aggiungi un contatto nuovo");

  Console.Write("Inserisci un contatto Nome: ");
  string nome = Console.ReadLine();

  Console.Write("Inserisci un contatto Cognome: ");
  string cognome = Console.ReadLine();

  Console.Write("Inserisci un l'indirizzo del contatto: ");
  string via = Console.ReadLine();


  Console.Write("Inserisci un contatto Numero: ");
  string numero = Console.ReadLine();

  Console.WriteLine("Contatto aggiunto con successo");
  string contatto = $"Nome: {nome} Cognome: {cognome} L'indirizzo: {via} NumeroTel:{numero}";
  Console.WriteLine(contatto);
  Rubrica.Add(nome , contatto);
}

void VisualizzaRubrica()
{
  Console.WriteLine("Rubrica:");
  foreach (var contatto in Rubrica)
  {
    Console.WriteLine(contatto.Key + " " + contatto.Value);
  }

}

void CercaContatto()
{
  Console.WriteLine("Inserisci un contatto da cercare: ");
  string contattoCercato = Console.ReadLine().ToLower();

  if (Rubrica.ContainsKey(contattoCercato.ToLower()))
  {
    Console.WriteLine("Il contatto è presente nella rubrica");
    Console.WriteLine(Rubrica[contattoCercato]);
  }
  else
  {
    Console.WriteLine("Il contatto non è presente nella rubrica");
  }
}

void ModificaContatto()
{
  Console.WriteLine("Inserisci un contatto da modificare: ");
  string contattoModificato = Console.ReadLine();
  if (Rubrica.ContainsKey(contattoModificato))
  {
    Rubrica.Remove(contattoModificato);

    Console.WriteLine("Inserisci il nuovo contatto: ");
    string nuovoContatto = Console.ReadLine();
    
    Rubrica.Add(nuovoContatto,contatto);
    Console.WriteLine("Il contatto è stato modificato");
  }
  else
  {
    Console.WriteLine("Il contatto non è presente nella rubrica");
  }
}

void EleminaContatto()
{
  Console.WriteLine("Inserisci un contatto da eliminare: ");
  string contattoEliminato = Console.ReadLine();
  if (Rubrica.ContainsKey(contattoEliminato))
  {
    Rubrica.Remove(contattoEliminato);
    Console.WriteLine("Il contatto è stato eliminato");
  }
  else
  {
    Console.WriteLine("Il contatto non è presente nella rubrica");
  }
}

#endregion




















