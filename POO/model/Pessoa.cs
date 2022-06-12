using static System.Console;
namespace POO.model
{

    public class Pessoa
    {
        private readonly string Nome = "Thiago";
        public int Idade { get; set; }
        public Pessoa()
        {
            //this.Nome = string.Empty; //Vai assumir "Thiago"
            this.Idade = 0;

        }

        public Pessoa(string nome, int idade)
        {
            this.Nome = nome;
            this.Idade = idade;
        }

        public string GetNome()
        {
            return this.Nome;
        }

        public virtual void Apresentar()
        {
            WriteLine($"Olá, sou uma Pessoa, meu nome é {Nome} e tenho {Idade} anos");
        }
    }
}