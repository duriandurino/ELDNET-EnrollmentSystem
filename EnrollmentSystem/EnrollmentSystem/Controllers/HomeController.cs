using EnrollmentSystem.Data;
using EnrollmentSystem.Models;
using EnrollmentSystem.Models.Dto;
using EnrollmentSystem.Models.Entities;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Security.Claims;
using Microsoft.AspNetCore.Http;

namespace EnrollmentSystem.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext dbContext;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext dbContext, IHttpContextAccessor httpContextAccessor)
        {
            _logger = logger;
            this.dbContext = dbContext;
            _httpContextAccessor = httpContextAccessor;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginDto model)
        {
            if (ModelState.IsValid)
            {
                var user = await dbContext.Users.FirstOrDefaultAsync(u => u.username == model.username);
                if (user != null && model.password == user.password)
                {
                    await SignInUserAsync(user);

                    HttpContext.Session.SetString("IsLoggedIn", "true");

                    return RedirectToAction(nameof(Index));
                    
                }
                ModelState.AddModelError(string.Empty, "Invalid login attempt.");
            }
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            HttpContext.Session.Remove("IsLoggedIn");
            return RedirectToAction(nameof(Login));
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        private async Task SignInUserAsync(User user)
        {
            var claims = new List<Claim>
        {
            new Claim(ClaimTypes.NameIdentifier, user.user_id.ToString()), 
            new Claim(ClaimTypes.NameIdentifier, user.username),
        };

        }
    }
}