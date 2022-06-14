using Lab2dll;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;

namespace MVVM_Test
{
    public class JsonFileService : IFileService
    {
        List<Tour> IFileService.Open(string filename)
        {
            List<Tour> tours = new List<Tour>();
            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(List<Tour>));
            using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate))
            {
                tours = jsonFormatter.ReadObject(fs) as List<Tour>;
            }

            return tours;
        }

        void IFileService.Save(string filename, List<Tour> tourList)
        {
            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(List<Tour>));
            using (FileStream fs = new FileStream(filename, FileMode.Create))
            {
                jsonFormatter.WriteObject(fs, tourList);
            }
        }
    }
}
