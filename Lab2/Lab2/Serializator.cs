using Newtonsoft.Json;
using System.IO;

namespace Lab2
{
    class Serializator<T>
    {
        private readonly string path;
        public Serializator(string path)
        {
            this.path = path;
        }

        public void Serialize(T model)
        {
            string serial = JsonConvert.SerializeObject(model);
            File.WriteAllText(path, serial);
        }
        public T Deserialize()
        {
            string deserial = File.ReadAllText(path);
            return JsonConvert.DeserializeObject<T>(deserial);
        }
    }
}