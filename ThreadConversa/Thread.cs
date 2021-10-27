using System.Collections.Generic;

namespace ThreadConversa
{
    public class Thread
    {
        public List<Mensagem> Mensagens { get; private set; } 

        public string Origem { get; private set; }
        public string Destino { get; private set; }

        public Thread()
        {
            this.Mensagens = new List<Mensagem>();
        }

        public IEnumerable<Mensagem> AdicionaMensagem(Mensagem msg) => this.AdicionaMensagemNaThread(msg);

        private IEnumerable<Mensagem> AdicionaMensagemNaThread(Mensagem msg) {
            this.Mensagens.Add(msg);
            return this.Mensagens;
        }

        private void AdicionaMensagens(IEnumerable<Mensagem> msgs) {
            this.Mensagens.AddRange(msgs);
        }

        public string MostraThread() {
            string thread = "";
            foreach (var msg in this.Mensagens)
            {
                thread += $"[{msg?.Tipo}] {msg?.Emissor.Nome}: {msg?.Conteudo}\n";
            }
            return thread;
        }
    }
}