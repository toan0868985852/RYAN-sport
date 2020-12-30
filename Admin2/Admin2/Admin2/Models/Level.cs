using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Admin2.Models
{
    public class Level
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Card> Cards  { get; set; }
        public virtual ICollection<LevelSubject> LevelSubjects  { get; set; }

    }
}
