
public class ProdottoAdvanced
{

    private int _id;
    private string _nomeProdotto;
    private decimal _prezzoProdotto;
    private int _giacenzaProdotto;
    private string _descrizioneProdotto;

    public int Id
    {
        get { return _id; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Il valore di Id deve essere maggiore di zero");
            }
            _id = value;
        }
    }

    public string NomeProdotto
    {
        get { return _nomeProdotto; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Il valore di NomeProdotto non può essere vuoto");
            }
            _nomeProdotto = value;
        }
    }

    public decimal PrezzoProdotto
    {
        get { return _prezzoProdotto; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Il valore di PrezzoProdotto deve essere maggiore di zero");
            }
            _prezzoProdotto = value;
        }
    }

    public int GiacenzaProdotto
    {
        get { return _giacenzaProdotto; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Il valore di GiacenzaProdotto non può essere negativo");
            }
            _giacenzaProdotto = value;
        }
    }

    public string DescrizioneProdotto
    {
        get { return _descrizioneProdotto; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Il valore di DescrizioneProdotto non può essere vuoto");
            }
            _descrizioneProdotto = value;
        }
    }
}

