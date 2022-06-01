using static System.Console;

int a = 2; //value type comparam os valores
int b = 2;

if (a ==b)
{
    WriteLine("a e b são iguais");
}
else
{
    WriteLine("a e b são diferentes");
}

Numeros a2 = new Numeros(2); //reference types comparam locais de memoria
Numeros b2 = new Numeros(2);


if (a2== b2)
{
    WriteLine("a2 e b2 são iguais");
}
else
{
    WriteLine("a2 e b2 são diferentes");
}

if (a2.N == a)
{
    WriteLine("a2.N e a são iguais");
}
else
{
    WriteLine("a2.N e a são diferentes");
}

public class Numeros
{
    public int N {get; set;}
    public Numeros( int n)
    {
        N = n;
    }
}
