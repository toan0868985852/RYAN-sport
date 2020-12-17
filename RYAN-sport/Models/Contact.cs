using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace RYAN_sport.Models
{
    public class Contact
    {
        public int ID { get; set; }
        public string Email { get; set; }
        [Column(TypeName = "nvarchar(101)")]
        public string FirstName { get; set; }
        [Column(TypeName = "nvarchar(101)")]
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address01 { get; set; }
        public string Address02 { get; set; }
        [Column(TypeName = "text")]
        public string Messenger { get; set; }
    }
}
