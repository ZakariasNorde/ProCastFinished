using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Repository;
using Models;
namespace BL
{
    public class KategoriManager
    {
        IRepository<Kategori> kategoriRepository;

        public KategoriManager()
        {
            kategoriRepository = new KategoriRepository();
        }

        public void createNew(string name)
        {
            Kategori nyKategori = new Kategori(name);
            kategoriRepository.add(nyKategori);
        }

        public void delete(Kategori kategori)
        {
            kategoriRepository.delete(kategori);
        }
        
        public List<Kategori> getAll() 
        { 
            return kategoriRepository.getAll();
        }
        
        public Kategori getKategoriByNamn(string namn)
        {
            return kategoriRepository.getItem(namn);
        }

        public void updateKategori(Kategori gammal, string nyttNamn)
        {
            createNew(nyttNamn);
            delete(gammal);
        }
    }
}
