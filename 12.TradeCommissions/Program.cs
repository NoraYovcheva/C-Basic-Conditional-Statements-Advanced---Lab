namespace _12.TradeCommissions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            double salesVolume = double.Parse(Console.ReadLine());
            double commission = 0;

            switch (town)
            {
                case "Sofia":
                    if (salesVolume >= 0 && salesVolume <= 500)
                    {
                        commission = salesVolume * 0.05;
                        Console.WriteLine($"{commission:f2}");
                    }
                    else if (salesVolume > 500 && salesVolume <= 1000)
                    {
                        commission = salesVolume * 0.07;
                        Console.WriteLine($"{commission:f2}");
                    }
                    else if (salesVolume > 1000 && salesVolume <= 10000)
                    {
                        commission = salesVolume * 0.08;
                        Console.WriteLine($"{commission:f2}");
                    }
                    else if (salesVolume > 10000)
                    {
                        commission = salesVolume * 0.12;
                        Console.WriteLine($"{commission:f2}");
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    break;
                case "Varna":
                    if (salesVolume >= 0 && salesVolume <= 500)
                    {
                        commission = salesVolume * 0.045;
                        Console.WriteLine($"{commission:f2}");
                    }
                    else if (salesVolume > 500 && salesVolume <= 1000)
                    {
                        commission = salesVolume * 0.075;
                        Console.WriteLine($"{commission:f2}");
                    }
                    else if (salesVolume > 1000 && salesVolume <= 10000)
                    {
                        commission = salesVolume * 0.10;
                        Console.WriteLine($"{commission:f2}");
                    }
                    else if (salesVolume > 10000)
                    {
                        commission = salesVolume * 0.13;
                        Console.WriteLine($"{commission:f2}");
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    break;
                case "Plovdiv":
                    if (salesVolume >= 0 && salesVolume <= 500)
                    {
                        commission = salesVolume * 0.055;
                        Console.WriteLine($"{commission:f2}");
                    }
                    else if (salesVolume > 500 && salesVolume <= 1000)
                    {
                        commission = salesVolume * 0.08;
                        Console.WriteLine($"{commission:f2}");
                    }
                    else if (salesVolume > 1000 && salesVolume <= 10000)
                    {
                        commission = salesVolume * 0.12;
                        Console.WriteLine($"{commission:f2}");
                    }
                    else if (salesVolume > 10000)
                    {
                        commission = salesVolume * 0.145;
                        Console.WriteLine($"{commission:f2}");
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
