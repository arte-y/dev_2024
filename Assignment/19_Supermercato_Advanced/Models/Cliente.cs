public class Cliente
{
    private int _Id;
    private string _UserName;
    private List<Prodotto> _Carrello;
    private List<Purchases> _StoricoAcquisti;
    private int _PercantualeSconto;
    private double _Credito;

    public int Id
    {
        get { return _Id; }
        set
        {
            _Id = value;
        }
    }
    public string UserName
    {
        get { return _UserName; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Il valore di UserName non può essere vuoto");
            }

            _UserName = value;

        }
    }
    public List<Prodotto> Carrello
    {
        get
        {
            return _Carrello;
        }
        set
        {
            _Carrello = value;
        }
    }
    public List<Purchases> StoricoAcquisti
    {
        get
        {
            return _StoricoAcquisti;
        }
        set
        {
            _StoricoAcquisti = value;
        }
    }
    public int PercantualeSconto
    {
        get { return _PercantualeSconto; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Il valore di PercantualeSconto deve essere maggiore di zero");
            }
            _PercantualeSconto = value;
        }
    }
    public double Credito
    {
        get { return _Credito; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Il valore di Credito deve essere maggiore di zero");
            }

            _Credito = value;
        }
    }
}