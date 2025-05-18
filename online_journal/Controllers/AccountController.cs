using Microsoft.AspNetCore.Mvc;
using online_journal.Data;
using online_journal.Models;
using online_journal.ViewModels;

namespace online_journal.Controllers
{
    public class AccountController : Controller
    {
        private readonly MyDbApp _context;

        public AccountController(MyDbApp context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var existingUser = _context.Users.FirstOrDefault(u => u.Email == model.Email);
                if (existingUser != null)
                {
                    ModelState.AddModelError("Email", "In email dar ruyxat hast.");
                    return View(model);
                }

                var user = new User
                {
                    FullName = model.FirstName + " " + model.LastName,
                    Email = model.Email,
                    PasswordHash = model.Password,
                    Role = "Student"
                };

                _context.Users.Add(user);
                _context.SaveChanges();

                TempData["RegisterSuccess"] = "Az ruyxar guzasht";
                return RedirectToAction("Login");

            }

            return View(model);
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = _context.Users
                    .FirstOrDefault(u => u.Email == model.Email && u.Password == model.Password);

                if (user != null)
                {
                    TempData["LoginSuccess"] = "Xush kelibsiz!";
                    return RedirectToAction("Index", "Home");
                }

                ModelState.AddModelError("", "Email yoki parol noto‘g‘ri.");
            }

            return View(model);
        }
    }
}
