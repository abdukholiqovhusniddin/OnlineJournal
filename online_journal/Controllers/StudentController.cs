using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using online_journal.Data;
using online_journal.Models;

namespace online_journal.Controllers
{
    public class StudentController(MyDbApp context) : Controller
    {
        private readonly MyDbApp _context = context;

        public async Task<IActionResult> Index()
        {
            var students = await _context.Students.Include(s => s.Class).Include(s => s.Parent).ToListAsync();
            return View(students);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Student student)
        {
            if (ModelState.IsValid)
            {
                _context.Students.Add(student);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(student);
        }
    }
}
