class Attack{
    string Name;
    int Damage;

    public Attack(string name, int dam){
        Name = name;
        Damage = dam;
    }

    void DoDamage(){
        Console.WriteLine($"{Name} does {Damage} damage!");
    }
}

