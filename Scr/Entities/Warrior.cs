namespace Projeto_RPG.Scr.Entities
{
    public class Warrior
    {
        public Warrior(){
        }
        public string name;
        public string classe; 
        public int Bonus;
    
    
        public Warrior(string name, string classe, string Bonus){
            this.name = name;
            this.classe = classe;
            this.Bonus = int.Parse(Bonus);
        }

        public override string ToString()
        {
            return this.name + "Da classe " + this.classe + " e com bonus de " + this.Bonus ;
        }

        public static void Attack (int dano){
            if (dano == 1){
                Console.WriteLine($"{dano} Ileso");
            
            }else if (1 < dano && dano < 10){
                Console.WriteLine($"{dano} Pouco dano");
            
            }else if (10 < dano && dano < 20){
                Console.WriteLine($"{dano} Bom dano");
            
            }else if (dano == 20){
                Console.WriteLine($"{dano} Dano Fatal");
            }
        }
    }
}