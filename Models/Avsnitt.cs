using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Avsnitt
    {
        public string Title {  get; set; }
        
        public string Description { get; set; }

        public Avsnitt(string title, string description) 
        {
            Title = title;
            Description = description;
        }

        public Avsnitt() { }


    }
}
