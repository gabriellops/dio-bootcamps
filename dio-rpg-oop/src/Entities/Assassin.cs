namespace dio_rgp_oop.src.Entities
{
    public class Assassin : Hero
    {
        public Assassin(string Name, int Level, string HeroType, int HP, int MP)
            : base(Name, Level, HeroType, HP, MP) {}
            
        public override string Attack()
        {
            return this.Name + " attacked with his scythe, using the primary ability of Reaping Slash!";
        }
        public override string UltimateAbility()
        {
            return this.Name + " attacked with his scythe, using the ultimate ability of Umbral Trespass!";
        }
    }
}