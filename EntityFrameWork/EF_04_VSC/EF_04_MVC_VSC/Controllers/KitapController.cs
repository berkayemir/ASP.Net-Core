using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using EF_04_MVC_VSC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace EF_04_MVC_VSC.Controllers
{
    public class KitapController : Controller
    {
        private readonly KutuphaneSabahContext _context;
        public KitapController(KutuphaneSabahContext context)
        {
            _context = context;
            //Bu aşamadan sonra yani nesne ilk üretildiği andan itibare
            //_context değişkeni benim modelimi temsil ediyor olacak.
            //KutuphaneSabahContext'i temsil edecek.
        }


        public IActionResult Index()
        {
            return View(_context.Kitaplars.ToList());
        }


        public IActionResult Details(string id)
        {
            var kitap = _context.Kitaplars
                .Include(k => k.Tur)
                .Include(k => k.YayinEvi)
                .Include(k => k.Yazar)
                .First(sk => sk.Isbn == id);
            return View(kitap);
        }

        public IActionResult Edit(string id)
        {
            var seciliKitap = _context.Kitaplars.Find(id);
            ViewData["Tur"]=new SelectList(_context.Turlers,"Id","TurAd",seciliKitap.TurId);
            ViewData["Yazar"]=new SelectList(_context.Yazarlars,"Id","AdSoyad",seciliKitap.YazarId);
            ViewData["YayinEvi"]=new SelectList(_context.Yayinevleris,"Id","Ad",seciliKitap.YayinEviId);

            return View(seciliKitap);
        
        }

        [HttpPost]
        public IActionResult Edit( Kitaplar kitap)
        {
            if (ModelState.IsValid)
            {
                _context.Update(kitap); //Bu satır sadece contextimizi güncelledi.
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(kitap);
        }

        public IActionResult Delete(string id)
        {
            var kitap = _context.Kitaplars.Find(id);
            return View(kitap);
        }


        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(string id)
        {
            var silinecekKitap = _context.Kitaplars.Find(id);
            _context.Kitaplars.Remove(silinecekKitap);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Create()
        {
            ViewData["Tur"]=new SelectList(_context.Turlers,"Id","TurAd");
            ViewData["Yazar"]=new SelectList(_context.Yazarlars,"Id","AdSoyad");
            ViewData["YayinEvi"]=new SelectList(_context.Yayinevleris,"Id","Ad");
            return View();
        }

        [HttpPost]
        public IActionResult Create(Kitaplar kitap)
        {
            _context.Add(kitap);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }




}