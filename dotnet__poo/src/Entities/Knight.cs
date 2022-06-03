using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet__poo.src.Entities
{
    public class Knight : Hero
    {

        public Knight(string name, int level = 0, string herotype = "Knight", string status = "Parado")
        {
            Name = name;
            Level = level;
            HeroType = herotype;
            Status = status;
            
        }
        
    }
}