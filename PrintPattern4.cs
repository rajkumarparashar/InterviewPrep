namespace InterviewPrep
{
    public class PrintPattern4
    {
        public static void Print()
        {
            Console.WriteLine("Enter the upperbound number");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
