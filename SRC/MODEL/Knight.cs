namespace Abstraindo_Jogo_de_RPG_em_LPOO.SRC.MODEL
{
     public class Knight : Heros
    {
        public Knight(string name, int level, string herotype, int hp, int mp) : base(name, level, herotype, hp, mp)
        {  
        }

        public virtual string AttackKnight(){
            string attackKinigt = $@"{this.Name} Atacou com sua espada!!!";
            return attackKinigt;
        }


    }
}