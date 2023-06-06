namespace InterviewPrep
{
    public class PrintPattern5
    {
        //public static void Print()
        //{
        //    Console.WriteLine("Enter the upperbound number");
        //    int number = Convert.ToInt32(Console.ReadLine());

        //    int counter = 0;
        //    for (int i = number; i > 0; i--)
        //    {
        //        for (int j = 0; j <= counter; j++)
        //        {
        //            Console.Write(i + j + " ");
        //        }
        //        counter++;
        //        Console.WriteLine();
        //    }
        //}

        public static void Print()
        {
            Console.WriteLine("Enter the upperbound number");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = number; i > 0; i--)
            {
                for (int j = i; j <= number; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
