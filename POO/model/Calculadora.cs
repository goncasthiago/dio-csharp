using POO.interfaces;
using static System.Console;

namespace POO.model
{
    public class Calculadora : ICalculadora
    {
        //Delegate
        public delegate void DelegateCalculadora();
        //Declarando um evento
        public static event DelegateCalculadora EventoCalculadora;
        public int Dividir(int num1, int num2)
        {
            if (num2 != 0) return num1 / num2;
            else return 0;
        }

        public int Multiplicar(int num1, int num2)
        {
            return num1 * num2;
        }

        public int Somar(int num1, int num2)
        {
            return num1 + num2;
        }
        public static void Soma(int num1, int num2)
        {
            if (EventoCalculadora != null)
            {
                WriteLine($"Adição: {num1 + num2}");
                EventoCalculadora();
            }
            else
            {
                WriteLine("Nenhum inscritoo no evento");
            }
        }
        public static void Subtrai(int num1, int num2)
        {
            WriteLine($"Subtração: {num1 - num2}");
        }

        public int Subtrair(int num1, int num2)
        {
            return num1 - num2;
        }
    }
}