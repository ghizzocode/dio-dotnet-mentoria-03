using System;
using System.IO;

namespace ThreadConversa
{
    class Program
    {
        static void Main(string[] args)
        {
            var thread = new Thread();
            using (var reader = new StreamReader("texto.csv")) {
                while(!reader.EndOfStream) {
                    var line = reader.ReadLine();
                    var values = line.Split(';');

                    Mensagem msg = new Texto(values[0], values[1], new Identidade(values[3]));
                    thread.AdicionaMensagem(msg);
                }
            }
            Console.WriteLine(thread.MostraThread());
        }
    }
}
