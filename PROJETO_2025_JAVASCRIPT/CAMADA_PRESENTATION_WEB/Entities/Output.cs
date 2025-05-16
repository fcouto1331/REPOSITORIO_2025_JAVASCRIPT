namespace CAMADA_PRESENTATION_WEB.Entities
{
    public class Output
    {
        public Output(bool _ret, string _msg, int _statusCode)
        {
            ret = _ret;
            msg = _msg;
            statusCode = _statusCode;
        }

        public bool ret { get; private set; }
        public string? msg { get; private set; }
        public int statusCode { get; private set; }

        public static Output Get(bool _ret, string _msg, int _statusCode) => new Output(_ret, _msg, _statusCode);

        #region exemplo

            /*
                [HttpPost]
                public async Task<IActionResult> TodosAsync()
                {
                    try
                    {
                        //return Json(new { ret = true, msg = Mensagens.sucesso, cliente = await _clienteService.GetAllAsync() });
                        return Json(new { nome = "todos", output = Output.Get(true, Mensagens.sucesso, (int)HttpStatusCode.OK), cliente = await _clienteService.GetAllAsync() });
                    }
                    catch (Exception)
                    {
                        return Json(new { ret = false, msg = Mensagens.excecao });
                    }
                }
            */

        #endregion
    }
}
