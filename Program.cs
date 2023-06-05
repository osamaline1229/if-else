internal class Program
{
    private static void Main(string[] args)
    {
        //int a = 1, b = 1;
        //int c = 5;

        //if (a < b || c == 5)
        //{
        //    Console.WriteLine("condition is met.");
        //}
        //else
        //{
        //    Console.WriteLine("condition is not met.");
        //}

        //khjkhjk
        //

        //for (int i = 0; i < 5; i++)
        //{
        //    for(int j = 0; j < i; j++)
        //    {
        //       Console.WriteLine(j);
        //    }
        //}

        for(int i= 0; i<10; i++)
        {
            for(i= 0; i<11; i++)
            {
                Console.Write("*"); 
            }
            Console.WriteLine();

            for(i= 0; i<9;i++)
            {
                Console.WriteLine("*         *");
            }
            for (i = 0; i < 11; i++)
            {
                Console.Write("*");
            }
        }


    }
}