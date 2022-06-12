using static System.Console;
namespace POO.model
{
    public class Aluno : Pessoa
    {
        public int Nota {get; set;}

        public Aluno(string nome, int idade, int nota) : base( nome, idade)
        {
            this.Nota = nota;
            
        }
    public override void Apresentar()
    {
        WriteLine($"Olá, sou o Aluno {this.GetNome()} e tirei nota {this.Nota}");
    }
    }

    
}