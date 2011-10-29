using System;

namespace ModernMedical
{
    class Program
    {
        /// <summary>
        ///Method to print values between 1 & 100 (inclusive) based on the following rules:
        ///i. If the number is divisible by 3 only, output Modern
        ///ii. If the number is divisible by 5 only, output Medical
        ///iii. If the number is divisible by both 3 and 5, output ModernMedical
        ///iv. If the number is not divisible by either 3 or 5, only output the number itself.
        /// </summary>
        /// <param name="args">None</param>
        static void Main(string[] args)
        {
            for (int intLoop = 1; intLoop <= 100; intLoop++)
            {
                if (intLoop % 3 == 0 && intLoop % 5 != 0)
                {
                    Console.WriteLine("Modern");
                }
                else if (intLoop % 5 == 0 && intLoop % 3 != 0)
                {
                    Console.WriteLine("Medical");
                }
                else if (intLoop % 3 == 0 && intLoop % 5 == 0)
                {
                    Console.WriteLine("ModernMedical");
                }
                else
                {
                    Console.WriteLine(intLoop);
                }
            } 
            Console.ReadKey();
        }
    }
}
