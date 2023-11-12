using System.Xml.Linq;
using System;
using System.Linq;

namespace Models
{
    public class PoddCast
    {
        public string Url { get; set; }

        public string Title { get; set; }

        public string Kategori { get; set; }

        public int EpisodesCount { get; set; }

        public int Intervall { get; set; }  

        public string IntervallSträng { get; set; }

        public DateTime NextUpdate { get; set; }

        //sätt needs update till true ifall datetime now är senare än nextupdate
        public bool NeedsUpdate
        {
            get
            {
                return NextUpdate <= DateTime.Now;
            }
        }

        public string Namn {  get; set; }
        public List<Avsnitt> Avsnitten { get; set; }


        public PoddCast(string url, string namn, string kategori, int intervall)
        {
            Avsnitten = new List<Avsnitt>();
            Url = url;
            Namn = namn;
            Kategori = kategori;
            Intervall = intervall;
            setIntervallSträng();
            update();
        }
        public PoddCast()
        {

        }

        private void setIntervallSträng()
        {
            IntervallSträng = convertIntervallToString(Intervall);
                
        }
        public void addToAvsnitt(Avsnitt ettAvsnitt)
        {
            Avsnitten.Add(ettAvsnitt);
        }

        public static string convertIntervallToString(int intervall)
        {
            string intervallString = intervall.ToString();
            switch (intervall)
            {
                case 300000:
                    intervallString = "5 min";
                    break;

                case 420000:
                    intervallString = "7 min";
                    break;

                case 600000:
                    intervallString = "10 min";
                    break;
            }
            return intervallString;
        }
        public static int convertIntervallFromString(string intervallString)
        {
            int intervall = 0;
            switch (intervallString)
            {
                case "5 min":
                    intervall = 300000;
                    break;
                case "7 min":
                    intervall = 420000;
                    break;
                case "10 min":
                    intervall = 600000;
                    break;

            }
            return intervall;
        }

        //kalla på denna varje gång podden uppdaterats
        public void update()
        {
            NextUpdate = DateTime.Now.AddMilliseconds(Intervall);
        }

    }
}