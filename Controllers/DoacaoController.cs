using DoacoesICCPVU.Contexts;
using DoacoesICCPVU.Models;
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
            var doacoes = _context.Doacoes.ToList();
            return View(doacoes);
        }
    }
}
