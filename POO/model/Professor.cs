using static System.Console;
namespace POO.model
{
    public class Professor : Pessoa 
    {
        public int Salario { get; set;}

        public Professor(string nome, int idade, int salario) : base( nome, idade)
        {
            this.Salario = salario;
            
        }

        public override void Apresentar()
    {
        WriteLine($"Olá, meu nome é  {this.GetNome()} e ganho {this.Salario} trabalhando na escola como professor");
    }
    }   
}