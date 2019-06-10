using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContaConmigo.Data;


namespace ContaConmigo.Controllers
{
    public class AppController : Controller
    {
        // private readonly IMailService _mailService;
        private readonly ContaContext _context;

        public AppController(ContaContext context)
        {
            _context = context;
        }
        public IActionResult DonorList()
        {
            var results = _context.Donors
                .OrderBy(p => p.Last_Name_Don)
                .ToList();

            return View(results.ToList());
        }

    }
}
