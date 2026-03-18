using System.Buffers;
using System.IO.Compression;

class Npc
{
    private string name;

    public Npc()
    {
        name ="npc1";

    }

    public void React(string input)
    {
        Console.WriteLine(name+" responde a "+input+" con una mueca confundida");
    }

    public void React(string input, int x)
    {
        if(x>=3&&x<=00)
        {
            Console.WriteLine("Responde a "+input+" con Meh");
        }
        if(x==1)
        {
            Console.WriteLine("Responde a "+input+" sonrie ");
        }
        if(x==2)
        {
            Console.WriteLine("Responde a "+input+" con cara seria");

        }
        if(x==3)
        {
            Console.WriteLine("Responde a "+input+" con gritos");
        }
    }

    public void React(string input, bool x)
    {
        if(x)
        {
            Console.WriteLine("Responde a "+input+" de forma amable");
        }
        else
        {
            Console.WriteLine("Responde a "+input+" de forma seria");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Npc npc2 = new Npc();

        npc2.React("Saludar");
        npc2.React("Saludar", 2);
        npc2.React("saludra",true);
        npc2.React("Saludar", 1);
        npc2.React("saludra",false);
        npc2.React("Saludar", 2);
    }
}