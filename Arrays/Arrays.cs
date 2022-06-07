using static System.Console;
using Arrays;
using System.Collections.Generic;
using System.Collections;

//PrimeiraAula();
//SegundaAula();
//TerceiraAula();
//QuartaAula();
//QuintaAula();
//SextaAula();
SetimaAula();

void SetimaAula()
{
int[] numeros = {5,10,8,3,6,12};

//Query
var numQuery1 = 
from num in numeros
where num % 2 == 0
orderby num
select num;

WriteLine(numQuery1);

var NumerosParesMetodo = numeros.Where(x => x % 2 == 0).OrderBy(x => x).ToList();
WriteLine(NumerosParesMetodo);

WriteLine($"numQuery1 = {String.Join(", ",numQuery1)}");
WriteLine($"NumerosParesMetodo = {String.Join(", ",NumerosParesMetodo)}");

}

void SextaAula() //Dictionary
{
    Dictionary<string,string> estados = new Dictionary<string, string>();

    estados.Add("SP","São Paulo");
    estados.Add("RJ","Rio de Janeiro");
    estados.Add("MG","Minas Gerais");

    foreach (KeyValuePair<string,string> item in estados) // percorrendo o dictionary
    {
        WriteLine($"Chave: {item.Key} - Valor: {item.Value}");
    }

    WriteLine(estados["RJ"]);//Buscando o valor no dictionary

    estados["RJ"] = "RJ - Atualizado";
    WriteLine(estados["RJ"]);

    estados.Remove("RJ");

    string encontrar = "RJ";

    if (estados.TryGetValue(encontrar, out string estadoencontrado))
    {
        WriteLine($"Estado encontrado: {estadoencontrado}");

    }
    else
    {
        WriteLine($"Chave: {encontrar}, não encontrada!");
    }

}


void QuintaAula() //Queue e Stacks
{

//Queues
Queue<string> fila = new Queue<string>();

fila.Enqueue("Thiago");
fila.Enqueue("Juliana");
fila.Enqueue("Arthur");

while (fila.Count > 0)
{
    WriteLine($"O próximo é: {fila.Peek()}");
    WriteLine($"{fila.Dequeue()} atendido");
}
WriteLine($"Pessoas na fila: ${fila.Count}");

//Stack

Stack<string> pilha = new Stack<string>();

pilha.Push("Thiago");
pilha.Push("Juliana");
pilha.Push("Arthur");

System.Console.WriteLine($"Clientes na fila: {pilha.Count()}");
while (pilha.Count() > 0)
{
    System.Console.WriteLine($"Próximo: {pilha.Peek()}");
    System.Console.WriteLine($"{pilha.Pop()} atendido com sucesso!");
}
System.Console.WriteLine($"Clientes na fila: {pilha.Count()}");
}

void QuartaAula() //List
{
    List<string> estados = new List<string>();
    //adicionando os estados
    estados.Add("SP");
    estados.Add("RS");
    estados.Add("MG");
    estados.Add("RJ");

    WriteLine($"Quantidade de estados: {estados.Count}");
    //imprimindo na tela com foreach
    foreach (var item in estados)
    {
        WriteLine(item);
        
    }
    //removendo um estado, a List arruma os índices automaticamente
    estados.Remove("MG");
    WriteLine(String.Join(", ", estados));
    string[] outrosEstadosI = new string[2]{"BA", "ES"};
    string[] outrosEstadosII = new string[2]{"MA", "PR"};
    //adicionando um array na list
    estados.AddRange(outrosEstadosI);
    WriteLine(String.Join(", ", estados));
    //adicionando um array na list por index
    estados.InsertRange(2,outrosEstadosII);
    WriteLine(String.Join(", ", estados));

    for (int i = 0; i < estados.Count; i++)
    {
        WriteLine($"Índice - {i}, Valor - {estados[i]}");
    }



}

void TerceiraAula()//Arrays
{
BubbleSort list3 = new BubbleSort(new int[15]{0,3,4,10,8,7,36,88,5,6,44,31,78,6,1});
list3.OrdenarArray();

//Copiando Arrays
int[] list4 = new int[20];
list3.Copiar(list4);

//Encontrando elemento do Array
WriteLine($"O valor 10 existe no Array list3? {list3.Existe(10)}");

//Verificando Elementos no Array
WriteLine($"Todos os valores da list3 são maiores que 10? {list3.TodosMaiorQue(10)}");
WriteLine($"Todos os valores da list3 são maiores que 101? {list3.TodosMaiorQue(101)}");

//Encontrado o valor no Array

WriteLine($"Valor encontrado {list3.ObterValor(0)}");
WriteLine($"Valor encontrado {list3.ObterValor(10)}");
WriteLine($"Valor encontrado {list3.ObterValor(1012)}");

//Encontrado o indice no Array
WriteLine($"Índice encontrado {list3.ObterIndice(0)}");
WriteLine($"Índice encontrado {list3.ObterIndice(10)}");
WriteLine($"Índice encontrado {list3.ObterIndice(1012)}");

//Redimensionar Array

WriteLine(list4.Length);
list3.RedimensionaArray(ref list4,35);
WriteLine(list4.Length);
}

void  SegundaAula()
{

//Criando as instancias list1 e list2 da Classe BubbleSort
BubbleSort list1 = new BubbleSort(new int[15]{2,3,4,10,8,7,36,88,5,6,44,31,78,6,1});
BubbleSort list2 = new BubbleSort(new int[15]{2,3,4,10,8,7,36,88,5,6,44,31,78,6,1});

list1.Organiza();
list2.OrdenarBubbleSort();

}


 void PrimeiraAula()
{
    
        int[] lista = new int[5];

        for (int i = 0; i < lista.Length; i++)
        {
            lista[i] = i;
        }

        WriteLine("Array Unidimensional");

        foreach (var item in lista)
        {
            WriteLine(item);
        }

        int[,] listaBidimensional = new int[3, 5];

        int numero = 0;

        for (int i = 0; i < listaBidimensional.GetLength(0); i++)
        {
            for (int j = 0; j < listaBidimensional.GetLength(1); j++)
            {
                listaBidimensional[i, j] = numero;
                numero++;
            }
        }

        WriteLine("Array Bidimensional");
        WriteLine("Foreach: ");


        foreach (var item in listaBidimensional)
        {
            WriteLine(item);

        }
        WriteLine("For: ");

        for (int i = 0; i < listaBidimensional.GetLength(0); i++)
        {
            for (int j = 0; j < listaBidimensional.GetLength(1); j++)
            {
                WriteLine($"linha: {i} - coluna: {j}");
                WriteLine(listaBidimensional[i, j]);
            }

        }

        WriteLine("Desenhando a Matrix");
        for (int i = 0; i < listaBidimensional.GetLength(0); i++)
        {
            if (i == 0) Write("[");
            Write("[");
            for (int j = 0; j < listaBidimensional.GetLength(1); j++)
            {
                if (j == listaBidimensional.GetLength(1) - 1)
                {
                    Write($"{listaBidimensional[i, j]}");
                }
                else
                {
                    Write($"{listaBidimensional[i, j]},");
                }
            }

            if (i == listaBidimensional.GetLength(0) - 1)
            {
                Write("]");
                Write("]");
            }
            else
            {
                WriteLine("],");
            }

        }

}


