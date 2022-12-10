using PatientManager.Core;
using PatientMenager.Data;
using System.Text.Json;

namespace PatientManager.Data
{
    public class FileDataService : IFileData
    {
        private readonly JsonSerializerOptions options = new JsonSerializerOptions { WriteIndented = true };
        private string file;

        public void AddJsonObject<T>(T newObject, FileNameType fileNameType)
        {
            file = $"{fileNameType}.json";

            List<T> collection = GetJsonObjects<T>(fileNameType).ToList();
            collection.Add(newObject);

            string jsonString = JsonSerializer.Serialize(collection, options);
            File.WriteAllText($"{fileNameType}.json", $"{jsonString}");
        }

        public void DeleteJsonMedicine(int id)
        {
            FileNameType fileNameType = FileNameType.Medicine;
            file = $"{fileNameType}.json";
            List<MedicineJsonModel> collection = GetJsonObjects<MedicineJsonModel>(fileNameType).ToList();

            collection = collection.Where(x => x.Id != id).ToList();

            string jsonString = JsonSerializer.Serialize(collection, options);
            File.WriteAllText($"{fileNameType}.json", $"{jsonString}");
        }

        public void EditJsonMedicine(MedicineJsonModel newObject)
        {
            FileNameType fileNameType = FileNameType.Medicine;
            file = $"{fileNameType}.json";
            List<MedicineJsonModel> collection = GetJsonObjects<MedicineJsonModel>(fileNameType).ToList();

            MedicineJsonModel model = collection.FirstOrDefault(x => x.Id == newObject.Id);

            if (model != null)
            {
                model.PatientIds = newObject.PatientIds;
                model.Name = newObject.Name;
                model.Description = newObject.Description;
            }

            string jsonString = JsonSerializer.Serialize(collection, options);
            File.WriteAllText($"{fileNameType}.json", $"{jsonString}");
        }

        public List<T> GetJsonObjects<T>(FileNameType fileNameType)
        {
            file = $"{fileNameType}.json";
            List<T> collection = new List<T>(); ;

            if (File.Exists(file))
            {
                String JSONtxt = File.ReadAllText(file);
                if (!string.IsNullOrEmpty(JSONtxt))
                    collection = JsonSerializer.Deserialize<List<T>>(JSONtxt);
            }
            return collection;
        }

    }
}