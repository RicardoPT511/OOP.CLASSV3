int[] array1 = {1,2,3,4,5};

        
for(int i = 0; i < array1.Length; i++)
{
    Console.Write(array1[i] + " ");
}

        
int inicio = 0;
int fin = array1.Length - 1;

while(inicio < fin)
{
    int temp = array1[inicio];
    array1[inicio] = array1[fin];
    array1[fin] = temp;

    nicio++;
    fin--;
}

Console.WriteLine("  ");
for(int i = 0; i < array1.Length; i++)
{
    Console.Write(array1[i] + " ");
}
    
