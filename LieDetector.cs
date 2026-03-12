using System;

class LieDetector
{
    private string SusName;
    private string question;
    private int SusLevel;
    private int MinSus;
    private int MaxSus;

    public LieDetector()
    {
        Console.Write("Nombre: ");
        SusName = Console.ReadLine();

        question = "How old are you?";
        SusLevel = 0;
        MinSus = 1;
        MaxSus = 5;
    }

    public void AnalyzeAnswer(string answer)
    {
        Console.WriteLine("Se esta analizando la respuesta");

        Random rnd = new Random();
        SusLevel = rnd.Next(MinSus, MaxSus );
    }

    public void ShowReport()
    {
        Console.WriteLine("La pregunta analizada fue: " + question);
        Console.WriteLine("El nivel de sospecha es de: " + SusLevel);
    }

    public bool IsLier()
    {
        if(SusLevel >= 4)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        LieDetector Lie1 = new LieDetector();

        Lie1.AnalyzeAnswer("No se");
        Lie1.ShowReport();

        if(Lie1.IsLier())
        {
            Console.WriteLine("Proceder con cautela");
        }
        else
        {
            Console.WriteLine("No hay que preocuparse");
        }
    }
}