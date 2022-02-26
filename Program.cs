using Abstraindo_Jogo_de_RPG_em_LPOO.SRC.MODEL;
using static System.Console;

var Arus = new Knight("Arus", 42, "Knight", 749, 72);

WriteLine(Arus);
WriteLine();
WriteLine(Arus.AttackKnight());

var Maleficus = new Devil("Maleficus", 99, "Devil", 100000, 100000);

WriteLine(Maleficus);
WriteLine();
WriteLine(Maleficus.Defender());

var Wedge = new Ninja("Wedge", 42, "Ninja", 574, 89);
WriteLine(Wedge);
WriteLine();
WriteLine(Wedge.AttackNinja());

var Jenica = new Wizard("Jenica", 42, "White Wizard", 601, 482);

WriteLine(Jenica);
WriteLine();
WriteLine(Jenica.Heal());
WriteLine(Jenica.AttackWizard(1));

var Topapa = new Wizard("Topapa", 42, "Black Wizard", 385, 641);

WriteLine(Topapa);
WriteLine();
WriteLine(Topapa.AttackWizard(11));

WriteLine("---------------------------------------");
WriteLine("Vitoria!!!");

