namespace ThreadConversa
{
    public class Imagem : Mensagem
    {
        public Imagem(byte[] conteudo) : base(conteudo)
        {
            this.Tipo = TipoMensagem.IMAGEM;
        }

        public Imagem(string id, byte[] conteudo, Identidade emissor)
        : base(id, conteudo, emissor)
        {
            this.Tipo = TipoMensagem.IMAGEM;
        }
    }
}