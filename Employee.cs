using System;

public class Employee
{
    private string name;
    private string category;
    private int id;
    private float salary;

    public Employee()
    {
        Console.Write("Nombre: ");
        name = Console.ReadLine();

        Console.Write("Categoria: ");
        category = Console.ReadLine();

        Console.Write("ID: ");
        id = int.Parse(Console.ReadLine());

        Console.Write("Sueldo: ");
        salary = float.Parse(Console.ReadLine());
    }

    public float GetSalary()
    {
        return salary;
    }

    public string GetName()
    {
        return name;
    }

    public void Print()
    {
        Console.WriteLine($"{name}, {category}, {id}, {salary}");
    }
}

class Examples
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese el numero de empleados a ingresar: ");
        int numEmp = int.Parse(Console.ReadLine());

        Employee[] employees = new Employee[numEmp];

        Console.WriteLine("\n--- Ingrese los datos de cada empleado ---");
        for (int i = 0; i < numEmp; i++)
        {
            Console.WriteLine($"\nEmpleado #{i + 1}");
            employees[i] = new Employee();
        }

        float sum = 0;
        for (int i = 0; i < numEmp; i++)
        {
            sum += employees[i].GetSalary();
        }

        float average = sum / numEmp;

        Console.WriteLine("\n--- Empleados ingresados ---");
        for (int i = 0; i < numEmp; i++)
        {
            employees[i].Print();
        }

        Console.WriteLine($"\nLos siguientes empleados ganan menos del promedio que es ${average:N2}:");

        bool someone = false;
        for (int i = 0; i < numEmp; i++)
        {
            if (employees[i].GetSalary() < average)
            {
                Console.WriteLine(employees[i].GetName());
                someone = true;
            }
        }

        if (!someone)
        {
            Console.WriteLine("(Nadie gana menos del promedio)");
        }
    }
}