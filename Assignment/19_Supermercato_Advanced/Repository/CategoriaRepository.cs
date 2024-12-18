using Newtonsoft.Json;
public class CategoriaRepository
{
  private readonly string folderPath = @"Database/Categoria";

  public void SalvaCategoria(List<Categoria> categoria)
  {
    if (!Directory.Exists(folderPath))
    {
      Directory.CreateDirectory(folderPath);
    }

    foreach (var cat in categoria)
    {
      string filePath = $"{folderPath}/{cat.Id}.json";
      // Serialize file
      string jsonData = JsonConvert.SerializeObject(cat, Formatting.Indented);
      // Write
      File.WriteAllText(filePath, jsonData);
      // Console.WriteLine($"salvati {filePath}");
    }
  }

  public List<Categoria> CaricaCategoria()
  {
    List<Categoria> categoria = new List<Categoria>();

    // control
    if (Directory.Exists(folderPath))
    {
      string[] filePaths = Directory.GetFiles(folderPath, "*.json");

      foreach (var item in filePaths)
      {
        // Read fatoo
        string jsonData = File.ReadAllText(item);
        // Deserialize
        Categoria cat = JsonConvert.DeserializeObject<Categoria>(jsonData);
        categoria.Add(cat);
        // Console.WriteLine($" caricati {item}");
      }
      // foreach (var cat in categoria)
      // {
      //     Console.WriteLine($"Id: {cat.Id}, Nome: {cat.Nome}, Prezzo: {cat.Prezzo}, Giacenza: {cat.Giacenza}, Categoria: {cat.Categoria}");
      // }
    }
    else
    {
      Console.WriteLine($"Cartella {folderPath} non esiste");
    }

    return categoria;
  }

  public void RimuoviDaCategoria(int id)
  {
    string filePath = $"{folderPath}/{id}.json";
    if (File.Exists(filePath))
    {
      File.Delete(filePath);
    }
  }

}