namespace InterviewPrep
{
    public class PrintPattern3
    {
        public static void Print()
        {
            Console.WriteLine("Enter the upperbound number");
            int number = Convert.ToInt32(Console.ReadLine());

            int runningNumber = 0;

            for (int i = 1; i <= number; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    runningNumber++;
                    Console.Write(runningNumber + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
