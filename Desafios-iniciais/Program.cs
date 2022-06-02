//Abaixo segue um exemplo de código que você pode ou não utilizar
using System;

//Console.WriteLine("Media");
//Media();
//Console.WriteLine("Volume");
//Volume();
//Console.WriteLine("Perimetro");
//Perimetro();
Console.WriteLine("Maior Valor");
MaiorValor();

static void Media()
{
    double A, B, C;
    Console.WriteLine("Digite a nota A");
    A = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite a nota B");
    B = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite a nota C");
    C = double.Parse(Console.ReadLine());

    double media = ((A * 2) + (B * 3) + (C * 5)) / 10;

    //TODO: Complete os espaços em branco com uma possível solução para o desafio
    Console.WriteLine($"MEDIA = {media:N1}");
    Console.WriteLine("Clique para o próximo cálculo");
    Console.ReadKey();
}

static void Volume()
{

    double pi, raio, volume;
    pi = 3.14159;
    //TODO: Complete os espaços em branco com uma possível solução para o desafio     
    Console.WriteLine("Digite o raio da circuferência:");
    raio = double.Parse(Console.ReadLine());
    volume = pi * (4.0 / 3) * Math.Pow(raio, 3);

    Console.WriteLine($"VOLUME = " + String.Format("{0:0.000}", volume));//{volume:N3}");
}

static void Perimetro()
{
    //TODO: Complete os espaços em branco com uma possível solução para o desafio
    Console.WriteLine("Digite o numero de lados e depois o comprimento do lado, separados por um espaço");
    string[] v = Console.ReadLine().Split();
    Console.WriteLine(int.Parse(v[0]) * int.Parse(v[1]));
}

static void MaiorValor()
{
    //TODO: Complete os espaços em branco com uma possível solução para o desafio
    int n;
    int maior = 0;
    int posicao = 0;
    int[] numeros = {
                86371,
47686,
96720,
31060,
1979,
39970,
31643,
15529,
50837,
10742,
14155,
79838,
54250,
5130,
14965,
69860,
4223,
34293,
909,
12933,
72245,
82253,
8971,
23675,
16505,
31563,
93237,
19458,
89614,
51621,
4337,
26643,
8202,
33110,
72310,
25074,
91686,
58313,
91889,
35267,
20618,
4082,
89220,
94047,
76844,
2085,
92022,
81629,
94518,
19435,
91665,
18528,
16882,
16664,
47999,
81886,
68815,
18329,
74299,
71248,
45439,
53642,
89107,
81801,
27373,
47199,
68767,
23668,
80736,
47792,
71007,
96617,
88660,
22351,
13849,
85925,
48972,
64360,
39784,
91623,
55228,
28268,
37836,
41239,
46979,
49646,
70246,
79090,
16957,
60374,
41993,
5598,
1006,
70734,
89654,
86517,
11900,
17848,
66910,
35001,
10,
                };
    for (int i = 1; i <= 100; i++)
    {
        //n = Convert.ToInt32(Console.ReadLine());
        n = numeros[i];
        if (n > maior)
        {
            maior = n;
            posicao = i;
        }
    }
    Console.WriteLine(maior);
    Console.WriteLine(posicao);
}



