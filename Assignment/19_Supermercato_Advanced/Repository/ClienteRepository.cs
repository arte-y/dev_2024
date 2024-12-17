using Newtonsoft.Json;
public class ClienteRepository
{
    private readonly string folderPath = @"Database/Carrello";

    public void SalvaCarrello(List<Prodotto> carrello)
    {
        if (!Directory.Exists(folderPath))
        {
            Directory.CreateDirectory(folderPath);
        }

        foreach (var prodotto in carrello)
        {
            string filePath = $"{folderPath}/{prodotto.Id}.json";
            // Serialize file
            string jsonData = JsonConvert.SerializeObject(prodotto, Formatting.Indented);
            // Write
            File.WriteAllText(filePath, jsonData);
            // Console.WriteLine($"salvati {filePath}");
        }
    }

    public List<Prodotto> CaricaCarrello()
    {
        List<Prodotto> carrello = new List<Prodotto>();

        // control
        if (Directory.Exists(folderPath))
        {
            string[] filePaths = Directory.GetFiles(folderPath, "*.json");

            foreach (var item in filePaths)
            {
                // Read fatoo
                string jsonData = File.ReadAllText(item);
                // Deserialize
                Prodotto prodotto = JsonConvert.DeserializeObject<Prodotto>(jsonData);
                carrello.Add(prodotto);
                // Console.WriteLine($" caricati {item}");
            }
            // foreach (var prodotto in carrello)
            // {
            //     Console.WriteLine($"Id: {prodotto.Id}, Nome: {prodotto.Nome}, Prezzo: {prodotto.Prezzo}, Giacenza: {prodotto.Giacenza}, Categoria: {prodotto.Categoria}");
            // }
        }
        else
        {
            Console.WriteLine($"Cartella {folderPath} non esiste");
        }

        return carrello;
    }

    public void RimuoviProdottoDaCarrello(int id)
    {
        string filePath = $"{folderPath}/{id}.json";
        if (File.Exists(filePath))
        {
            File.Delete(filePath);
            Console.WriteLine($"Prodotto con id {id} rimosso");
        }
        else
        {
            Console.WriteLine($"Prodotto con id {id} non trovato");
        }
    }

}
