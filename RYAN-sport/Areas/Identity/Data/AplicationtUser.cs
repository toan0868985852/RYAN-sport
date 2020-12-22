using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using RYAN_sport.Models;

namespace RYAN_sport.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the AplicationtUser class
    public class AplicationtUser : IdentityUser
    {
        [PersonalData]
        [Column(TypeName = "nvarchar(101)")]
        public string FirstName { get; set; }
        [PersonalData]
        [Column(TypeName = "nvarchar(101)")]
        public string LastName { get; set; }
        
        public string Sex { get; set; }
        
        public string Address { get; set; }
       
        public string Birthday { get; set; }

        public virtual Card Cards { get; set; }

    }
}
