using Newtonsoft.Json;
public class Repository
{

    private readonly string folderPath = "Data";

    public void SalvaProdotti(List<Prodotto> prodotti)
    {
        if (!Directory.Exists(folderPath))
        {
            Directory.CreateDirectory(folderPath);
        }

        foreach (var prodotto in prodotti)
        {
            string filePath = Path.Combine(folderPath, $"Prodotto{prodotto.Id}.json");
            // Serialize fle
            string jsonData = JsonConvert.SerializeObject(prodotto, Formatting.Indented);
            // scrivo
            File.WriteAllText(filePath, jsonData);
            Console.WriteLine($"salvati {filePath}");
        }
    }

    public List<Prodotto> CaricaProdotti()
    {
        List<Prodotto> prodotti = new List<Prodotto>();

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
                prodotti.Add(prodotto);
                Console.WriteLine($" caricati {item}");
            }
            foreach (var prodotto in prodotti)
            {
                Console.WriteLine($"Id: {prodotto.Id}, Nome: {prodotto.Nome}, Prezzo: {prodotto.Prezzo}, Giacenza: {prodotto.Giacenza}, Categoria: {prodotto.Categoria}");
            }
        }
        else
        {
            Console.WriteLine($"Cartell {folderPath} non esiste");
        }

        return prodotti;
    }

}
