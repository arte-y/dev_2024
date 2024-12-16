
public class Purchases
{
    public int Id { get; set; }
    public Cliente Cliente { get; set; }
    public Prodotto Prodotto { get; set; }
    public int Quantita { get; set; }
    public DateTime DataAcquisto { get; set; }
    public bool Stato { get; set; }

}
