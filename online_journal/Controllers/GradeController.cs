using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using online_journal.Data;
using online_journal.Models;

namespace online_journal.Controllers
{
    public class GradeController : Controller
    {
        private readonly MyDbApp _context;

        public GradeController(MyDbApp context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var grades = await _context.Grades
                .Include(g => g.Student)
                .Include(g => g.Subject)
                .ToListAsync();

            return View(grades);
        }
        public IActionResult Create()
        {
            ViewBag.Students = new SelectList(_context.Students, "Id", "FullName");
            ViewBag.Subjects = new SelectList(_context.Subjects, "Id", "Name");
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Grade grade)
        {
            if (ModelState.IsValid)
            {
                _context.Grades.Add(grade);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            ViewBag.Students = new SelectList(_context.Students, "Id", "FullName", grade.StudentId);
            ViewBag.Subjects = new SelectList(_context.Subjects, "Id", "Name", grade.SubjectId);
            return View(grade);
        }
    }
}
