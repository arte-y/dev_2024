
public class Amministratore : IDipendente
{
    private int _Id { get; set; }
    private string _UserName { get; set; }
    private string _Password { get; set; }

    public int Id
    {
        get
        {
            return _Id;
        }
        set
        {
            _Id = value;
        }
    }
    public string UserName
    {
        get
        {
            return _UserName;
        }

        set
        {
            if (value.Length < 5)
            {
                throw new ArgumentException("Username almeno 5 caratteri");
            }
            else
            {
                _UserName = value;
            }
        }
    }
    public string Password
    {
        get
        {
            return _Password;
        }
        set
        {
            // password deve essere almeno 8 caratteri e contenere almeno un numero e un carattere speciale

            if (value.Length < 8 && !value.Any(char.IsDigit) && !value.Any(char.IsSymbol))
            {
                throw new ArgumentException("Password deve essere almeno 8 caratteri e contenere almeno un numero e un carattere speciale");
            }
            else
            {
                _Password = value;
            }


        }
    }

    public Amministratore(int id)
    {
        Id = GenerateId(id);
    }

    // Generato un id random per il amministratore e anche id numero tra 1 e 32
    public int GenerateId(int Id)
    {
        Random rnd = new Random();
        return rnd.Next(1, 32);
    }


}