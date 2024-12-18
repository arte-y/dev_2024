using Newtonsoft.Json;
public class CassaRepository
{
  private readonly string folderPath = @"Database/Cassa";
  
  public void SalvaCassa(List<Cassa> cassa)
  {
    if (!Directory.Exists(folderPath))
    {
      Directory.CreateDirectory(folderPath);
    }

    foreach (var cas in cassa)
    {
      string filePath = $"{folderPath}/{cas.Id}.json";
      // Serialize file
      string jsonData = JsonConvert.SerializeObject(cas, Formatting.Indented);
      // Write
      File.WriteAllText(filePath, jsonData);
      // Console.WriteLine($"salvati {filePath}");
    }
  }

  public List<Cassa> CaricaCassa()
  {
    List<Cassa> cassa = new List<Cassa>();

    // control
    if (Directory.Exists(folderPath))
    {
      string[] filePaths = Directory.GetFiles(folderPath, "*.json");

      foreach (var item in filePaths)
      {
        // Read fatoo
        string jsonData = File.ReadAllText(item);
        // Deserialize
        Cassa cas = JsonConvert.DeserializeObject<Cassa>(jsonData);
        cassa.Add(cas);
        // Console.WriteLine($" caricati {item}");
      }
      // foreach (var cas in cassa)
      // {
      //     Console.WriteLine($"Id: {cas.Id}, Nome: {cas.Nome}, Prezzo: {cas.Prezzo}, Giacenza: {cas.Giacenza}, Categoria: {cas.Categoria}");
      // }
    }
    else
    {
      Console.WriteLine($"Cartella {folderPath} non esiste");
    }

    return cassa;
  }

  public void RimuoviDaCassa(int id)
  {
    string filePath = $"{folderPath}/{id}.json";
    if (File.Exists(filePath))
    {
      File.Delete(filePath);
    }
  }
}