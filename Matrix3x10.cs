int[] array=new int[10];
int[,]matrix=new int[3,10];

Console.WriteLine("Ingrese 10 numeros cualquiera :");
for(int i=0;i<10;i++)
{
    Console.WriteLine($"Numero {i+1}:");
    array[i]=int.Parse(Console.ReadLine());
}

for(int j=0;j<10;j++)
{
    matrix[0,j]=array[j];
    matrix[1,j]=array[j]*array[j];
    matrix[2,j]=array[j]*array[j]*array[j];
}

Console.WriteLine("\nLa matriz final es :");
for(int i=0;i<3;i++)
{
    for(int j=0;j<10;j++)
    {
        Console.Write(matrix[i,j]+"\t");
    }
    Console.WriteLine();
}