namespace introdução_obj.src.Entities
{
    public class Wizard : Hero
    {

        public Wizard(string Name, int level, string HeroType)
        {
            this.Name = Name;
            this.level = level;
            this.HeroType = HeroType;
        }
        public override string Attack(){

            return this.Name +" Lançou uma magia";
        }

        public string Attack(int Bonus){
            if(Bonus>6){
                return this.Name +" Lançou uma super magia com bonus de  "+Bonus;
            }      
            return this.Name +" Lançou uma magia com força fraca com bonus de  "+Bonus;
        }
    }
}