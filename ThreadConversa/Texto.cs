namespace ThreadConversa
{
    public class Texto : Mensagem
    {
        public Texto(string conteudo) : base(conteudo)
        {
            this.Tipo = TipoMensagem.TEXTO;
        }

        public Texto(string id, string conteudo, Identidade emissor)
        : base(id, conteudo, emissor)
        {
            this.Tipo = TipoMensagem.TEXTO;
        }
    }
}