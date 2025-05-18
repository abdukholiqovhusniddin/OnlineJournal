using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using online_journal.Data;
using online_journal.Models;

namespace online_journal.Controllers
{
    public class AttendanceController : Controller
    {
        private readonly MyDbApp _context;

        public AttendanceController(MyDbApp context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var attendances = await _context.Attendances
                .Include(a => a.Student)
                .ToListAsync();

            return View(attendances);
        }

        public IActionResult Create()
        {
            ViewBag.Students = new SelectList(_context.Students, "Id", "FullName");
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

            ViewBag.Students = new SelectList(_context.Students, "Id", "FullName", attendance.StudentId);
            return View(attendance);
        }
    }
}
