using POO.model;
using static System.Console;

class Program
{
    static void Main()
    {
        Calculadora calc = new Calculadora();
        WriteLine(calc.Somar(1,2));
        WriteLine(calc.Multiplicar(3,2));
        Corrente c1 = new Corrente();
        c1.Creditar(100);
        c1.ExibirSaldo();
        
        Pessoa p1 = new Pessoa();
        p1.Nome = "Thiago";
        p1.Idade = 38;

        p1.Apresentar();

        Aluno p2 = new Aluno();
        p2.Nome = "Arthur";
        p2.Idade = 8;
        p2.Nota = 10;

        p2.Apresentar();

        Professor p3 = new Professor();
        p3.Nome = "Juliana";
        p3.Idade = 38;
        p3.Salario = 3000;
        p3.Apresentar();

        //Conta c1 = new Conta(); // Nao  é possivel criar por ser aabstrata
    }


}
