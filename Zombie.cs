using System;

class Survivor
{
    protected string name;
    protected int health;

    public Survivor(string newN)
    {
        name = newN;
        health = 100;
    }

    public virtual int Defend()
    {
        Console.WriteLine(name + " is defending himself");
        return GetDamage();
    }

    public void GetStatus()
    {
        Console.WriteLine(name + " has " + health + " health");
    }

    public virtual int GetDamage()
    {
        return 0;
    }
}

class Civilian : Survivor
{
    public Civilian(string newN) : base(newN)
    {
    }

    public override int Defend()
    {
        Console.WriteLine(name + " is defending");
        int damage = GetDamage();
        Console.WriteLine(name + " hit a zombie with " + damage + " damage");
        return damage;
    }

    public override int GetDamage()
    {
        Random rnd = new Random();
        return rnd.Next(3, 8);
    }

    public void Hide()
    {
        Console.WriteLine(name + " is hiding");
    }
}

class Soldier : Survivor
{
    private int ammo;

    public Soldier(string newN) : base(newN)
    {
        ammo = 30;
    }

    public override int Defend()
    {
        Console.WriteLine(name + " is defending");
        int damage = GetDamage();
        ammo -= 5;
        Console.WriteLine(name + " has shot his gun, he has made " + damage + " damage");

        if (ammo <= 0)
        {
            Reload();
        }

        return damage;
    }

    public override int GetDamage()
    {
        Random rnd = new Random();
        return rnd.Next(10, 101);
    }

    public void Reload()
    {
        ammo = 30;
        Console.WriteLine(name + " has reloaded");
    }
}

class Engineer : Survivor
{
    private string trapName;

    public Engineer(string newN) : base(newN)
    {
        trapName = "fire Trap";
    }

    public override int Defend()
    {
        Console.WriteLine(name + " is defending");

        int damage = GetDamage();
        Console.WriteLine(name + " deployed a trap. She made " + damage + " damage.");

        ResetTrap();

        return damage;
    }

    public override int GetDamage()
    {
        Random rnd = new Random();
        return rnd.Next(50, 70);
    }

    public void ResetTrap()
    {
        Console.WriteLine(name + " has reset the trap");
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Survivor c1 = new Civilian("Civilian 1");
        Survivor c2 = new Civilian("Civilian 2");
        Survivor s1 = new Soldier("Soldier 1");
        Survivor e1 = new Engineer("Engineer 1");

        Survivor[] survivors = { c1, c2, s1, e1 };

        int totalDamage = 0;
        Console.WriteLine("A horde is coming!");

        for (int turn = 1; turn <= 5; turn++)
        {
            Console.WriteLine("Turn " + turn);

            foreach (Survivor s in survivors)
            {
                totalDamage += s.Defend();
            }

            Console.WriteLine();
        }

        Console.WriteLine("The horde was defeated. The total damage inflicted is: " + totalDamage);
    }
}