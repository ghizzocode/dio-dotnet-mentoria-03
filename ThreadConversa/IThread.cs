using System.Collections.Generic;

namespace ThreadConversa
{
    public interface IThread
    {
         public IEnumerable<Mensagem> AdicionaMensagem(Mensagem msg);
    }
}