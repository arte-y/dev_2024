public class Cassa
{
    private int _Id;
    private Dipendente _dipendente;
    private List<Purchases> _Acquisti;
    private bool _ScontrinoProcessato;

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
    public Dipendente dipendente { 
        get{
            return dipendente;
        } 
        set{
            dipendente = value;} 
        }
    public List<Purchases> Acquisti
    {
        get
        {
            return _Acquisti;
        }
        set
        {
            _Acquisti = value;
        }
    }
    public bool ScontrinoProcessato
    {
        get
        {
            return _ScontrinoProcessato;
        }
        set
        {
            _ScontrinoProcessato = value;
        }
    }
}