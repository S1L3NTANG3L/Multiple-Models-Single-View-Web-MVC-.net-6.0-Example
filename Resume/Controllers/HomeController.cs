using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Resume.Models;
using System.Diagnostics;
using System.Dynamic;

namespace Resume.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly NewsclipDatabaseContext _context;
        public HomeController(NewsclipDatabaseContext context, ILogger<HomeController> logger)
        {
            _context = context;
            _logger = logger;
        }

        // GET: Experiences
        public async Task<IActionResult> Index()
        {
            BigOne myModels = new BigOne();
            myModels.Educations = await _context.Educations.ToListAsync();
            myModels.Experiences = await _context.Experiences.ToListAsync();
            myModels.PersonalInfos = await _context.PersonalInfos.ToListAsync();
            myModels.Skills = await _context.Skills.ToListAsync();
            return View(myModels);
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Skills()
        {
            return View();
        }
        public IActionResult Experiences()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}