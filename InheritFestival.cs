using System.Runtime.CompilerServices;

class Artist
{
    protected string name;
    protected string country;
    protected string genre;

    public Artist(string newN,string newC, string newg)
    {
        name=newN;
        country=newC;
        genre=newg;
    }

    public void Perform()
    {
        Console.WriteLine("Interpreta Cancion");
    }

    public void Introduce()
    {
        Console.WriteLine("Hello! We are " + name + " from " + country + ". Our genre is " + genre + ".");
    }
}

class Band : Artist
{
    private int numberOfMembers;

    public Band(string newN, string newC, string newG, int newM) : base(newN,newC,newG)
    {
        numberOfMembers=newM;
    }

    public bool PlayEncore()
    {
        Random rnd = new Random();
        int randNum = rnd.Next(0, 2);
        if(randNum==1)
        {
            Console.WriteLine("Habra un encore");
            return true;
        }
        else
        {
            Console.WriteLine("No habra encore");
            return false;
        }
    }

    public void GetStageSize()
    {
        if(numberOfMembers>5)
        {
            Console.WriteLine("Hey, we need a Big stage for Opeth");
        }
        if(numberOfMembers<=5&&numberOfMembers>=3)
        {
            Console.WriteLine("Hey, we need a medium stage for Opeth");
        }
        if(numberOfMembers<3)
        {
            Console.WriteLine("Hey, we need a small stadium");
        }
    }
}

class Dj : Artist
{
    private string software;

    public Dj(string newN, string newC, string newG, string newS) : base (newN,newC,newG)
    {
        software=newS;
    }

    public void MixTrack()
    {
        Console.WriteLine("Tiesto´s track is 240 seconds long");
    }

    public void GetEnergyLevel()
    {
        Random rnd = new Random();
        int randNum1 = rnd.Next(0, 4);
        if(randNum1==1)
        {
            Console.WriteLine("La musica esta muy floja");
        }
        if(randNum1==2)
        {
            Console.WriteLine("La musica esta bien");
        }
        if(randNum1==3)
        {
            Console.WriteLine("La musica esta a tope");
        }
    }
}

class Programm
{
    static void Main(string[] args)
    {
        Band band1=new Band("Opeth","EU","Metal",5);
        band1.GetStageSize();
        band1.PlayEncore();
        
        Dj dj1=new Dj("Tiesto","EU","Metal","Serato");
        dj1.MixTrack();
        dj1.GetEnergyLevel();
    }
}