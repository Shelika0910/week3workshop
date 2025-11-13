namespace Task5
{
    internal class Program

    {
        static void Main(string[] args)
        {
            //for loop
            Console.Write("Enter a number N: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }

            Console.WriteLine("Sum from 1 to " + n + " = " + sum);

            //while loop
            int num = 1;
            Console.WriteLine("\nNumbers from 1 to 20 (skip multiples of 4, stop at 15):");
            while (num <= 20)
            {
                if (num % 4 == 0)
                {
                    num++;
                    continue;
                }

                if (num == 15)
                {
                    break;
                }

                Console.WriteLine(num);
                num++;
            }

            // foreachloop
            int[] numbers = { 1, 2, 3, 4, 5 };
            int total = 0;

            foreach (int val in numbers)
            {
                total += val;
            }

            Console.WriteLine("\nSum of array elements: " + total);


        }
    }
}