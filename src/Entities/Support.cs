namespace dio_rgp_oop.src.Entities
{
    public class Support : Hero
    {
        public Support(string Name, int Level, string HeroType, int HP, int MP)
            : base(Name, Level, HeroType, HP, MP){}
            
        public override string Attack()
        {
            return this.Name + " attacked with his hook, using the primary ability of Bone Skewer!";
        }
        public override string UltimateAbility()
        {
            return this.Name + " attacked with his hook, using the ultimate ability of Death From Below!";
        }    
    }
}