public class vehicle
{
    protected string brand;
    protected int speed;

    public vehicle()
    {
        brand= "audi";
        speed=0;
    }

    public void Accelerate()
    {
        speed=speed+40;
        Console.WriteLine("La velocidad actual es de : " +speed);
    }

    public void Break()
    {
       speed=0; 
    }

    public bool Crash()
    {
        if(speed>100)
        {
            Random rnd = new Random();
            int randNum = rnd.Next(0, 2);
            if(randNum==1)
            {
                Console.WriteLine("Usted a chocado");
                return true;
            }
            else
            {
                Console.WriteLine("Usted casi choca");
                return false;
            }
        }
        Console.WriteLine("Va muy lento para chocar");
        return false;
    }

}

public class Car:vehicle
{
    private int doorsNum;

    public Car(int doors)
    {
        doorsNum=doors;
    }

    public void OpenTrunk()
    {
        if(doorsNum%2!=0)
        {
            Console.WriteLine("The truck is open");
        }
        else
        {
            Console.WriteLine("No tiene cajuela");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Car car1 =new Car(3);

        car1.Accelerate();
        car1.Accelerate();
        car1.Accelerate();
        car1.Crash();
        car1.OpenTrunk();
    }

}

