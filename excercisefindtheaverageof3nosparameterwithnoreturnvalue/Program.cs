using System;

namespace excercisefindtheaverageof3nosparameterwithnoreturnvalue
{
    class Program
    {
        // program to find the average of 3 numbers using function.  Enter the 3 numbers in main function
        static void Main(string[] args)
        {
            int num1 = 10, num2 = 20 , num3 = 30;

            add(num1, num2, num3); // call addition function
            
        }

        static void add(int num1, int num2, int num3)
        {
            num1 = (int)Convert.ToDecimal(num1);
            num2 = (int)Convert.ToDecimal(num1);
            num3 = (int)Convert.ToDecimal(num1);

            float average = (num1 + num2 + num3) / 3;

            Console.WriteLine(Convert.ToString(average));

        }

    }
}
