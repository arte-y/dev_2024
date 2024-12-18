public class AmministratoreManager
{
    private List<Dipendente> dipendenti;
    private DipendenteRipository dipendenteRipository;

    public AmministratoreManager()
    {
        dipendenteRipository = new DipendenteRipository();
        dipendenti = new List<Dipendente>();

    }


    public void VisualizzaDipendenti()
    {
        foreach (var dipendente in dipendenti)
        {
            Console.WriteLine($"ID:{dipendente.Id} Nome:{dipendente.UserName} Ruolo:{dipendente.Ruolo}");
        }
    }

    public Dipendente TrovaDipendente(string userName)
    {
        foreach (var item in dipendenti)
        {
            if (item.UserName == userName)
            {
               return item;
            }   
        }
        return null;
    }

    public void ImpostaRuoloDipendente(string userName)
    {
        var dipendente = TrovaDipendente(userName);
        if (dipendente != null)
        {
            string ruolo = InputManager.LeggiStringa("Ruolo: ");
            dipendente.Ruolo = ruolo;
        }
    }


    
}