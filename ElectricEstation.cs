using System;

class ElectricStation
{
    private string Name;
    private int charge;
    private string password;

    public ElectricStation()
    {
        charge = 0;
        Name = "ElectricStation";
        password = "Gibran";
    }

    public void ChangeCharge(int newCharge)
    {
        if(newCharge < 0)
        {
            Console.WriteLine("Error: La carga no puede ser negativa");
        }
        else if(newCharge > 100)
        {
            Console.WriteLine("Error: La carga no puede exceder 100");
        }
        else
        {
            charge = newCharge;
        }
    }

    public void ChangeName(string newName, string pass)
    {
        if(pass == password)
        {
            Name = newName;
        }
        else
        {
            Console.WriteLine("Error: Contraseña incorrecta");
        }
    }

    public string GetName()
    {
        return Name;
    }
}

class Program
{
    static void Main(string[] args)
    {
        ElectricStation station = new ElectricStation();

        station.ChangeCharge(100);

        station.ChangeName("México", "1234");
        Console.WriteLine(station.GetName());

        station.ChangeName("México", "Gibran");
        Console.WriteLine(station.GetName());

        station.ChangeCharge(-1);
    }
}