using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO.model
{
    public class Matematica
    {
        public int X {get; set;}
        public int Y {get; set;}
        public Matematica(int x, int y)
        {
            X = x;
            Y = y;

            Calculadora.EventoCalculadora += EventHandler;
        }

        public void Somar()
        {
            Calculadora.Soma(X, Y);
        }

        public void EventHandler()
        {
            WriteLine($"Executou um evento com os valores: {X} e {Y}");
        }
    }
}