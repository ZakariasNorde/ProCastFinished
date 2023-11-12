using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Models;
namespace DAL.Repository
{
    public class KategoriRepository : IRepository<Kategori>
    {
        
        List<Kategori> kategoriList;
        XmlSerializer<Kategori> serialiserare;
        public KategoriRepository()
        {
            serialiserare = new XmlSerializer<Kategori>("Kategorier");
            List<Kategori> listFromFile = getAll();
            if(listFromFile.Count > 0)
            {
                kategoriList = listFromFile;
            }
            else
            {
                kategoriList = new List<Kategori>();
            }

        }

        public List<Kategori> getAll()
        {
            return serialiserare.deSerialiserare();
        }

        public void add(Kategori newKategori)
        {
            kategoriList.Add(newKategori);
            saveChanges();
        }

        public void delete(Kategori kategori)
        {
            string namn = kategori.Namn;
            int i = 0;
            bool hittat = false;
            while(i < kategoriList.Count && !hittat)
            {
                Kategori enKategori = kategoriList[i];
                if (enKategori.Namn.Equals(namn))
                {
                    hittat = true;
                    kategoriList.RemoveAt(i);
                }
                i++;
            }
            saveChanges();
        }

        public void update(List<Kategori> enList)
        {

        }

        public void update(Kategori nyK)
        {

        }

        public Kategori getItem(string namn)
        {
            Kategori hittadKategori = null;
            int i = 0;
            bool hittat = false;
            while (i < kategoriList.Count && !hittat)
            {
                Kategori enKategori = kategoriList[i];
                if (enKategori.Namn.Equals(namn))
                {
                    hittat = true;
                    hittadKategori = kategoriList[i];
                }
                i++;
            }
            return hittadKategori;
        }

        public void saveChanges()
        {
            serialiserare.serializer(kategoriList);
        }
    }
}
