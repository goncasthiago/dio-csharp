using System;
namespace Revisao{

    class Program{
        static void Main(string[] args)
        {
            Aluno[] alunos = new Aluno[5];
            var indiceAluno = 0;
            decimal notas = 0;
            int quantidadeAlunos = 0;
            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        Console.WriteLine("Informe o nome do aluno:");
                        Aluno aluno = new Aluno();
                        aluno.Nome = Console.ReadLine();
                        Console.WriteLine("Informe a nota do aluno:");
                        if ( decimal.TryParse(Console.ReadLine(), out decimal nota))
                        {

                        aluno.Nota = nota ;
                        }
                        else
                        {
                            throw new ArgumentException("O valor da nota deve ser decimal!");
                        }

                        alunos[indiceAluno] = aluno;
                        indiceAluno++;


                        break;
                    case "2":
                        foreach (var al in alunos)
                        {
                            //if(al.Nome == null) continue;
                            if(string.IsNullOrEmpty(al.Nome)) continue;
                            Console.WriteLine($"Aluno: {al.Nome} - Nota: {al.Nota}");
                        }

                        break;
                    case "3":
                        foreach (var al in alunos)
                        {
                            if(string.IsNullOrEmpty(al.Nome)) continue;
                            notas += al.Nota;
                            quantidadeAlunos += 1;                            
                        }

                        Console.WriteLine($" Média das notas foi: {notas/quantidadeAlunos}");
                        quantidadeAlunos = 0;
                        notas = 0 ;

                        break;
                        throw new ArgumentOutOfRangeException();

                }

                opcaoUsuario = ObterOpcaoUsuario();




            }


        }

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine("Informe a opção desejada:");
            Console.WriteLine("1- Inserir novo aluno");
            Console.WriteLine("2- Listar todos os alunos");
            Console.WriteLine("3- Calcular média geral");
            Console.WriteLine("X - Sair...");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine();
            return opcaoUsuario;
        }
    }
}

