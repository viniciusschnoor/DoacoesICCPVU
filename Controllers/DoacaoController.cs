using DoacoesICCPVU.Contexts;
using Microsoft.AspNetCore.Mvc;

namespace DoacoesICCPVU.Controllers
{
    public class DoacaoController : Controller
    {
        private readonly DoacaoContext _context;

        public DoacaoController(DoacaoContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            ViewData["Title"] = "Doações";
            var doacoes = _context.Doacoes.ToList();
            return View(doacoes);
        }
    }
}
