using static System.Console;
namespace POO.model
{
    public class Professor : Pessoa 
    {
        public int Salario { get; set;}

        public override void Apresentar()
    {
        WriteLine($"Olá, meu nome é  {Nome} e ganho {Salario} trabalhando na escola como professor");
    }
    }   
}