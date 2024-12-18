public class Purchases
{
    private int _Id;
    private Cliente _Cliente;
    private List<Prodotto> _Prodotti;
    private int _Quantita;
    private DateTime _DataAcquisto;
    private bool _Stato;

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
    public Cliente Cliente
    {
        get
        {
            return _Cliente;
        }
        set
        {
            _Cliente = value;
        }
    }
    public List<Prodotto> Prodotti
    {
        get
        {
            return _Prodotti;
        }
        set
        {
            _Prodotti = value;
        }
    }
    public int Quantita
    {
        get
        {
            return _Quantita;
        }
        set
        {
            _Quantita = value;
        }
    }
    public DateTime DataAcquisto
    {
        get
        {
            return _DataAcquisto;
        }
        set
        {
            _DataAcquisto = value;
        }
    }
    public bool Stato
    {
        get
        {
            return _Stato;
        }
        set
        {
            _Stato = value;
        }
    }
}