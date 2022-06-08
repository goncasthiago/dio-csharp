using static System.Console;
using Erros.src;

int a = 100, b = 0;
double resultado=0;
try
{
resultado = (Dividir(a,b));
WriteLine($"O resultado da divisão de {a} por {b} é {resultado}");

}
catch(DivideByZeroException zero) //when (a < 0) //apenas para testar o when
{
    WriteLine($"Erro na divisao: {zero.Message}");
    resultado = -1;

}
catch(Exception exception)
{
    WriteLine($"Erro generico: {exception.Message}");

}
finally
{
    WriteLine("Divisão finalizada");
}

double Dividir(int x, int y)
{
    //if (y == 0) throw new ArithmeticException();
    if (y == 0) throw new TratativaErrosException("Minha mensagem customizada de erro!");
    return x/y;
}