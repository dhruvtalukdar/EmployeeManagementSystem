using System.Threading.Tasks;

//public class Program
//{
//    public static async Task Main(string[] args)
//    {
//        //Thread thread = new Thread(PrintNumbers);
//        //thread.Start();

//        //for (int i = 0; i < 5; i++)
//        //{
//        //    Console.WriteLine($"Main Thread: {i}");
//        //    Thread.Sleep(500); // Pause for demonstration
//        //}
//        Console.WriteLine("Starting the program");

//        string result = await PerformTaskaync();

//        Console.WriteLine("random");
//        Console.WriteLine($"Task completed with result : {result}");
//        Console.WriteLine("Program has ended");
//    }


//    static async Task<string> PerformTaskaync()
//    {
//        Console.WriteLine("Permorming a time-consuming task...");

//        await Task.Delay(2000);

//        Console.WriteLine("finished the task");

//        return "Success";
//    } 

//    static void PrintNumbers()
//    {
//        for (int i = 0; i < 5; i++)
//        {
//            Console.WriteLine($"Worker Thread: {i}");
//            Thread.Sleep(500);
//        }
//    }
//}

// Step 1: Define the IPizza interface
public interface IPizza
{
    void Bake();
}

// Step 2: Implement concrete pizza classes
public class VegPizza : IPizza
{
    public void Bake()
    {
        Console.WriteLine("Baking a Veg Pizza!");
    }
}

public class ChickenPizza : IPizza
{
    public void Bake()
    {
        Console.WriteLine("Baking a Chicken Pizza!");
    }
}

// Step 3: Create the PizzaFactory
public class PizzaFactory
{
    public static IPizza CreatePizza(string type)
    {
        return type.ToLower() switch
        {
            "veg" => new VegPizza(),
            "chicken" => new ChickenPizza(),
            _ => throw new ArgumentException("Invalid pizza type")
        };
    }
}

// Step 4: Use the Factory in the main program
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the type of pizza (veg/chicken):");
        string pizzaType = Console.ReadLine();

        try
        {
            IPizza pizza = PizzaFactory.CreatePizza(pizzaType);
            pizza.Bake();
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}