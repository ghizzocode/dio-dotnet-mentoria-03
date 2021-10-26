using System;

namespace Classe
{
    class Program
    {
        static void Main(string[] args)
        {
            var carro1 = new Veiculo("Ford", "Ka", "Prata", "Flex");
            var carro2 = new Veiculo("Volkswagen", "Nivus", "Preto", "Flex");

            carro1.Ligar();
            carro1.Acelerar();
            carro1.Frear();
            carro1.Desligar();

            carro2.Ligar();
            carro2.Acelerar();
            carro2.Frear();
            carro2.Desligar();
        }
    }
}
