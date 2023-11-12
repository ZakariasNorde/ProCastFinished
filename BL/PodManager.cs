using System.Xml.Linq;
using System;
using System.Linq;
using Models;
using DAL.Repository;
using System.Net;
using System.Xml;
using System.Text.RegularExpressions;

namespace BL

{
    public class PodManager
    {

        IRepository<PoddCast> poddRepository;

        public PodManager()
        {
            poddRepository = new PoddRepository();
        }


        public void deletePodd(PoddCast poddCast)
        {
            poddRepository.delete(poddCast);
        }

        public List<PoddCast> getPoddList()
        {
            return poddRepository.getAll();
        }

        public PoddCast getPoddByUrl(string url)
        {
            return poddRepository.getItem(url);
        }

        public async Task<PoddCast> createOutsideList(string url, string namn, string kategori, int intervall)
        {
            PoddCast enPodd = new PoddCast(url, namn, kategori, intervall);
            await runAsync(enPodd);
            return enPodd;
        }

        //public async Task<PoddCast> updatePoddGammal(PoddCast gammalPodd, string url, string namn, string kategori, int intervall)
        //{

        //    await createNew(url, namn, kategori, intervall);
        //    PoddCast nyPodd = getPoddByUrl(url);
        //    deletePodd(gammalPodd);
        //    return nyPodd;

        //}

        public async Task<PoddCast> updatePoddNew(string url, string namn, string kategori, int intervall)
        {
            PoddCast nyPodd = await createOutsideList(url, namn, kategori, intervall);
            poddRepository.update(nyPodd);
            return nyPodd;

        }

        public int getPoddIndex(PoddCast poddCast)
        {
            List<PoddCast> allaPoddar = poddRepository.getAll();
            int index = -1;
            int i = 0;
            bool hittad = false;
            while (i < allaPoddar.Count && !hittad)
            {
                PoddCast enPodd = allaPoddar[i];
                if (enPodd.Url.Equals(poddCast.Url))
                {
                    hittad = true;
                    index = i;
                }
                i++;
            }
            return index;

        }

        public async Task createNew(string url, string namn, string kategori, int intervall)
        {
            PoddCast enPodd = new PoddCast(url, namn, kategori, intervall);
            await runAsync(enPodd);
            poddRepository.add(enPodd);
        }
        public async Task runAsync(PoddCast enPodd)
        {
            await setTitleAsync(enPodd);
            await setEpisodesAsync(enPodd);
            await fillListAsync(enPodd);

        }

        public async Task setTitleAsync(PoddCast enPodd)
        {
            try
            {

                string url = enPodd.Url;
                XDocument xDoc = await Task.Run(() => XDocument.Load(url));
                XElement titleElement = xDoc.Root.Element("channel").Element("title");

                if (titleElement != null)
                {
                    enPodd.Title = titleElement.Value;
                }
                else
                {

                }
            }
            catch (Exception ex)
            {

            }
        }

        public async Task setEpisodesAsync(PoddCast enPodd)
        {
            try
            {
                string url = enPodd.Url;
                XDocument xDoc = await Task.Run(() => XDocument.Load(url));
                int counter = xDoc.Root
                    .Elements("channel")
                    .Elements("item")
                    .Count();
                enPodd.EpisodesCount = counter;
            }
            catch (Exception ex)
            {

            }
        }

        public async Task fillListAsync(PoddCast enPodd)
        {
            try
            {
                string url = enPodd.Url;
                XDocument xDoc = await Task.Run(() => XDocument.Load(url));
                List<XElement> elementList = xDoc.Descendants("item").ToList();
                foreach (XElement item in elementList)
                {
                    string Title = item.Element("title").Value;
                    string Description = item.Element("description").Value;
                    Avsnitt ettAvsnitt = new Avsnitt(Title, Description);
                    enPodd.addToAvsnitt(ettAvsnitt);
                }
            }

            catch (Exception ex)
            {

            }
        }

        public async Task andraKategori(string gammal, string ny)
        {
            List<PoddCast> allaPoddar = getPoddList();
            var filtreradList = allaPoddar.Where(enPodd => enPodd.Kategori == gammal).ToList();

            foreach (var enPodd in filtreradList)
            {
                string poddensUrl = enPodd.Url;
                string poddensNamn = enPodd.Namn;
                int intervall = enPodd.Intervall;
                PoddCast uppdaterad = await updatePoddNew(poddensUrl, poddensNamn, ny, intervall);
            }
        }

        public async Task updateEpisodesAll()
        {
            List<PoddCast> allaPoddar = getPoddList();
            foreach (PoddCast enPodd in allaPoddar)
            {
                enPodd.Avsnitten.Clear();
                await runAsync(enPodd);
                enPodd.update();
            }
            poddRepository.update(allaPoddar);
        }

        public async Task updateEpisodes(string url)
        {
            PoddCast enPodd = poddRepository.getItem(url);
            enPodd.Avsnitten.Clear();
            await runAsync(enPodd);
            enPodd.update();
            poddRepository.update(enPodd);
        }

      
        }
}
