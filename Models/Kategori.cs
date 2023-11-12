using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Kategori
    {
        public string Namn {  get; set; }

        public Kategori(string namn)
        {
            Namn = namn;
        }

        public Kategori() { }
    }
}
