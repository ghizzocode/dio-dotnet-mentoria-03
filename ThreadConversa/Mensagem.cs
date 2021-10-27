using System;

namespace ThreadConversa
{
    public abstract class Mensagem
    {
        public Object Conteudo { get; set; }
        public DateTime DataHora { get; private set; }
        public Identidade Emissor { get; private set; }
        public string Id { get; private set; }
        public TipoMensagem Tipo { get; set; }

        public Mensagem(Object conteudo)
        {
            this.Id = Guid.NewGuid().ToString();
            this.Conteudo = conteudo;
            this.DataHora = DateTime.Now;
        }

        public Mensagem(string id, Object conteudo, Identidade emissor)
        {
            this.Id = id;
            this.Conteudo = conteudo;
            this.DataHora = DateTime.Now;
            this.Emissor = emissor;
        }
    }
}