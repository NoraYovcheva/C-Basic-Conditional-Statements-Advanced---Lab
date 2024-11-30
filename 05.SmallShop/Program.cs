namespace _05.SmallShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string town = Console.ReadLine();
            double quntity = double.Parse(Console.ReadLine());
            double price = 0;

            if (town == "Sofia")
            {
                if (product == "coffee")
                {
                    price = quntity * 0.50;
                }
                else if (product == "water")
                {
                    price = quntity * 0.80;
                }
                else if (product == "beer")
                {
                    price = quntity * 1.20;
                }
                else if (product == "sweets")
                {
                    price = quntity * 1.45;
                }
                else if (product == "peanuts")
                {
                    price = quntity * 1.60;
                }
            }
            else if (town == "Plovdiv")
            {
                if (product == "coffee")
                {
                    price = quntity * 0.40;
                }
                else if (product == "water")
                {
                    price = quntity * 0.70;
                }
                else if (product == "beer")
                {
                    price = quntity * 1.15;
                }
                else if (product == "sweets")
                {
                    price = quntity * 1.30;
                }
                else if (product == "peanuts")
                {
                    price = quntity * 1.50;
                }
            }
            else if (town == "Varna")
            {
                if (product == "coffee")
                {
                    price = quntity * 0.45;
                }
                else if (product == "water")
                {
                    price = quntity * 0.70;
                }
                else if (product == "beer")
                {
                    price = quntity * 1.10;
                }
                else if (product == "sweets")
                {
                    price = quntity * 1.35;
                }
                else if (product == "peanuts")
                {
                    price = quntity * 1.55;
                }
            }

            Console.WriteLine(price);

        }
    }
}
