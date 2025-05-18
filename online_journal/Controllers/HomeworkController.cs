using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using online_journal.Data;
using online_journal.Models;
using System.Threading.Tasks;

namespace online_journal.Controllers
{
    public class HomeworkController(MyDbApp context) : Controller
    {
        private readonly MyDbApp _context = context;

        public async Task<IActionResult> Index()
        {
            var homeworks = await _context.Homeworks.Include(h => h.Subject).ToListAsync();
            return View(homeworks);
        }

        public IActionResult Create()
        {
            ViewData["Subjects"] = new SelectList(_context.Subjects, "Id", "Name");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Homework homework)
        {
            if (ModelState.IsValid)
            {
                _context.Homeworks.Add(homework);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Subjects"] = new SelectList(_context.Subjects, "Id", "Name", homework.SubjectId);
            return View(homework);
        }
    }
}
