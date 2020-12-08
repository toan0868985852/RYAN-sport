using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RYAN_sport.Models
{
    public class Subscription
    {
        public int ID { get; set; }
        public string RegistrationDate { get; set; }
        public string EndDate { get; set; }

        public virtual ICollection<Card> Cards { get; set; }
    }
}
