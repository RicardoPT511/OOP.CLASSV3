public class Character
{
    protected string name;

    public Character(string newName)
    {
        name="char1";
    }

    public virtual void Introduce()
    {
        Console.WriteLine("Hii, i am " +name );
    }
    
}

public class Ghost : Character
{
    
    public Ghost(string newName): base(newName)
    {
    }

    public override void Introduce()
    {
        Console.WriteLine("BOOOOO!!!!!! i am the ghost " + name);
        
    }

}

class Program
{
    public static void Main(string[] args)
    {
        Character char1 =new Character("Carlos");
        char1.Introduce();

        Ghost g1 =new Ghost("Casper");
        g1.Introduce();
    }
}