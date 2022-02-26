namespace Abstraindo_Jogo_de_RPG_em_LPOO.SRC.MODEL
{
    public class Ninja : Heros
    {
        public Ninja(string name, int level, string herotype, int hp, int mp) : base(name, level, herotype, hp, mp)
        {
        }

        public virtual string AttackNinja(){
            string attackNinja = $@"{this.Name} Atacou com sua Kunai!!!";
            return attackNinja;
        }
    }
}