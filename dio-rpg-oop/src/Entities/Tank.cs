namespace dio_rgp_oop.src.Entities
{
    public class Tank : Hero
    {
        public Tank(string Name, int Level, string HeroType, int HP, int MP)
            : base(Name, Level, HeroType, HP, MP){}
        
        public override string Attack()
        {
            return this.Name + " attacked with his sword, using the primary ability of Decisive Strike!";
        }
        public override string Attack(int Bonus)
        {
            if (Bonus != 0 && Bonus >= 3)
            {
                return this.Name + " strongly attacked with his sword, using the primary ability of Decisive Strike with a " + Bonus + " attack damage bonus!";
            }
            else
            {
                return this.Name + " weakly attacked with his sword, using the primary ability of Decisive Strike with a " + Bonus + " attack damage bonus!";
            }
        }

         public override string UltimateAbility()
        {
            return this.Name + " attacked with his sword, using the ultimate ability of Demacian Justice!";
        }
        public override string UltimateAbility(int Bonus)
        {
            if (Bonus != 0 && Bonus >= 3)
            {
                return this.Name + " strongly attacked with his sword, using the ultimate ability of Demacian Justice with a " + Bonus + " attack damage bonus!";
            }
            else
            {
                return this.Name + " weakly attacked with his sword, using the ultimate ability of Demacian Justice with a " + Bonus + " attack damage bonus!";
            }
        }
    }
}