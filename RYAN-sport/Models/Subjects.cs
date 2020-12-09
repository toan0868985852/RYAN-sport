using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations.Schema;

namespace RYAN_sport.Models
{
    public class Subjects
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        [Column(TypeName = "decimal(8,2)")]
        public decimal Price { get; set; }
        public string Time { get; set; }

        public virtual ICollection<Level> Levels { get; set; }
    }
}
