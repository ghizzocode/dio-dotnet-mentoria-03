using System;
using System.Collections.Generic;

namespace Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Aviao a1 = new Aviao("Avi1", "DX13", "Branco", "Padrão", 2);
            Carro c1 = new Carro("Ford", "Ka", "Vermelho", "Flex", 2);

            List<Veiculo> lista = new List<Veiculo>();
            lista.Add(a1);
            lista.Add(c1);

            a1.Ligar();
            a1.Acelerar();
            a1.Frear();
            a1.Desligar();
            
            c1.Ligar();
            c1.Acelerar();
            c1.Frear();
            c1.Desligar();
        }
    }
}
