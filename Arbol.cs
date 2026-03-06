using System;
using System.Diagnostics.CodeAnalysis;
using System.Security.Permissions;

class arbol
{
    private int size;
    private string foliage;

    public arbol()
    {
        size=100;
        foliage="too much";
    } 

    public void bloom()
    {
      size+=10;
      Console.WriteLine("The new size is : " + size ); 
    }

    public void dry()
    {
        if (foliage == "too much")
        {
        foliage = "not much";
        }
        else if (foliage == "not much")
        {
        foliage = "none";
        }

    Console.WriteLine("The new foliage is : " + foliage);
    }
}

class Program
{
    static void Main(string[] args)
    {
        arbol arboledo =new arbol();
        arboledo.bloom();
        arboledo.dry();
        arboledo.dry();  
        arboledo.dry(); 
    }
}