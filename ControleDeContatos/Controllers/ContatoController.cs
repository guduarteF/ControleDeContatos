using Microsoft.AspNetCore.Mvc;

namespace ControleDeContatos.Controllers
{
    public class ContatoController : Controller
    {
        //private readonly BancoContext _context;

        //public ContatoController(BancoContext context)
        //{
        //    _context = context;
        //}

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Criar()
        {
            return View();
        }

        public IActionResult Editar()
        {
            return View();
        }

        public IActionResult ApagarConfirmacao()
        {
            return View();
        }

      
           
       
    }
}
