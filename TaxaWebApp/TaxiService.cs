using Newtonsoft.Json;

namespace TaxaWebApp
{
    public class TaxiService
    {
        public List<TaxiRate> GetJsonData()
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
                Console.WriteLine($"Error: The file '{jsonFilePath}' was not found.");
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading the file: {ex.Message}");
                return null;
            }

            // Deserialize JSON data to a list of TaxiRate objects
            List<TaxiRate>? allData = JsonConvert.DeserializeObject<List<TaxiRate>>(json);

            return allData;
        }
    }
}
