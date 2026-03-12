using System.Timers;

class HauntedHouse
{
    private string name;
    private int address;
    private string horrorlevel;

   public HauntedHouse()
    {
       name="terror house";
       address=1597;
       horrorlevel="Terrorifico";
 
    }

    public void ShowInfo()
    {
        Console.WriteLine("El nombre es : "+name);
        Console.WriteLine("L direccion : "+address);
        Console.WriteLine("Nivel de horror : "+horrorlevel);
    }

    public void SpookVisitors()
    {
        if(horrorlevel=="Terrorifico")
        {
            Console.WriteLine("Les da un paro cardiaco");
        }
        else if(horrorlevel=="miedo")
        {
            Console.WriteLine("Salen corriendo");
        }
        else if(horrorlevel=="ok")
        {
            Console.WriteLine("Gritan");
        }
        else if(horrorlevel=="nah")
        {
            Console.WriteLine("No se asustan");
        }
    }

}

class programm
{
    static void Main(string[] args)
    {
        HauntedHouse TerrorH = new HauntedHouse();

        TerrorH.ShowInfo();
        TerrorH.SpookVisitors();

    }
}