using static System.Console;
using dotnet__poo.src.Entities;

    Knight thiago = new Knight("Thiago", 10, "Knight");
    Wizard arthur = new Wizard("Arthur"); 
    
    WriteLine(thiago.ToString());
    WriteLine(thiago.Attack(1));
    WriteLine(thiago.Attack(8));
    WriteLine(arthur.ToString());
    WriteLine(arthur.Attack());
    WriteLine(arthur.Attack(4));
    WriteLine(thiago.StatusAtual());
    WriteLine(arthur.StatusAtual());
    thiago.Correr();
    WriteLine(thiago.StatusAtual());
    thiago.Dormir();
    WriteLine(thiago.StatusAtual());
