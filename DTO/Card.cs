using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Card
    {
        public string name { get; set; }
        public string set { get; set; }
        public string set_code { get; set; }
        public int id { get; set; }
        public string type { get; set; }
        public int power { get; set; }
        public int tougness { get; set; }
        public int loyalty { get; set; }
        public string manacost { get; set; }
        public int converted_manacost { get; set; }
        public string color { get; set; }
        public string generated_mana { get; set; }
        public int number { get; set; }
        public string rarity { get; set; }
        public string ability { get; set; }
    }
}
