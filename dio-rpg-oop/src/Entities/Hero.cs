namespace dio_rgp_oop.src.Entities
{
    public abstract class Hero
    {
        public Hero(string Name, int Level, string HeroType, int HP, int MP)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HP = HP;
            this.MP = MP;
        }

        public string Name { get; set; }
        public int Level { get; set; }
        public string HeroType { get; set; }
        public  int HP { get; set; }
        public  int MP { get; set; }

        public virtual string Attack()
        {
            return this.Name + " attacked with his/her";
        }
        public virtual string Attack(int Bonus)
        {
            return this.Name + " attacked with his/her";
        }
        public virtual string UltimateAbility()
        {
            return this.Name + " attacked with his/her";
        }
        public virtual string UltimateAbility(int Bonus)
        {
            return this.Name + " attacked with his/her";
        }
        public override string ToString()
        {
            return this.Name + " " + this.Level + " " + this.HeroType + " " + this.HP + " " + this.MP;
        }
    }
}