namespace Abstraindo_Jogo_de_RPG_em_LPOO.SRC.MODEL
{
    public class Wizard : Heros
    {
        public Wizard(string name, int level, string herotype, int hp, int mp) : base(name, level, herotype, hp, mp)
        {
        }

        public virtual string AttackWizard(){
            string attackWizard = $@"{this.Name} Atacou com seu Cajado";
            return attackWizard;
        }

        public virtual string AttackWizard(int bonus){
            if(bonus > 10){
            string attackWizard = $@"{this.Name} Atacou com seu Cajado e fez uma chuva de meteoritos!!! Mais um bonus de {bonus} %. ";
            return attackWizard;
            }else{
                string attackWizard = $@"{this.Name} Atacou com seu Cajado e causou um bonus de {bonus} %. " ;
            return attackWizard;
            }
            
        }
    }
}