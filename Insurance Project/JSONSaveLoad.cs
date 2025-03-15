using Newtonsoft.Json;

namespace Insurance_Project
{
    public class JSONSaveLoad
    {
        public string FileName { get; set; } = "insurances.json";

        // We save the entire list of insurances
        public void SaveListToFile(List<Insurance> list)
        {
            try
            {
                string jsonString = JsonConvert.SerializeObject(list, Formatting.Indented);
                File.WriteAllText(FileName, jsonString);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving file: {ex.Message}");
            }

        }

        // Loading all insurances
        public List<Insurance> LoadListFromFile()
        {
            try
            {
                if (!File.Exists(FileName))
                {
                    return new List<Insurance>(); // if the file does not exist, return an empty list
                }
                    

                string jsonString = File.ReadAllText(FileName);
                var list = JsonConvert.DeserializeObject<List<Insurance>>(jsonString);

                return list ?? new List<Insurance>();
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error loading file: {ex.Message}");

                return new List<Insurance>();
            }
        }
    }

}
