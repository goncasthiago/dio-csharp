using static System.Console;
namespace POO.model
{
    
public class Pessoa
{
    public string Nome { get; set; }
    public int Idade {get; set;}
    
    public virtual void Apresentar()
    {
        WriteLine($"Olá, sou uma Pessoa, meu nome é {Nome} e tenho {Idade} anos");
    }
}
}