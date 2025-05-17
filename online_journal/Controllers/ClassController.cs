using System;
using Microsoft.AspNetCore.Mvc;
using online_journal.Data;
using online_journal.Models;

namespace online_journal.Controllers
{
    public class ClassController(MyDbApp context) : Controller
    {
        private readonly MyDbApp _context = context;

        public IActionResult Index()
        {
            var classes = _context.Classes.ToList();
            return View(classes);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Class @class)
        {
            if (ModelState.IsValid)
            {
                _context.Classes.Add(@class);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(@class);
        }
    }
}
