using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RYAN_sport.Areas.Identity.Data;

namespace RYAN_sport.Models
{
    public class Card
    {
        public int ID { get; set; }
        public string NumberCard { get; set; }
        public string Date { get; set; }

        public virtual Level Level { get; set; }
        public virtual Subscription Subscription { get; set; }
        public virtual AplicationtUser AplicationtUser { get; set; }
    }
}
