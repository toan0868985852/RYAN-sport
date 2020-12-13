using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RYAN_sport.Models.ViewModels
{
    public class SubjectListViewModel
    {
        public IEnumerable<Subject> Subjects { get; set; }
        public PagingInfo PagingInfo { get; set; }

        public string CurrentCategory { get; set; }
    }
}
