namespace InterviewPrep
{
    public class Factorial
    {
        static int factorial = 1;
        public static void PrintFactorial()
        {
            Console.WriteLine("Please enter a no to print Factorial");
            var number = Convert.ToInt32(Console.ReadLine());
            int result = GetFactorial(number);
            Console.WriteLine(result);
        }

        static int GetFactorial(int number)
        {
            if (number > 0)
            {
                factorial = number * GetFactorial(number - 1);
            }
            return factorial;
        }
    }
}
