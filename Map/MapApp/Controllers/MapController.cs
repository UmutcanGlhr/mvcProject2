using MapApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MapApp.Controllers
{
    public class MapController : Controller
    {
        private readonly RepositoryContext _context;

        public MapController(RepositoryContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var model = _context.Maps.ToList();
            return View(model);
        }

        public IActionResult Get(int ID)
        {
            Map map = _context.Maps.First(p => p.id.Equals(ID));
            return View(map);
        }

        public IActionResult info(int ID)
        {
            Map map = _context.Maps.First(p => p.id.Equals(ID));
            return View(map);
        }
    }
}