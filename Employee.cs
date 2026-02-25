using System;

public class employee
{
    private string name;
    private string category;
    private int    id;
    private float    salary;

    public employee()
    {
        name=Console.ReadLine();
        category=Console.ReadLine();
        id=Console.ReadLine();
        salary=Console.ReadLine();


    }

    public float getsalary()
    {
        return salary;
    }

}

class Examples
{
    static void Main(string[] args)
    {
        int NumEmp;
        Console.WriteLine("Ingrese el numbre de emplados a ingresar");
        NumEmp=Console.ReadLine();
        employee[] employee1= new employee[2];
        for(int i=0;i<=NumEmp;i++)
        {
            employee[i]=new employee();

        }





    }

}
