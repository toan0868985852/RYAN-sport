using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Admin2.Models
{
    public class LevelSubject
    {
        public int ID { get; set; }
        public int LevelId { get; set; }
        public int SubjectId { get; set; }

        public virtual Level Level { get; set; }
        public virtual Subject Subject { get; set; }
    }
}
