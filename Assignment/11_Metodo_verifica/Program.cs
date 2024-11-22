
Intero();
Decimale();
Stringa();
Overflow();
Charr();


//***********************

void Intero()
{
  bool isIntero;
  do
  {
    isIntero=false;
    try
    {
      Console.WriteLine("Inserisci un numero: Intero ");
      int risposta1 = int.Parse(Console.ReadLine());
      if (risposta1 == ' ')
      {
        throw new NullReferenceException();
      }
    }
    catch (FormatException)
    {
      Console.WriteLine("Errore: Inserire un numero intero");
      isIntero = true;
    }
    catch (OverflowException)
    {
      Console.WriteLine("Errore: Il numero è troppo grande");
      isIntero = true;
    }
    catch (NullReferenceException)
    {
      Console.WriteLine("Errore: Inserire un numero intero perhce vuoto");
      isIntero = true;
    }
    catch (Exception)
    {
      Console.WriteLine("Errore: Generale");
      isIntero = true;
    }


  } while (isIntero);

}

void Decimale()
{
  bool isDecimale;
  
  do
  
  {
      isDecimale =false;
    try
    {
      Console.WriteLine("Inserisci un numero: Decimale ");
      decimal risposta2 = decimal.Parse(Console.ReadLine());
      if (risposta2.ToString() == " ")
      {
        throw new NullReferenceException();
      }
    }
    catch (FormatException)
    {
      Console.WriteLine("Errore: Inserire un numero decimale");
      isDecimale = true;
    }
    catch (NullReferenceException)
    {
      Console.WriteLine("Errore: Inserire un numero decimale perhce vuoto");
      isDecimale = true;
    }
    catch (OverflowException)
    {
      Console.WriteLine("Errore: Il numero è troppo grande");
      isDecimale = true;
    }
    catch (Exception)
    {
      Console.WriteLine("Errore: Generale");
      isDecimale = true;
    }
   
  } while (isDecimale);

}

void Stringa()
{
  bool isStringa;
  do
  {
    isStringa =false;
    try
    {
      Console.WriteLine("Inserisci una stringa: Stringa ");
      string risposta3 = Console.ReadLine();
      if (risposta3 == " ")
      {
        throw new NullReferenceException("vuoto");
      }
    }
    catch (NullReferenceException)
    {
      Console.WriteLine("Errore: Vuoto Inserire una stringa");
      isStringa = true;
    }
    catch (FormatException)
    {
      Console.WriteLine("Errore: Inserire una stringa");
      isStringa = true;
    }
    catch (Exception)
    {
      Console.WriteLine("Errore: Generale");
      isStringa = true;
    }
  
  } while (isStringa);

}

void Overflow()
{
   bool isStringa;
  do
  {
    isStringa = false;
    try
    {
      Console.WriteLine("Inserisci un numero: Overflow ");
      int risposta4 = int.Parse(Console.ReadLine());
    }
    catch (OverflowException)
    {
      Console.WriteLine("Errore: Il numero è troppo grande");
      isStringa = true;
    }
    catch (FormatException)
    {
      Console.WriteLine("Errore: Inserire un numero intero");
      isStringa = true;
    }

    catch (Exception)
    {
      Console.WriteLine("Errore: Generale");
      isStringa = true;
    }
  } while (isStringa);

}

void Charr()
{
  Console.WriteLine("una cosa vuota: Char ");
  char risposta5 = char.Parse(Console.ReadLine());
  if (risposta5 == ' ')
  {
    throw new NullReferenceException();
  }
}