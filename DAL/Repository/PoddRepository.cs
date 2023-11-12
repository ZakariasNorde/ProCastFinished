using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
namespace DAL.Repository
{
    public class PoddRepository : IRepository<PoddCast>
    {
        private List<PoddCast> poddList;
        private XmlSerializer<PoddCast> serialiserare;
        public PoddRepository()
        {
            serialiserare = new XmlSerializer<PoddCast>("Poddar");
            List<PoddCast> listFromFile = getAll();
            if (listFromFile.Count < 1)
            {
                poddList = new List<PoddCast>();
            }
            else
            {
                poddList = listFromFile;
            }
        }

        public List<PoddCast> getAll()
        {
            return serialiserare.deSerialiserare();
        }

        public void add(PoddCast enPodd)
        {
            poddList.Add(enPodd);
            saveChanges();
        }

        public void delete(PoddCast enPodd)
        {
            string url = enPodd.Url;
            int indexToDelete = getIndexByUrl(url);
            poddList.RemoveAt(indexToDelete);
            saveChanges();
        }
        


        public void update(List<PoddCast> uppdateradList)
        {
            poddList = uppdateradList;
            saveChanges();
        }

        public void update(PoddCast nyPodd)
        {
            string url = nyPodd.Url;
            int index = getIndexByUrl(url);
            poddList[index] = nyPodd;
            saveChanges();
        }

        public void saveChanges()
        {
            serialiserare.serializer(poddList);
        }

        

        //Gjort while loopen baklänges för att få ut den nyaste
        //eftersom det underlättar när man ska ändra flöde
        public PoddCast getItem(string url)
        {
            PoddCast hittadPodd = null;
            List<PoddCast> allaPoddar = serialiserare.deSerialiserare();
            int i = allaPoddar.Count - 1;
            bool hittat = false;
            while (i > -1 && !hittat)
            {
                PoddCast enPodd = allaPoddar[i];
                if (enPodd.Url.Equals(url))
                {
                    hittat = true;
                    hittadPodd = enPodd;
                }
                i--;
            }
            return hittadPodd;
        }

        public int getIndexByUrl(string url)
        {
            int index = -1;
            int i = 0;
            bool hittat = false;
            while (i < poddList.Count && !hittat)
            {
                PoddCast podd = poddList[i];
                if (podd.Url == url)
                {
                    index = i;
                    hittat = true;
                }
                i++;
            }
            return index;
        }

    }
    
}
