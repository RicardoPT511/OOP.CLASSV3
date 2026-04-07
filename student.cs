using System;

public class Person
{
    protected string name;
    private string gender;
    protected int age;

    public Person(string newName, string newGender, int newAge)
    {
        name = newName;
        gender = newGender;
        age = newAge;
    }

    public void Salute()
    {
        Console.WriteLine($"Hi, my name is {name}, and I am {age} years old.");
    }
}

public class Student : Person
{
    private string major;
    private int currentSemester;

    public Student(string newName,string newGender,int newAge,string newMajor,int newSemester) : base(newName, newGender, newAge)
    {
        major = newMajor;
        currentSemester = newSemester;
    }

    public void AttendClass()
    {
        Console.WriteLine($"I am attending a class in the {major} major.");
    }

    public void DoHomework()
    {
        Console.WriteLine("I am doing homework.");
    }

    public void PrintAge()
    {
        Console.WriteLine($"My age is {age}");
    }
}

public class Professor : Person
{
    private string department;
    private float salary;

    public Professor(string newName,string newGender,int newAge,string newDepartment,float newSalary) : base(newName, newGender, newAge)
    {
        department = newDepartment;
        salary = newSalary;
    }

    public void Teach()
    {
        Console.WriteLine("Yo " + name + " estoy enseñando");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student student = new Student("Angel","Male",34,"Computer Science",2);

        student.AttendClass();
        student.DoHomework();
        student.Salute();
        student.PrintAge();

        Professor prof1 = new Professor("Andres","Male",56,"Mat",45.1f);

        prof1.Teach();
        prof1.Salute();
    }
}
