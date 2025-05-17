using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using online_journal.Data;
using online_journal.Models;

namespace online_journal.Controllers
{
    public class AttendanceController(MyDbApp context) : Controller
    {
        private readonly MyDbApp _context = context;

        public async Task<IActionResult> Index()
        {
            var attendances = await _context.Attendances.Include(a => a.Student).ToListAsync();
            return View(attendances);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Attendance attendance)
        {
            if (ModelState.IsValid)
            {
                _context.Attendances.Add(attendance);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(attendance);
        }
    }
}
