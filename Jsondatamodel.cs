using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise_ConsoleApp
{
    public class Jsondatamodel
    {

        public int id { get; set; }
        public string type { get; set; }
        public string name { get; set; }
        public string ppu { get; set; }
        public batters1 batters { get; set; }
        public topping1[] topping { get; set; }
    }

    public class batters1
    {
        public batter1[] batter { get; set; }
    }


    public class batter1
    {

        public int id { get; set; }
        public string type { get; set; }
    }
    public class topping1
    {

        public int id { get; set; }
        public string type { get; set; }
    }
}
