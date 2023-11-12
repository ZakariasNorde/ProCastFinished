using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Xml.Serialization;
namespace DAL
{
    internal class XmlSerializer<T>
    {
        private string fileName;
        public string FileName
        {
            set
            {
                fileName = value;
            }
        }

        public XmlSerializer(string fName)
        {
            fileName = fName + ".xml";
        }

        public void serializer(List<T> list)
        {
            XmlSerializer serialiserare = new XmlSerializer(typeof(List<T>));
            
            using(FileStream outStream = new FileStream(fileName, FileMode.Create, FileAccess.Write))
            {
                serialiserare.Serialize(outStream, list);
            }
        }

        public List<T> deSerialiserare()
        {
            
            try {
                XmlSerializer deSerialiserare = new XmlSerializer(typeof(List<T>));

                using (FileStream inStream = new FileStream(fileName, FileMode.Open, FileAccess.Read))
                {
                    List<T> hamtadLista = (List<T>)deSerialiserare.Deserialize(inStream);
                    return hamtadLista;
                }
            }
            catch(Exception ex)
            {
                return new List<T>();
            }
        }

    }
}
