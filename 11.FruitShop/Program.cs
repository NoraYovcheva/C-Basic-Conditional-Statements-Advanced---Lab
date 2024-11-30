namespace _11.FruitShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string day = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            double price = 0;

            switch (day)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                    if (product == "banana")
                    {
                         Console.WriteLine($"{(quantity * 2.50):f2}");
                    }
                    else if (product == "apple")
                    {
                        Console.WriteLine($"{(quantity * 1.20):f2}");
                    }
                    else if (product == "orange")
                    {  
                        Console.WriteLine($"{(quantity * 0.85):f2}");
                    }
                    else if (product == "grapefruit")
                    {   
                        Console.WriteLine($"{(quantity * 1.45):f2}");
                    }
                    else if (product == "kiwi")
                    {
                        Console.WriteLine($"{(quantity * 2.70):f2}");
                    }
                    else if (product == "pineapple")
                    {
                        Console.WriteLine($"{(quantity * 5.50):f2}");
                    }
                    else if (product == "grapes")
                    {
                        Console.WriteLine($"{(quantity * 3.85):f2}");
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    break;
                case "Saturday":
                case "Sunday":
                    if (product == "banana")
                    {
                        Console.WriteLine($"{(quantity * 2.70):f2}");
                    }
                    else if (product == "apple")
                    { 
                        Console.WriteLine($"{(quantity * 1.25):f2}");
                    }
                    else if (product == "orange")
                    {
                        Console.WriteLine($"{(quantity * 0.90):f2}");
                    }
                    else if (product == "grapefruit")
                    {
                        Console.WriteLine($"{(quantity * 1.60):f2}");
                    }
                    else if (product == "kiwi")
                    {
                        Console.WriteLine($"{(quantity * 3.00):f2}");
                    }
                    else if (product == "pineapple")
                    {
                        Console.WriteLine($"{(quantity * 5.60):f2}");
                    }
                    else if (product == "grapes")
                    {
                        Console.WriteLine($"{(quantity * 4.20):f2}");
                    }
                    else 
                    { 
                        Console.WriteLine("error"); 
                    }
                    break;
                    default: 
                    Console.WriteLine("error");
                    break;
            }
        }
    }
}
