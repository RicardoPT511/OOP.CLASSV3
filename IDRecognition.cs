int[] GoodID = { 10, 14, 101,105,801,1607,2034,5607 };
int IDem ;

Console.WriteLine("Ingrese su Folio");
IDem=int.Parse(Console.ReadLine());

int Correct=0;

for(int i=0;i<GoodID.Length;i++)
{
    
    if(GoodID[i]==IDem)
    {
        
        Correct++;
        break;

    }

}
if(Correct>0)
{
    Console.WriteLine("El folio es valido");
}
else
{
    Console.WriteLine("Folio no reconocido");
}
