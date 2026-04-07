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
        }
    }

}