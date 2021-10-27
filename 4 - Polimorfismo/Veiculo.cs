using System;

namespace Polimorfismo
{
    public abstract class Veiculo : IVeiculo
    {
        public string Marca { get; private set; }
        public string Cor { get; private set; }
        public string Modelo { get; private set; }
        public string Combustivel { get; private set; }

        public Veiculo(string marca, string modelo, string cor, string combustivel)
        {
            this.Marca = marca;
            this.Cor = cor;
            this.Modelo = modelo;
            this.Combustivel = combustivel;
        }

        public virtual void Ligar() {
            processoLigar();
            Console.WriteLine($"O veículo {this.Marca} {this.Modelo} ligou.");
        }
        public void Acelerar() {
            Console.WriteLine($"O veículo {this.Marca} {this.Modelo} acelerou.");
        }
        public void Frear() {
            Console.WriteLine($"O veículo {this.Marca} {this.Modelo} freou.");
        }
        public void Desligar() {
            Console.WriteLine($"O veículo {this.Marca} {this.Modelo} desligou.");
        }

        private void processoLigar() {
            Console.WriteLine("-    Colocar chave na ignição.");
            Console.WriteLine("-    Girar a chave.");
        }
    }
}