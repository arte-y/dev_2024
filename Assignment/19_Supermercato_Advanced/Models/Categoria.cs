public class Categoria
{
    private int _Id;
    private string _Nome;

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
        get{
            return _Nome;
        }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Il valore di Nome non può essere vuoto");
            }
            _Nome = value;
        }
    }

}