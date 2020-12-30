using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Admin2.Models
{
    public class SubjectSportRoom
    {
        public int ID { get; set; }
        public int SportRoomId { get; set; }
        public int SubjectId { get; set; }

        public virtual Subject Subject { get; set; }
        public virtual SportRoom SportRoom { get; set; }
    }
}
