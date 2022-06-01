using static System.Console;
namespace ChaveRef;
class ChaveRef
{
    static void Demo1()
    {
        int a = 0;
        //mesmo sendo value type, ao passar o ref, ele passa a referencia 
        //e a variavel a do funcao é a mesma do Main
        Adicionar20(ref a);
        WriteLine($"O valor de a é: {a}!");
    }

    static void Demo2()
    {
        var nomes = new string[]{"Thiago","Juliana","Arthur","Solange"};
        WriteLine($@"A lista de nomes atual é: 
                    {string.Join(", \n",nomes)}");
        WriteLine("");
        WriteLine("Qual nome será substituído?");
        var nome = ReadLine();

        WriteLine("");
        WriteLine("Por qual nome?");
        var nomeNovo = ReadLine();

        AlteraNome(nomes,nome,nomeNovo);
        WriteLine("");
        WriteLine($@"A nova lista de nomes é:
                    {string.Join(", \n",nomes)}");

    }

    static void Adicionar20(ref int a)
    {
        a += 20;
    }

    static void AlteraNome(string[]nomes, string nomeAtual, string nomeNovo)
    {
        for (int i = 0; i < nomes.Length; i++)
        {
            if (nomes[i] == nomeAtual)
            {
                nomes[i] = nomeNovo;
            }
            
        }

    }
    static void Main()
    {

        Pessoa p1 = new Pessoa();
        p1.Nome = "Thiago";
        p1.Idade = 30;
        //p1.Endereco = default;        
        p1.Endereco = new Endereco()
        {
            Logradouro = "Rua Teste",
            Cep = "09178484",
            Cidade = "Santo Andre"
        };
        
        
    }
}