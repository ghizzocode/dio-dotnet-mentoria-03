namespace Heranca
{
    public class Aviao
    {
        public int NumeroDeTurbinas { get; private set;}
        public Carro(string marca, string modelo, string cor, string combustivel, int turbinas) 
        : base(marca, modelo, cor, combustivel)
        {
            this.NumeroDeTurbinas = turbinas;
        }
    }
}