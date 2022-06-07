using static System.Console;
using static System.Array;

namespace Arrays
{
    public class BubbleSort
    {
        public int[] List { get; set; }

        public BubbleSort(int[] list)
        {
            List = list;
        }

        public override string ToString(){
            //Console.WriteLine($"{String.Join(",",this.List)}");
            return $"{String.Join(", ",this.List)}";
        }

        public void Organiza()
        {   Console.WriteLine(this.ToString());
            int loops = 0;
            bool desorganizado = true;
            int troca;
            int final = this.List.Length;
            while(desorganizado)
            {
                desorganizado = false;
                for (int i = 0; i < final-1; i++)
                {
                        loops++;
                    if (this.List[i] > this.List[i+1])
                    {
                        //Console.WriteLine($"Trocou o {this.List[i]} por {this.List[i+1]}");
                        troca = this.List[i];
                        this.List[i] = this.List[i+1];
                        this.List[i+1] = troca;
                        desorganizado = true;
                    }
                    
                }
                //Console.Write($"{String.Join(",",this.List)}");
                final--;
                //Console.WriteLine($"   - final: {final}");
                //Console.WriteLine($"Teve alteração: {desorganizado}");
            }
            Console.WriteLine($"{loops} ciclos");
            Console.WriteLine(this.ToString());
        }

        public void OrdenarBubbleSort()
        {
            Console.WriteLine(this.ToString());
            int loops = 0;
            int temp = 0;
            for (int i = 0; i < this.List.Length; i++)
            {
                for (int j = 0; j < this.List.Length-1; j++)
                {
                        loops++;
                    if(this.List[j] > this.List[j +1])
                    {
                        temp = this.List[j+1];
                        this.List[j+1] = this.List[j];
                        this.List[j] = temp;
                    }
                }
                
            }
            Console.WriteLine($"{loops} ciclos");
            Console.WriteLine(this.ToString());
        }

        public void OrdenarArray()
        {
            Console.WriteLine(this.ToString());
            Array.Sort(this.List);
            Console.WriteLine(this.ToString());
        }

        public void Copiar( int[] arrayDestino)
        {
            WriteLine("Array antes da cópia");
            WriteLine(String.Join(", ", arrayDestino));
            Array.Copy(this.List, arrayDestino, this.List.Length);
            WriteLine("Array depois da cópia");
            WriteLine(String.Join(", ", arrayDestino));
            
        }
        
        public bool Existe(int valor)
        {
            return Array.Exists(this.List, elemento => elemento == valor);
        }
    
        public bool TodosMaiorQue(int valor)
        {
            return Array.TrueForAll(this.List, elemento => elemento < valor);
        }

        public int ObterValor(int valor)
        {
            return Array.Find(this.List, elemento => elemento == valor);

        }
        public int ObterIndice(int valor)
        {
            return Array.IndexOf(this.List, valor);

        }

        public void RedimensionaArray(ref int[] array,  int valor)
        {
            Array.Resize(ref array, valor);

        }
    }
}