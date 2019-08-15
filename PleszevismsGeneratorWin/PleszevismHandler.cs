using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PleszevismsGeneratorWin
{
    public class PleszevismHandler
    {
        public Pleszevism LoadFromFile(string filePath)
        {
            using (Stream inputStream = File.OpenRead(filePath))
            {
                try
                {
                    DataContractSerializer serializer = new DataContractSerializer(typeof(Pleszevism));
                    return serializer.ReadObject(inputStream) as Pleszevism;
                }
                catch
                {
                    return null;
                }                
            }
        }

        public void Serialize(Pleszevism pleszevism)
        {
            string PleszevismFile = Path.GetFullPath("Pleszevism2.xml");

            if (File.Exists(PleszevismFile))
            {
                File.Delete(PleszevismFile);
            }

            using (Stream outputStream = File.OpenWrite(PleszevismFile))
            {
                DataContractSerializer serializer = new DataContractSerializer(typeof(Pleszevism));
                serializer.WriteObject(outputStream, pleszevism);
            }
        }
    }
}
