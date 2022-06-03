
namespace dotnet__poo.src.Entities
{
    public abstract class Hero
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public string HeroType { get; set; }

        public string Status { get; set; }
        
        public Hero(){}
        public Hero(string name, int level = 0, string herotype = "", string status = "Parado")
        {
            Name = name;
            Level = level;
            HeroType = herotype;
            Status = status;
            
        }


        public override string ToString(){
            return $"{this.Name} - LV: {this.Level} - HT: {this.HeroType}";
        }

        public virtual string Attack()
        {
            return $"{this.Name} efetuou um ataque!";
        }

        public virtual string Attack(int bonus)
        {
            if(bonus > 6){
                return $"{this.Name} efetuou um ataque super efetivo com {bonus} pontos de bônus!";
            }
            return $"{this.Name} efetuou um ataque normal com {bonus} pontos de bônus!";
        }

        public virtual string StatusAtual(){
            return $"{this.Name} está {this.Status}";
        }

        public void Correr(){
            this.Status = "Correndo";
        }
        
        
        public void Dormir(){
             this.Status = "Dormindo";
        }

        
        public void Parar(){
             this.Status = "Parado";
        }

        public void Esconder(){
            this.Status = "Escondido";
        }
        
    }
}