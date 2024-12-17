// using Newtonsoft.Json;
// public class PurchasesRepository
// {
//         private readonly string folderPath = "Database/Prodotti";

//         public void SalvaAcquisti(List<Purchases> acquisti)
//     {
//         if (!Directory.Exists(Path.Combine(folderPath, folderPathAcquisti)))
//         {
//             Directory.CreateDirectory(Path.Combine(folderPath, folderPathAcquisti));
//         }
//         foreach (var item in acquisti)
//         {
//             string filePath = Path.Combine(folderPath, folderPathAcquisti, $"{item.Id}.json");
//             // Serialize fle
//             string jsonData = JsonConvert.SerializeObject(item, Formatting.Indented);
//             // scrivo
//             File.WriteAllText(filePath, jsonData);
//             Console.WriteLine($"salvati {filePath}");
//         }
//     }

//     public List<Purchases> CaricaAcquisti()
//     {
//         List<Purchases> acquisti = new List<Purchases>();

//         // control
//         if (Directory.Exists(Path.Combine(folderPath, folderPathAcquisti)))
//         {
//             string[] filePaths = Directory.GetFiles(Path.Combine(folderPath, folderPathAcquisti), "*.json");

//             foreach (var item in filePaths)
//             {
//                 string jsonData = File.ReadAllText(item);

//                 Purchases acquisto = JsonConvert.DeserializeObject<Purchases>(jsonData);
//                 acquisti.Add(acquisto);
//                 Console.WriteLine($" caricati {item}");
//             }

//             foreach (var acquisto in acquisti)
//             {
//                 Console.WriteLine($"Id: {acquisto.Id}, Nome: {acquisto.Prodotto.Nome}, Prezzo: {acquisto.Prodotto.Prezzo}, Categoria: {acquisto.DataAcquisto}, Quantita: {acquisto.Quantita}");
//             }
//         }
//         else
//         {
//             Console.WriteLine($"Cartella {folderPath} e {folderPathAcquisti} non esiste");

        
//         }

//         return acquisti;
//     }


// }
