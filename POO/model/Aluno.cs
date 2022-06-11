using static System.Console;
namespace POO.model
{
    public class Aluno : Pessoa
    {
        public int Nota {get; set;}
    public override void Apresentar()
    {
        WriteLine($"Olá, sou o Aluno {Nome} e tirei nota {Nota}");
    }
    }

    
}