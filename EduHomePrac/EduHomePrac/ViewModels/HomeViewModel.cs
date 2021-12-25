using EduHomePrac.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomePrac.ViewModels
{
    public class HomeViewModel
    {
        public List<Course> Courses { get; set; }
        public List<Notice> Notices { get; set; }
    }
}
