namespace Abstraindo_Jogo_de_RPG_em_LPOO.SRC.MODEL
{
    public abstract class Enemy
    {
        public Enemy(string name, int level, string enemytype, int hp, int mp)
        {
            Name = name;
            Level = level;
            EnemyType = enemytype;
            HP = hp;
            MP = mp;
        }

        public string Name { get; private set; }
        public int Level { get; set; }
        public string EnemyType { get; private set; }
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
            Classe: {this.EnemyType}
            HP: {this.HP}
            MP:{this.MP} 
            ________________________";
            return texto;
        }
    }
}