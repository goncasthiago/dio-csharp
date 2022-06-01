using static System.Console;

namespace ChaveRef
{
    public class Pessoa
    {
        public int Idade {get; set;}
        public string Nome {get; set;}

        public Endereco Endereco {get; set;}
    }

    public struct Endereco{
        public string Logradouro {get; set;}
        public int Numero {get; set;}

        public string Cep {get; set;}

        public string Cidade {get; set;}
    }
}