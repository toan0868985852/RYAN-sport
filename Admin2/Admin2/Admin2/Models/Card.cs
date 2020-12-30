using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
//using RYAN_sport.Areas.Identity.Data;

namespace Admin2.Models
{
    public class Card
    {
        public int ID { get; set; }
        public string AplicationtUserId { get; set; }
        public int LevelId { get; set; }
        public string NumberCard { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }

        public virtual Subscription Subscriptions { get; set; }
        //public virtual AplicationtUser AplicationtUser { get; }
        public virtual Level Level { get; set; }
    }
}
