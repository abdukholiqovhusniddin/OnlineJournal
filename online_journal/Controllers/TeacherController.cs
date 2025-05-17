using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using online_journal.Data;
using online_journal.Models;

namespace online_journal.Controllers
{
    public class TeacherController(MyDbApp context) : Controller
    {
        private readonly MyDbApp _context = context;

        public async Task<IActionResult> Index()
        {
            var teachers = await _context.Teachers.Include(t => t.Subject).ToListAsync();
            return View(teachers);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Teacher teacher)
        {
            if (ModelState.IsValid)
            {
                _context.Teachers.Add(teacher);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(teacher);
        }

    }
}
