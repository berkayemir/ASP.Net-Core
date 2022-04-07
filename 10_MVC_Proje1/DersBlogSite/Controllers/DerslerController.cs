using DersBlogSite.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DersBlogSite.Controllers
{
    public class DerslerController : Controller
    {
        public IActionResult Index()
        {
            var lessons = new List<Lesson>
            {
                new Lesson {
                ID=1,
                LessonName="HTML",
                Category="FronEnd"
                
                },
                new Lesson {
                ID=2,
                LessonName="HTML",
                Category="FronEnd"

                },
                new Lesson {
                ID=3,
                LessonName="HTML",
                Category="FronEnd"

                },
                new Lesson {
                ID=4,
                LessonName="HTML",
                Category="FronEnd"

                },
                new Lesson {
                ID=5,
                LessonName="HTML",
                Category="FronEnd"  

                },
                new Lesson {
                ID=6,
                LessonName="C#",
                Category="BackEnd"

                },
                new Lesson {
                ID=7,
                LessonName="Php",
                Category="BackEnd"

                },
            };
            return View(lessons);
        }
    }
}
