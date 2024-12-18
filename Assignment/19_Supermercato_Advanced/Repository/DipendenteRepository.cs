using Newtonsoft.Json;
public class DipendenteRipository
{
  private readonly string folderPath = @"Database/Dipendente";

  public void SalvaDipendente(List<Dipendente> dipendente)
  {
    if (!Directory.Exists(folderPath))
    {
      Directory.CreateDirectory(folderPath);
    }

    foreach (var dip in dipendente)
    {
      string filePath = $"{folderPath}/{dip.Id}.json";
      // Serialize file
      string jsonData = JsonConvert.SerializeObject(dip, Formatting.Indented);
      // Write
      File.WriteAllText(filePath, jsonData);
      // Console.WriteLine($"salvati {filePath}");
    }
  }

  public List<Dipendente> CaricaDipendente()
  {
    List<Dipendente> dipendente = new List<Dipendente>();

    // control
    if (Directory.Exists(folderPath))
    {
      string[] filePaths = Directory.GetFiles(folderPath, "*.json");

      foreach (var item in filePaths)
      {
        // Read fatoo
        string jsonData = File.ReadAllText(item);
        // Deserialize
        Dipendente dip = JsonConvert.DeserializeObject<Dipendente>(jsonData);
        dipendente.Add(dip);
        // Console.WriteLine($" caricati {item}");
      }
      // foreach (var dip in dipendente)
      // {
      //     Console.WriteLine($"Id: {dip.Id}, Nome: {dip.Nome}, Prezzo: {dip.Prezzo}, Giacenza: {dip.Giacenza}, Categoria: {dip.Categoria}");
      // }
    }
    else
    {
      Console.WriteLine($"Cartella {folderPath} non esiste");
    }

    return dipendente;
  }

  public void RimuoviDaDipendente(int id)
  {
    string filePath = $"{folderPath}/{id}.json";
    if (File.Exists(filePath))
    {
      File.Delete(filePath);
    }
  }

}