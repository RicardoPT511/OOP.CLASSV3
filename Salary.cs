double[] salary = new double[4];
double sum = 0;

        
for (int i = 0; i < 4; i++)
{
    Console.Write("Ingresa el sueldo: ");
    salary[i] = double.Parse(Console.ReadLine());
    sum += salary[i];
}
        
double prom = sum / 4;
int cont = 0;
for (int i = 0; i < 4; i++)
{
    if (salary[i] > prom)
    {
        cont++;
    }
}
        
Console.WriteLine($"\nPromedio de sueldos: {prom}");
Console.WriteLine($"Sueldos por encima del promedio: {cont}");