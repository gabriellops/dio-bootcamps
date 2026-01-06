namespace dio_rgp_oop.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int Level, string HeroType, int HP, int MP)
            : base(Name, Level, HeroType, HP, MP){}
            
        public override string Attack()
        {
            return this.Name + " attacked with her magic, using the primary ability of Light Binding!";
        }
        public override string UltimateAbility()
        {
            return this.Name + " attacked with her magic, using the ultimate ability of Final Spark!";
        }   
    }
}