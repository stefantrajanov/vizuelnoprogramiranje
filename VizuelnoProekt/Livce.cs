using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VizuelnoProekt
{
    public class Livce
    {
        public List<int> brojcinja { get; set; }
        public bool parnost;

        public Livce(List<int> brojcinja, bool parnost)
        {
            this.brojcinja = brojcinja;
            this.parnost = parnost;
        }
        
    }
}
