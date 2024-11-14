
int punteggioUtente = 100;
int punteggioComputer = 100;

bool continua = true;
Random rnd = new Random();

Console.WriteLine("Insersci il tuo nome");
string nome = Console.ReadLine();
do
{
  int utenteDado = UtenteLanciaDado();

  int computerDado = ComputerLanciaDado();

  int differenza = Math.Abs(utenteDado - computerDado);


  ControloVittoria(utenteDado, computerDado, differenza);
  ControloFineGioco();

  GiocoDiNuovo();
} while (continua);

Console.WriteLine("Fine del gioco, arriverderci!");


#region Funzioni

int UtenteLanciaDado()
{
  int utenteDado = rnd.Next(1, 7);

  Console.WriteLine($"Sig:{nome} tocca un tasto per lanciare il dado");
  Console.ReadKey(true);
  Thread.Sleep(500);
  Console.WriteLine($"Il tuo dado: {utenteDado}");
  return utenteDado;
}

int ComputerLanciaDado()
{
  int computerDado = rnd.Next(1, 7);
  Console.WriteLine("Computer lancia il dado");
  Thread.Sleep(500);
  Console.WriteLine($"Il dado del computer: {computerDado}");
  return computerDado;
}

void ControloVittoria(int utenteDado, int computerDado, int differenza)
{
  if (utenteDado > computerDado)
  {
    punteggioUtente += 10 + differenza;
    punteggioComputer -= 10 + differenza;
    Console.WriteLine("Utente ha vinto!");
  }
  else if (utenteDado < computerDado)
  {
    punteggioUtente -= 10 + differenza;
    punteggioComputer += 10 + differenza;
    Console.WriteLine("Il computer ha vinto");
  }
  else
  {
    Console.WriteLine("Uguale!");
  }
  Console.WriteLine($"Punteggio Utente: {punteggioUtente}");
  Console.WriteLine($"Punteggio Computer: {punteggioComputer}");
}

void ControloFineGioco()
{
  if (punteggioUtente <= 0)
  {
    Console.WriteLine("Il computer ha vinto il gioco");
    continua = false;
  }
  else if (punteggioComputer <= 0)
  {
    Console.WriteLine("L'utente ha vinto il gioco");
    continua = false;
  }
}

void GiocoDiNuovo()
{
  Console.WriteLine("Vuole giocare ancora? (s/n)");
  string risposta = Console.ReadLine().ToLower();
  if (risposta == "s")
  {
    Console.WriteLine("continua il gioco");
  }
  else
  {
    Console.WriteLine("Esce dal gioco ...");
    continua = false;
  }
}

#endregion
