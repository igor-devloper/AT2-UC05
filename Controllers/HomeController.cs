using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AT2_UC05.Models;
using MVC.models;

namespace AT2_UC05.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
          public IActionResult Pedido()
    {
      return View();
    }
    [HttpPost]
    public IActionResult Pedido(string descricao, float valor_unitario, int quantidade)
    {
      Dados.PedidoAtual.AddPedido(descricao, valor_unitario,quantidade);
      return RedirectToAction("Carrinho");
    }
    public IActionResult Carrinho()
    {
      List<ItemPedido> pedidos = Dados.PedidoAtual.InfosDoPedido();
      return View(pedidos);
      
    }
   

    private IActionResult View(Func<IActionResult> pedido)
    {
      throw new NotImplementedException();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
