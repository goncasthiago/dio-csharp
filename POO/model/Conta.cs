using static System.Console;

namespace POO.model
{
    public abstract class Conta
    {
        protected double Saldo;
        public abstract void Creditar(double valor);
        public void ExibirSaldo()
        {
            WriteLine($"Seu saldo é: {Saldo}");

        }
    }
    
}