using System;

class PizzeriaLoca
{
    private string[] ingredients = { "Pepperoni", "Mushroom", "Ham", "Cheese", "Olives" };

    // Versión 1: pizza sencilla
    public void OrderPizza()
    {
        Console.WriteLine("A plain pizza has been delivered!");
    }

    // Versión 2: pizza con extra queso
    public void OrderPizza(bool extraCheese)
    {
        if (extraCheese)
        {
            Console.WriteLine("A plain pizza with extra cheese has been delivered!");
        }
        else
        {
            Console.WriteLine("A plain pizza has been delivered!");
        }
    }

    // Versión 3: pizza con ingredientes
    public void OrderPizza(string[] requestedIngredients)
    {
        for (int i = 0; i < requestedIngredients.Length; i++)
        {
            bool found = false;

            for (int j = 0; j < ingredients.Length; j++)
            {
                if (requestedIngredients[i] == ingredients[j])
                {
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine("Sorry, the ingredient " + requestedIngredients[i] + " is not valid.");
                return;
            }
        }

        Console.WriteLine("The pizza has been delivered!");
    }
}

class Program
{
    static void Main(string[] args)
    {
        PizzeriaLoca pizza = new PizzeriaLoca();

        Console.WriteLine("Solo piden pizza:");
        pizza.OrderPizza();

        Console.WriteLine();

        Console.WriteLine("Piden pizza con extra queso:");
        pizza.OrderPizza(true);

        Console.WriteLine();

        Console.WriteLine("Piden pizza con extra queso:");
        pizza.OrderPizza(false);

        Console.WriteLine();

        Console.WriteLine("Piden una pizza con :");
        string[] pizzaValida = { "Pepperoni", "Cheese" };
        pizza.OrderPizza(pizzaValida);

        Console.WriteLine();

        Console.WriteLine("Piden una pizza con un ingrediente que no existe:");
        string[] pizzaInvalida = { "Pepperoni", "Jam" };
        pizza.OrderPizza(pizzaInvalida);
    }
}