using System;
namespace Polimorfismo
{
    public class Aviao : Veiculo
    {
        public int NumeroDeTurbinas { get; private set;}
        public Aviao(string marca, string modelo, string cor, string combustivel, int turbinas) 
        : base(marca, modelo, cor, combustivel)
        {
            this.NumeroDeTurbinas = turbinas;
        }

        public override void Ligar() {
            Console.WriteLine($"O avião {this.Marca} {this.Modelo} ligou.");
        }
    }
}