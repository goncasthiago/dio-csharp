namespace dotnet__poo.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string name, int level = 0, string herotype = "Wizard", string status = "Parado")
        {
            Name = name;
            Level = level;
            HeroType = herotype;
            Status = status;
            
        }
        public string Attack()
        {
            return $"{this.Name} lançou uma magia!";
        }
       
    }
}