namespace dio_rgp_oop.src.Entities
{
    public class Marksman : Hero
    {
        public Marksman(string Name, int Level, string HeroType, int HP, int MP)
            : base(Name, Level, HeroType, HP, MP){}
            
        public override string Attack()
        {
            return this.Name + " attacked with her rifle, using the primary ability of Piltover Peacemaker!";
        }
        public override string UltimateAbility()
        {
            return this.Name + " attacked with her rifle, using the ultimate ability of Ace in the Hole!";
        }    
    }
}