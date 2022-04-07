using DersBlogSite.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DersBlogSite.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var makaleler = new List<Article>
            {
                new Article
                {
                    ID=1,
                    Header="Html",
                    Content="Lorem ipsum dolor sit amet consectetur adipisicing elit. Ex temporibus laborum similique est. Reprehenderit repellendus labore illum quia unde libero eos expedita odio, impedit soluta autem voluptate tenetur pariatur animi."

                },
                 new Article
                {
                    ID=1,
                    Header="Css",
                    Content="Lorem ipsum dolor sit amet consectetur adipisicing elit. Ex temporibus laborum similique est. Reprehenderit repellendus labore illum quia unde libero eos expedita odio, impedit soluta autem voluptate tenetur pariatur animi."

                },
                  new Article
                {
                    ID=1,
                    Header="Bootstrap",
                    Content="Lorem ipsum dolor sit amet consectetur adipisicing elit. Ex temporibus laborum similique est. Reprehenderit repellendus labore illum quia unde libero eos expedita odio, impedit soluta autem voluptate tenetur pariatur animi."

                },
                   new Article
                {
                    ID=1,
                    Header="JavaScript",
                    Content="Lorem ipsum dolor sit amet consectetur adipisicing elit. Ex temporibus laborum similique est. Reprehenderit repellendus labore illum quia unde libero eos expedita odio, impedit soluta autem voluptate tenetur pariatur animi."
                },
                   new Article
                {
                    ID=1,
                    Header="Jquery",
                    Content="Lorem ipsum dolor sit amet consectetur adipisicing elit. Ex temporibus laborum similique est. Reprehenderit repellendus labore illum quia unde libero eos expedita odio, impedit soluta autem voluptate tenetur pariatur animi."
                },
                   new Article
                {
                    ID=1,
                    Header="C#",
                    Content="Lorem ipsum dolor sit amet consectetur adipisicing elit. Ex temporibus laborum similique est. Reprehenderit repellendus labore illum quia unde libero eos expedita odio, impedit soluta autem voluptate tenetur pariatur animi."
                }
            };
            return View(makaleler);
        }


    }
}
