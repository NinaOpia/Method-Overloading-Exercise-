namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            //integer Version
            var result = Add(8, 5);

            Console.WriteLine(result);

            //Decimal Version
            var deciResult = Add(4.2m, 6.7m);

            Console.WriteLine($"Decimal: {deciResult}");

            //Boolean Version
            Console.WriteLine($"should print 1 dollar: ${Add(0, 1, true)}");

            Console.WriteLine($"should print 5 dollar: ${Add(2, 3, true)}");

            Console.WriteLine($"should print sum: {Add(8, 3, false)}");

        }

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static decimal Add(decimal num1, decimal num2)
        {
            return num1 + num2;
        }

        public static string Add(decimal num1, decimal num2, bool isTrue)
        {
            var sum = num1 + num2;

            if (isTrue == true && sum > 1)
            {
                return $"{sum} dollars";
            }
            else if (isTrue && sum == 1)
            {
                return $"{sum} dollar";
            }
            else
            {
                return sum.ToString(); //$"{sum}"
            }
        }
    }
}
