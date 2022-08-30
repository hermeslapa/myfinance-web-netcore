using Microsoft.AspNetCore.Mvc;

using myfinance_web_netcore.Domain;
namespace myfinance_web_netcore.Controllers
{
    public class TransacaoController : Controller
    {
        private readonly ILogger<TransacaoController> _logger;

        public TransacaoController(ILogger<TransacaoController> logger)
        {
            _logger = logger;
        }

         public IActionResult Index()
        {
            var transacao = new Transacao();
            ViewBag.Lista = transacao.ListaTransacoes();
            return View();
        }

    
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}