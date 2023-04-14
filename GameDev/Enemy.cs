public class Enemy{
    string Name;
    int Health;
   public Dictionary<string, int> AttackList;

   public Enemy(string name){

    Name = name;
    Health = 100;
    AttackList = new Dictionary<string, int>();

 }


 public void RandomAttack(){
    Random randAttack = new Random();
    int att = AttackList[randAttack.Next(AttackList.Count)];
    Console.WriteLine($"{att.name} does {att.dam} damage!");
    
 }


}