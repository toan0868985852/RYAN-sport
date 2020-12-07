using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RYAN_sport.Models
{
    public class exercisePackage
    {
        public int ID { get; set; }
        public string Image { get; set; }
        public string TitlePackage { get; set; }
        public string ContentPackage { get; set; }
        [Column(TypeName = "decimal(8,2)")]
        public decimal Price { get; set; }
        public string datePackage { get; set; }
    }
}
