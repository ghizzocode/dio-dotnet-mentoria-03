using System;

namespace Heranca
{
    public abstract class Veiculo : IVeiculo
    {
        private string Marca { get; set; }
        private string Cor { get; set; }
        private string Modelo { get; set; }
        private string Combustivel { get; set; }

        public Veiculo(string marca, string modelo, string cor, string combustivel)
        {
            this.Marca = marca;
            this.Cor = cor;
            this.Modelo = modelo;
            this.Combustivel = combustivel;
        }

        public void Ligar() {
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