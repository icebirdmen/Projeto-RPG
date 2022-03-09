namespace Projeto_RPG.Scr.Entities
{
    public class Mage
    {
        public Mage(){
        }
        public string name;
        public string classe; 
        public int Bonus;
    
    
        public Mage(string name, string classe, string Bonus){
            this.name = name;
            this.classe = classe;
            this.Bonus = int.Parse(Bonus);
        }

        public override string ToString()
        {
            return this.name + " Da classe " + this.classe + " e com bonus de " + this.Bonus ;
        }

        public static void MAttack(int dano){
            if (dano == 1){
                Console.WriteLine($"{dano} de dano magico Ileso");
            
            }else if (1 < dano && dano < 10){
                Console.WriteLine($"{dano} de dano magico Pouco dano");
            
            }else if (10 < dano && dano < 20){
                Console.WriteLine($"{dano} de dano magico Bom dano");
            
            }else if (dano == 20){
                Console.WriteLine($"{dano} de dano magico Dano Fatal");
            }

        }


    }
}