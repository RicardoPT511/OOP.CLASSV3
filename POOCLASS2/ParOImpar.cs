int num;
Console.WriteLine("Ingrese un numero entero cualquiera");
num = int.Parse(Console.ReadLine());

bool Identify(int num)
{
    if (num % 2 == 0)
    {
        return true; 
    }
    else
    {
        return false;
        
    }
    
} 

bool resultado = Identify(num);
if (resultado)
{
    Console.WriteLine(num+" es par");
}
else
{
    Console.WriteLine(num + " es impar");
}