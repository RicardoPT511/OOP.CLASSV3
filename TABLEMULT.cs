int Num,Producto;

Console.WriteLine("Ingrese un nuemro entero ");
Num= int.Parse(Console.ReadLine());

Console.WriteLine("La tabla del :" + Num);
for (int i = 0; i <= 10; i++)
{
    Producto=Num * i;
    Console.WriteLine(Producto);
    
}
