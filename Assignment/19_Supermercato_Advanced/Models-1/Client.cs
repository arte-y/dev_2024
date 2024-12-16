
public class ClientAdvanced : IDipendente
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
                throw new ArgumentException("Password deve essere almeno 8 caratteri e contenere almeno un numero e un carattere speciale");            }
            else
            {
                _Password = value;
            }
    

        }
    }

    public ClientAdvanced(int id)
    {
        Id = GenerateId(id);
    }

    // Generato un id Random per il cliente e anche id numero tra 111 e 999
    public int GenerateId(int Id)
    {
        Random rnd = new Random();
        return rnd.Next(111, 999);
    }


}