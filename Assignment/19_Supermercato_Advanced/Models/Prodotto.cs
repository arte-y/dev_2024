
public class Prodotto
{
    private static int ultimoId = 0;
    private int _Id;
    private string _Nome;
    private decimal _Prezzo;
    private int _Giacenza;
    private string _Categoria;

    public Prodotto()
    {
        Id = GeneraId();
    }

    private static int GeneraId()
    {
        return ++ultimoId;

    }

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

    public string Nome
    {
        get { return _Nome; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Il valore di NomeProdotto non può essere vuoto");
            }
            _Nome = value;
        }
    }

    public decimal Prezzo
    {
        get { return _Prezzo; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Il valore di PrezzoProdotto deve essere maggiore di zero");
            }
            _Prezzo = value;

        }
    }

    public int Giacenza
    {
        get { return _Giacenza; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Il valore di GiacenzaProdotto non può essere negativo");
            }
            _Giacenza = value;
        }
    }

    public string Categoria
    {
        get { return _Categoria; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Il valore di DescrizioneProdotto non può essere vuoto");
            }
            _Categoria = value;
        }
    }

}
