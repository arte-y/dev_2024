
public class Ruolo
{
    public const string Magazziniere = "Magazziniere";
    public const string Amministratore = "Amministratore";
    public const string Cassiere = "Cassiere";
    public const string Cliente = "Cliente";

    // Magazziniere: puo visualizzare aggiungere modificare o rimuovere prodotti dal magazzino e può gestire le categorie.
    public static bool IsMagazziniere(string ruole) => ruole == Magazziniere;

    //Amministratore: puo visualizzare ed impostare il ruolo dei dipendenti.
    public static bool IsAmministratore(string ruole) => ruole == Amministratore;

    //Cassiere: puo registrare i prodotti acquistati da un cliente che ha degli acquisti in stato completato e calcolare il totale da pagare generando lo scontrino,e può ricaricare il credito del cliente quando è finito.
    public static bool IsCassiere(string ruole) => ruole == Cassiere;
    
    // Cliente: Può aggiungere o rimuovere prodotti e cambiare lo stato dell ordine
    public static bool IsCliente(string ruole) => ruole == Cliente;
    
}