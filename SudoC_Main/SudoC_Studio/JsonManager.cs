using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudoC_Studio
{
   public class JsonManager
    {
        static readonly string filePath = (@".\jsonDatabase\");
        public static void Serialize(Settings obj)
        {
            var serializer = new JsonSerializer();

            using (var sw = new StreamWriter(filePath +obj.ToString()+".json"))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, obj);
            }
        }

        public static Settings Deserialize(string path)
        {
            var serializer = new JsonSerializer();

            using (var sw = new StreamReader(path))
            using (var reader = new JsonTextReader(sw))
            {
                return serializer.Deserialize<Settings>(reader);
            }
        }
    }
}
