using System.Dynamic;
using System.Text;

class Drone
{
    private int battery1;
    private int height;
    private bool droneOn;

    public Drone()
    {
        battery1=100;
        height=0;
        droneOn=true;
    }

    public void Fall()
    {
        droneOn=false;
        height=0;
        Console.WriteLine("El drone se ha estrellado");
    }
    public void resetHeight(int NH)
    {
        if(battery1>=40)
        {
            height=NH;
            battery1=battery1-40;
            Console.WriteLine("El dron ahora esta en : "+height+ " metros");
        }
        else
        {
            Console.WriteLine("No existe bateria suficiente");
        }
        if(NH<1)
        {
            Console.WriteLine("No se puede ingresar valore negativos");
        }
    }
    public void Battery(int NB)
    {
        battery1=NB;
    } 
}

class Programm
{
    static void Main(string[] args)
    {
        Drone dron1 = new Drone();

        dron1.Battery(120);
        dron1.resetHeight(400);
        dron1.resetHeight(300);
        dron1.resetHeight(200);
    }
    
}