namespace CAMADA_PRESENTATION_WEB.Entities
{
    public class Cliente
    {
        public Guid ClienteId { get; private set; }

        public string? Nome { get; private set; }
        public void alterarNome(string nome)
        {
            if(!String.IsNullOrEmpty(nome)) Nome = nome.Length > 200 ? Nome = String.Concat(nome.Substring(0, 187), "...") : nome;
        }
    }
}
