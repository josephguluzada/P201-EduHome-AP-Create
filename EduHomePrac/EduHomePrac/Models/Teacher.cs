using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomePrac.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        [StringLength(maximumLength:100)]
        public string Image { get; set; }
        public string Position { get; set; }
        public string Degree { get; set; }
        public string Experience { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }
    }
}
