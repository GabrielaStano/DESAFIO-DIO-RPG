namespace RPG.src.Entities
{
    public class Ninja : Hero
    {
        public Ninja(string Name, int Level, string HeroType) : base(Name, Level, HeroType)
        {
            this.Name=Name;
            this.Level=Level;
            this.HeroType=HeroType;
        }

        public override string Attack()
        {
            return this.Name + " atacou com sua Lâmina giratória.";
        }
    }
}