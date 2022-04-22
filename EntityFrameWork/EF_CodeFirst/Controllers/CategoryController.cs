using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EF_CodeFirst.Models.Context;
using EF_CodeFirst.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Controllers
{
    public class CategoryController : Controller
    {
        private readonly Library6Context _context;

        public CategoryController(Library6Context context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Categories.ToList());
        }

        public IActionResult Details(int id)
        {
            var category = _context.Categories.Find(id);
            return View(category);
        }

        public IActionResult Edit(int id)
        {
            var category = _context.Categories.Find(id);
            return View(category);
        }


        [HttpPost]
        public IActionResult Edit(Category category)
        {
            _context.UpdateRange(category);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var category = _context.Categories.Find(id);
            return View(category);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var deleteCategory = _context.Categories.Find(id);
            if (deleteCategory.IsDeleted == false)
            {
                deleteCategory.IsDeleted = true;

            }
            else
            {
                deleteCategory.IsDeleted = false;

            }
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost, ActionName("DeleteCompletely")]
        public IActionResult DeleteCompletely(Category category)
        {
            _context.Categories.Remove(category);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Category category)
        {
            _context.Add(category);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}   