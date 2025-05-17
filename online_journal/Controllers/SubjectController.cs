using System;
using Microsoft.AspNetCore.Mvc;
using online_journal.Data;
using online_journal.Models;

namespace online_journal.Controllers
{
    public class SubjectController(MyDbApp context) : Controller
    {
        private readonly MyDbApp _context = context;

        public IActionResult Index()
        {
            var subjects = _context.Subjects.ToList();
            return View(subjects);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Subject subject)
        {
            if (ModelState.IsValid)
            {
                _context.Subjects.Add(subject);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(subject);
        }
    }
}
