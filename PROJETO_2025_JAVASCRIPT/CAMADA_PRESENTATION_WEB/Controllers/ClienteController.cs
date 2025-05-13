using CAMADA_PRESENTATION_WEB.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace CAMADA_PRESENTATION_WEB.Controllers
{
    public class ClienteController : Controller
    {
        private readonly IClienteService _clienteService;
        public ClienteController(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        public IActionResult Todos()
        {
            var clientes = _clienteService.GetAll();
            return View("Todos");
        }
    }
}
