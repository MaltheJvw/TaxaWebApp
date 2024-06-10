using Newtonsoft.Json;

namespace TaxaWebApp
{
    public class TaxiService : TaxiRate
    {
        public List<TaxiService>? GetJsonData()
        {
            string jsonFilePath = "wwwroot/CustomerService.json";
            string json;
            try
            {
                // Read JSON-data from file and add to the variable json
                json = File.ReadAllText(jsonFilePath);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine($"Fejl: Filen '{jsonFilePath}' blev ikke fundet.");
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Fejl under læsning af filen: {ex.Message}");
                return null;
            }

            List<TaxiService>? allData;

            // Deserialise JSON-data to a list of QuestionData-objects
            allData = JsonConvert.DeserializeObject<List<TaxiService>>(json);

            return allData;
        }
    }
}
