using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Spisok
    {
        public Sakas[] Sborka { get; set; }
    }
    class Sakas
    {
        public string Artist { get; set; }
        public string Album { get; set; }
        public string Title { get; set; }
        public string Year { get; set; }
    }
}
