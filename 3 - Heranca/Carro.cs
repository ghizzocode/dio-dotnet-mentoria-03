namespace Heranca
{
    public class Carro : Veiculo
    {
        public int NumeroDePortas { get; private set;}
        public Carro(string marca, string modelo, string cor, string combustivel, int portas) 
        : base(marca, modelo, cor, combustivel)
        {
            this.NumeroDePortas = portas;
        }
    }
}