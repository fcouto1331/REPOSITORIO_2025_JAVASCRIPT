using CAMADA_PRESENTATION_WEB.Interfaces.IServices;
using CAMADA_PRESENTATION_WEB.Utilities;
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

        [HttpGet]
        public IActionResult Todos()
        {
            return View("Todos");
        }

        [HttpPost]
        public async Task<IActionResult> TodosAsync()
        {
            try
            {
                return Json(new { ret = true, msg = Mensagens.sucesso, cliente = await _clienteService.GetAllAsync() });
            }
            catch (Exception)
            {
                return Json(new { ret = false, msg = Mensagens.erro });
            }
        }

        //[HttpGet]
        //public IActionResult Novo()
        //{
        //    return PartialView("_Novo");
        //}
    }
}