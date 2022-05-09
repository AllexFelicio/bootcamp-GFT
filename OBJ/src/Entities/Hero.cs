namespace introdução_obj.src.Entities
{
    public abstract class Hero
    {

        public Hero()
        {
            
        }

        public Hero(string Name, int level, string HeroType)
        {
            this.Name = Name;
            this.level = level;
            this.HeroType = HeroType;
        }
        public string Name { get; set; }
        public int level { get; set; }

        public string HeroType { get; set; }



        public override string ToString()
        {
            return this.Name+" "+this.level+" "+this.HeroType;
        }

        public virtual string Attack(){

            return this.Name +" Atacou com a espada";
        }
    }

}