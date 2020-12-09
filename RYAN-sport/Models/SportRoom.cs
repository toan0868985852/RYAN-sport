using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RYAN_sport.Models
{
    public class SportRoom
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Hotline { get; set; }

        public virtual ICollection<Level> Levels { get; set; }
    }
}
