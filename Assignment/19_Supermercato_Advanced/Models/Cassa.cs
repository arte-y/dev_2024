
public class Cassa
{
    public int Id { get; set; }

    public Dipendente dipendente { get; set; }

    public List<Purchases> StoricoAcquisti { get; set; }

    public bool Processato { get; set; }


}
