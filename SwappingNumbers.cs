namespace InterviewPrep
{
    public class SwappingNumbers
    {
        public static void SwapNumbers()
        {
            Console.WriteLine("Please enter 1st number");
            var number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter 2nd number");
            var number2 = Convert.ToInt32(Console.ReadLine());

            number1 = number1 + number2;
            number2 = number1 - number2;
            number1 = number1 - number2;

            Console.WriteLine("1st number is swapped by {0}", number1);
            Console.WriteLine("2nd number is swapped by {0}", number2);
        }
    }
}
