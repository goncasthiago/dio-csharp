using static System.Console;

namespace Referencia{

    public class Program{

        static void Demo1()
        {
            int a = 2;
            a = Adiciona20(a);
            WriteLine($"O valor de a é {a}");

        }

        static void Demo2()
        {
            
            Pessoa p1 = new Pessoa();
            p1.Nome = "Thiago";
            p1.Idade = 38;
            p1.Documento = "12345";

            /*
            Pessoa p2 = new Pessoa();
            p2.Nome = p1.Nome;
            p2.Idade = p1.Idade;
            p2.Documento = p1.Documento;
            */
            Pessoa p2 = p1.Clone();

            TrocarNome(p1, "Arthur");
            
            Console.WriteLine($@"
            O nome de p1 é {p1.Nome}
            O nome de p2 é {p2.Nome}");
         

        }

        static void Demo3()
        {

            StructPessoa p1 = new StructPessoa(){
                Nome = "Thiago",
                Idade = 38,
                Documento = "1234"
            };

            var p2 = p1;

            p1 = TrocarNome(p1, "Arthur");

            Console.WriteLine($@"
            O nome de p1 é {p1.Nome}
            O nome de p2 é {p2.Nome}");


        }

        static void Demo4()
        {
             string nome = "Thiago";
            nome = TrocarNome(nome, "Arthur");    
            WriteLine($@"O nome é {nome}");    
        }

        static void Demo5()
        {
            int[] pares = new int[]{0,2,4,6,8};
           MudarparaImpar(pares);
            WriteLine($"O Array é o {string.Join(",",pares)}");
        }

        static void Demo6()
        {
            int[] pares = new int[]{0,2,4,6,8};
           WriteLine("Digite o número que gostaria de encontrar: ");
           var numero = int.Parse(ReadLine());
           var idxEncontrado = EncontrarNumero(pares, numero);
           
           if (idxEncontrado >=0)
           {
               WriteLine($"O número {numero} foi encontrado na posição {idxEncontrado}");
           }
           else
           {
               WriteLine($"O número {numero} não foi encontrado");

           }
        }

        static int Adiciona20(int a)
        {
            return a + 20;
        }

        static void TrocarNome( Pessoa p1, string nomeNovo)
        {
            p1.Nome = nomeNovo;
        }

        static StructPessoa TrocarNome( StructPessoa p1, string nomeNovo)
        {
            p1.Nome = nomeNovo;
            return p1;
        }

        static string TrocarNome(string nome, string nomeNovo)
        {
            nome = nomeNovo;
            return nome;
        }

        static void MudarparaImpar(int[] pares)
        {
            for (int i = 0; i < pares.Length; i++)
            {   
                pares[i] = pares[i] + 1;
                
            }
        }

        static int EncontrarNumero(int[] numeros, int numero)
        {
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] == numero)
                {
                    return i;   
                }
            }
            return -1;
        }

        static bool EncontrarPessoa(List<Pessoa> pessoas, Pessoa Bpessoa)
        {
            foreach (var pessoa in pessoas)
            {
                if(pessoa.Nome == Bpessoa.Nome)
                {
                    return true;
                }
                
            }

            return false;
        }

        public static void Main()
        {

            List<Pessoa> pessoas = new List<Pessoa>()
            {
                new Pessoa(){Nome = "Thiago"},
                new Pessoa(){Nome = "Arthur"},
                new Pessoa(){Nome = "Juliana"},
                new Pessoa(){Nome = "Sandra"},
                new Pessoa(){Nome = "Solange"}
            };

            WriteLine("Digite a pessoa que gostaria de encontrar");
            var nome = ReadLine();
            var pessoa = new Pessoa(){Nome = nome};

            var testePessoa = EncontrarPessoa(pessoas,pessoa);

             if (testePessoa)
           {
               WriteLine($"A pessoa, {pessoa.Nome}, foi encontrada");
           }
           else
           {
               WriteLine($"A pessoa, {pessoa.Nome} não foi encontrada");

           }
           
        }

        
    }
}
