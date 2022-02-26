namespace Abstraindo_Jogo_de_RPG_em_LPOO.SRC.MODEL
{
     public abstract class Heros
    {
        public Heros(string name, int level, string herotype, int hp, int mp)
        {
            Name = name;
            Level = level;
            HeroType = herotype;
            HP = hp;
            MP = mp;
        }

        public string Name { get; set; }
        public int Level { get; set; }
        public string HeroType { get; set; }
        public int HP {get; set;}
        public int MP {get; set;}


        public virtual string Defender(){
            string defender = $@"{this.Name} Defendeu!!!";
            return defender;
        }

        public virtual string Heal(){
            string heal = $@"{this.Name} Usou magia de cura em Área!!!";
            return heal;
        }
     
        public override string ToString()
        {
            string texto = $@"
            _______________________
            Nome: {this.Name}
            Level: {this.Level}
            Classe: {this.HeroType}
            HP: {this.HP}
            MP:{this.MP} 
            ________________________";
            return texto;
        }
    }
}