Console.Clear();
Random random = new Random();
int numeroDaIndovinare = 0;
int punteggio = 100;
bool haIndovinato = false;
int tentativi = 0;
int numeroUtente = 0;

Dictionary<string, List<int>> tentativiUtenti = new Dictionary<string, List<int>>(); // Dizinin tanımlanması
string risposta = "s";
string nomeUtente = "";  // Kullanıcının adı soyadı

do
{
  // sklfjsdkgfjsldngskdg Tamer
  // İlk olarak isim ve soyisim alınır
  Console.WriteLine("Inserisci il tuo nome e cognome:");
  nomeUtente = Console.ReadLine();

  string[] nomeSplit = nomeUtente.Split(' ');
  string nomeUtente1 = nomeSplit[0];
  string cognomeUtente = nomeSplit.Length > 1 ? nomeSplit[1] : "Non Specificato";

  Console.Clear();

  int scelta = 0;
  do
  {
    Menudifficolta();

    bool successoLivelloDifficolta = int.TryParse(Console.ReadLine(), out scelta);

    // Pulizia della console
    Console.Clear();

    if (!successoLivelloDifficolta || scelta < 1 || scelta > 3)
    {
      Console.WriteLine("Scelta non valida.");
    }

  } while (scelta < 1 || scelta > 3);

  switch (scelta)
  {
    case 1:
      SceltaUno();
      break;
    case 2:
      SceltaDue();
      break;
    case 3:
      SceltaTre();
      break;
    default:
      Console.WriteLine("Scelta non valida.");
      break;
  }

  Console.WriteLine($"secret number {numeroDaIndovinare}");


  NomeIndovinaTentativo(nomeUtente1, cognomeUtente);

  StampaIndovinato();

  StampaTentativiUtenti();

  GiocareDiNuovo();

  GiocareDiNuovoRisposta();

  haIndovinato = false;
  
  CreaTxt(nomeUtente1);

} while (risposta == "s" || risposta == "S");





#region funzioni

void Menudifficolta()
{
  Console.WriteLine("Scegli il livello di difficolta':");
  Console.WriteLine("1. Facile (1-50, 10 tentativi)");
  Console.WriteLine("2. Medio (1-100, 7 tentativi)");
  Console.WriteLine("3. Difficile (1-200, 5 tentativi)");
}

void SceltaUno()
{
  numeroDaIndovinare = random.Next(1, 51);
  tentativi = 10;
}

void SceltaDue()
{
  numeroDaIndovinare = random.Next(1, 101);
  tentativi = 7;
}

void SceltaTre()
{
  numeroDaIndovinare = random.Next(1, 201);
  tentativi = 5;
}

void NomeIndovinaTentativo(string nomeUtente1, string cognomeUtente)
{

  Console.WriteLine($"Punteggio massimo: {punteggio} punti.");

  while (!haIndovinato && tentativi > 0)
  {
    if (numeroUtente == numeroDaIndovinare)
    {
      Console.WriteLine($"Ciao {nomeUtente1} {cognomeUtente}, indovina il numero!");
      haIndovinato = true;
    }
    else
    {
            tentativi--;
      punteggio = Math.Max(punteggio - 10, 0);
      Console.Write("Tentativo: ");
      bool successo = int.TryParse(Console.ReadLine(), out numeroUtente);
      Console.Clear();


      if (!successo)
      {
        Console.WriteLine("Inserisci un numero valido.");
        continue;
      }
      else
      {
        // Controllo se il numero è già stato inserito
        if (tentativiUtenti.ContainsKey(nomeUtente1) && tentativiUtenti[nomeUtente1].Contains(numeroUtente))
        {
          Console.WriteLine("Numero già inserito. Riprova.");
          continue;
        }
      }



      // Aggiungi il tentativo alla lista degli utenti
      if (!tentativiUtenti.ContainsKey(nomeUtente1))
      {
        tentativiUtenti.Add(nomeUtente1, new List<int>());
      }

      tentativiUtenti[nomeUtente1].Add(numeroUtente);

      if (numeroUtente < numeroDaIndovinare)
      {
        Console.WriteLine("Il numero da indovinare e' maggiore.");
      }
      else if (numeroUtente > numeroDaIndovinare)
      {
        Console.WriteLine("Il numero da indovinare e' minore.");
      }
    }

    if (!haIndovinato && tentativi == 0)
    {
      Console.WriteLine($"Hai esaurito i tentativi. Il numero era {numeroDaIndovinare}.");
    }
  }
}

void StampaIndovinato()
{
  if (haIndovinato)
  {
    Console.WriteLine($"Hai indovinato numero: {numeroDaIndovinare} e Punteggio: {punteggio}");
  }
}

void StampaTentativiUtenti()
{
  Console.WriteLine("Tentativi effettuati:");

  foreach (var tentativoUtente in tentativiUtenti)
  {
    Console.WriteLine($"Sig: {tentativoUtente.Key}: {string.Join(", ", tentativoUtente.Value)}");
  }
}

void GiocareDiNuovo()
{
  Console.WriteLine("Vuoi giocare di nuovo? (s/n)");
  risposta = Console.ReadLine();
  Console.Clear();
}

void GiocareDiNuovoRisposta()
{
  while (risposta != "s" && risposta != "S" && risposta != "n" && risposta != "N")
  {
    Console.WriteLine("Risposta non valida. Vuoi giocare di nuovo? (s/n)");
    risposta = Console.ReadLine();
    Console.Clear();
  }
}


void CreaTxt ( string nomeUtente1)
{
string path = @$"{nomeUtente1} {DateTime.Now.ToString("dd-MM-yyyy")}.txt";
if (!File.Exists(path))
{
    File.Create(path).Close();
}
else
{
    Console.WriteLine("Il file esiste già");
}

foreach (var tentativoUtente in tentativiUtenti)
{
    File.AppendAllText(path, $"Sig./ra {tentativoUtente.Key}: {string.Join(", ", tentativoUtente.Value)}\n");
}

Console.WriteLine("Tentativi salvati su file.");

}

#endregion