using static System.Console;

namespace POO.model
{

    public class Corrente : Conta
    {
        public override void Creditar(double valor)
        {
            base.Saldo += valor;
        } 

        
        
    }
    
}