public class Dipendente
{
    private int _Id;
    private string _UserName;
    private string _Ruolo;
    
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
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Il valore di UserName non può essere vuoto");
            }
            _UserName = value;
        }
    }
    public string Ruolo
    {
        get
        {
            return _Ruolo;
        }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Il valore di Ruolo non può essere vuoto");
            }
            _Ruolo = value;
        }
    }
}