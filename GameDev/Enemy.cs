public class Enemy{
    string Name;
    int Health;
   List<int> AttackList;

   public Enemy(string name){

    Name = name;
    Health = 100;
    AttackList = new List<int>();

 }

 public void RandomAttack(){
    Random randAttack = new Random();
    int att = AttackList[randAttack.Next(AttackList.Count)];
    Console.WriteLine($"{AttackList[att].name} does {att.dam} damage!");
    
 }


}