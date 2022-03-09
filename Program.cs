using static System.Console;
using Projeto_RPG.Scr.Entities;
Random rnd = new Random();

WriteLine("Nome, classe e Modificador");

string name = ReadLine();
string @class = ReadLine();
string Bonus = ReadLine();


Warrior warrior = new Warrior(name,@class,Bonus);
WriteLine($"Muito bem {warrior}, Quantos dados vamos jogar?");
int Conter = int.Parse(ReadLine());
if(@class.ToUpper() == "MAGO"){
for (int i = 0; i < Conter; i++)
{
    int dano = rnd.Next(1,20);
    Mage.MAttack(dano);
}
}else{
 for (int i = 0; i < Conter; i++)
{
    int dano = rnd.Next(1,20);
    Warrior.Attack(dano);
}   
}

WriteLine("\n\nPressione [enter] para finalizar");
ReadLine();
