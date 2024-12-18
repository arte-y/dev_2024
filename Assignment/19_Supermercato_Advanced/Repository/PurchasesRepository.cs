using Newtonsoft.Json;
public class PurchasesRepository
{
  private readonly string folderPath = @"Database/Purchases";

  public void SalvaPurchases(List<Purchases> purchases)
  {
    if (!Directory.Exists(folderPath))
    {
      Directory.CreateDirectory(folderPath);
    }

    foreach (var purchase in purchases)
    {
      string filePath = $"{folderPath}/{purchase.Id}.json";
      // Serialize file
      string jsonData = JsonConvert.SerializeObject(purchase, Formatting.Indented);
      // Write
      File.WriteAllText(filePath, jsonData);
      // Console.WriteLine($"salvati {filePath}");
    }
  }

  public List<Purchases> CaricaPurchases()
  {
    List<Purchases> purchases = new List<Purchases>();

    // control
    if (Directory.Exists(folderPath))
    {
      string[] filePaths = Directory.GetFiles(folderPath, "*.json");

      foreach (var item in filePaths)
      {
        // Read fatoo
        string jsonData = File.ReadAllText(item);
        // Deserialize
        Purchases purchase = JsonConvert.DeserializeObject<Purchases>(jsonData);
        purchases.Add(purchase);
        // Console.WriteLine($" caricati {item}");
      }
      // foreach (var purchase in purchases)
      // {
      //     Console.WriteLine($"Id: {purchase.Id}, Nome: {purchase.Nome}, Prezzo: {purchase.Prezzo}, Giacenza: {purchase.Giacenza}, Categoria: {purchase.Categoria}");
      // }
    }
    else
    {
      Console.WriteLine($"Cartella {folderPath} non esiste");
    }

    return purchases;
  }

  public void RimuoviDaPurchases(int id)
  {
    string filePath = $"{folderPath}/{id}.json";
    if (File.Exists(filePath))
    {
      File.Delete(filePath);
    }
    else
    {
      Console.WriteLine("Errore: file non trovato");
    }
  }
}