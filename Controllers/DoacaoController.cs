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
            ViewData["Title"] = "Doações";
            var doacoes = _context.Doacoes.ToList();
            return View(doacoes);
        }

        public IActionResult Create()
        {
            ViewData["Title"] = "Nova Doação";
            return View("Form");
        }

        [HttpPost]
        public IActionResult Create(Doacao doacao)
        {
            if (_context.Doacoes.Count() > 0)
            {
                var ultimaDoacaoId = _context.Doacoes.OrderBy(d => d.Id).Last().Id;
                doacao.NumeroOficio = (ultimaDoacaoId + 1).ToString();
            } else
            {
                doacao.NumeroOficio = 1.ToString();
            }
            doacao.CriadoEm = DateTime.Now;
            _context.Doacoes.Add(doacao);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
