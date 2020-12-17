using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RYAN_sport.Models
{
    public class Subject
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        [Column(TypeName = "decimal(8,2)")]
        public decimal Price { get; set; }
        public string Time { get; set; }
        public string Category { get; set; }
        public string ImgSubject { get; set; }
        public string ImgSubjectDetail { get; set; }

        public virtual ICollection<LevelSubject> LevelSubjects { get; set; }
        //public virtual ICollection<Galery> Galeries { get; set; }
        public virtual ICollection<SubjectSportRoom> SubjectSportRooms { get; set; }
    }
}
