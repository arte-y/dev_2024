
public class Cliente
{
    public int Id { get; set; }
    public string UserName { get; set; }

    public List<Prodotto> Carrello { get; set; }
    // public List<Purchases> StoricoAcquisti { get; set; }
    public int PercentualeSconto { get; set; }
}
