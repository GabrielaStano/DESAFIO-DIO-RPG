namespace RPG.src.Entities
{
    public class BlackWizard : Hero
    {
        public BlackWizard(string Name, int Level, string HeroType) : base(Name, Level, HeroType)
        {
                 
        
        }

        public override string Attack()
        {
            return this.Name + " atacou com o seu cajado";
        }
    }
}