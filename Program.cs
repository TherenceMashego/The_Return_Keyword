using System;

{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Calling a method with a return type and displaying the result
            Console.WriteLine(cube(5));

            // Calling the method without using Console.WriteLine won't display anything
            cube(5);

            // Freezing the console
            Console.ReadLine();
        }

        // Declare a method with a return type int
        static int cube(int number)
        {
            int result = number + number + number;
            return result;
        }
    }
}
