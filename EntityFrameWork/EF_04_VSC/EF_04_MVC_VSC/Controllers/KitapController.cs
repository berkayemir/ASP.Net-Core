using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using EF_04_MVC_VSC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace EF_04_MVC_VSC.Controllers
{
    public class KitapController : Controller
    {
        private readonly KutuphaneSabahContext _context;
           public KitapController(KutuphaneSabahContext context)
        {
            _context=context;
            //Bu aşamadan sonra yani nesne ilk üretildiği andan itibare
            //_context değişkeni benim modelimi temsil ediyor olacak.
            //KutuphaneSabahContext'i temsil edecek.
        }
       

        public IActionResult Index()
        {
            return View(_context.Kitaplars.ToList());
        }


          public IActionResult Details(string Isbn)
        {
            var kitap = _context.Kitaplars.Where(e => e.Isbn == Isbn);
            return View(kitap);
        }

         public IActionResult Edit(string Isbn)
        {
            var kitap = _context.Kitaplars.Where(e=>e.Isbn==Isbn);
            return View(kitap);
        }

        [HttpPost]
              public IActionResult Edit([Bind("Isbn,Ad")]Kitaplar kitap)
        {
            if (ModelState.IsValid)
            {
                _context.Update(kitap); //Bu satır sadece contextimizi güncelledi.
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(kitap);
        }

        public IActionResult Delete(string Isbn)
        {
            var kitap = _context.Turlers.Find(Isbn);
            return View(kitap);
        }


        [HttpPost,ActionName("Delete")]
        public IActionResult DeleteConfirmed(string Isbn)
        {
            var silinecekKitap=_context.Turlers.Find(Isbn);
            _context.Turlers.Remove(silinecekKitap);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }


        
    
}