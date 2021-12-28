using EduHomePrac.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomePrac.Areas.Manage.Controllers
{
    [Area("manage")]
    public class TeacherController : Controller
    {
        private readonly DataContext _context;
        private readonly IWebHostEnvironment _env;

        public TeacherController(DataContext context,IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Create(Teacher teacher)
        {
            if(teacher.ImageFile != null)
            {
                if(teacher.ImageFile.Length > 2097152)
                {
                    ModelState.AddModelError("ImageFile", "Max size must be 2mb");
                    return View();
                }

                if(teacher.ImageFile.ContentType != "image/jpeg" && teacher.ImageFile.ContentType != "image/png")
                {
                    ModelState.AddModelError("ImageFile", "Content type must be jpeg or png!!!");
                    return View();
                }

                string fileName = teacher.ImageFile.FileName;

                if(fileName.Length > 64)
                {
                    fileName = fileName.Substring(fileName.Length - 64, 64);
                }

                string newFileName = Guid.NewGuid().ToString() + fileName;

                string path = Path.Combine(_env.WebRootPath, "uploads/teachers", newFileName);

                using(FileStream stream = new FileStream(path, FileMode.Create))
                {
                    teacher.ImageFile.CopyTo(stream);
                }

                teacher.Image = newFileName;
            }

            if (!ModelState.IsValid) return View();

            _context.Teachers.Add(teacher);
            _context.SaveChanges();

            return RedirectToAction("index", "teacher");
        }
    }
}
