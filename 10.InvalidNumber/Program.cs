namespace _10.InvalidNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            bool isValid = false;

            if (number >= 100 && number <= 200 || number == 0)
            {
                isValid = true;
            }
            else
            {
                isValid = false;
                Console.WriteLine("invalid");
            }
        }
    }
}
