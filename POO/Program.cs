using POO.model;
using static System.Console;

class Program
{
        public delegate void Operacao(int x, int y);
    static void Main()
    {
        //Trabalhando com eventos
        Matematica m = new Matematica(10, 20);
        WriteLine("EventHandler");
        m.Somar();

        //Trabalhando com Delegates
        Operacao op = new Operacao(Calculadora.Soma);
        op += Calculadora.Subtrai;
        WriteLine("Rodando o delegate");
        op.Invoke(10,10);
        //op(10,10);
        Log log = Log.GetInstance();
        log.mensagem = "Teste de mensagem";

        Log log2 = Log.GetInstance();

        WriteLine(log2.mensagem);

        Calculadora calc = new Calculadora();
        WriteLine(calc.Somar(1, 2));
        WriteLine(calc.Multiplicar(3, 2));
        Corrente c1 = new Corrente();
        c1.Creditar(100);
        c1.ExibirSaldo();

        Pessoa p1 = new Pessoa();
        //p1.Nome = "Thiago";
        p1.Idade = 38;

        p1.Apresentar();

        Pessoa arthur = new Pessoa(
        "Arthur",
        8
        );

        Pessoa juliana = new Pessoa
        (
            "Juliana",
            38
        );
        

        arthur.Apresentar();
        juliana.Apresentar();

        Aluno p2 = new Aluno(
        "Arthur",
        8,
        10
        );
        p2.Apresentar();

        Professor p3 = new Professor(
        "Juliana",
        38,
         3000
        );

        p3.Apresentar();

        //Conta c1 = new Conta(); // Nao  é possivel criar por ser aabstrata
    }


}
