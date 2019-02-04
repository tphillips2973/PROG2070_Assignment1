/*
 * 
 * 
 * 
 * 
 * 
 */

using System;

namespace TPhillipsAssignment1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Circle circle = new Circle();
        StartProgram:
            Console.Clear();
            PresentMenu();
            ConsoleKeyInfo inputKey = Console.ReadKey();
            switch (inputKey.Key)
            {
                case ConsoleKey.D1:
                    Console.Clear();
                    Console.WriteLine("Current Circle Radius is: "
                        + circle.GetRadius().ToString()
                        + Environment.NewLine);
                    Console.WriteLine("Press any key to continue . . .");
                    Console.ReadKey();
                    goto StartProgram;

                case ConsoleKey.D2:
                    Console.Clear();
                    Console.WriteLine("Please enter a new circle radius.");
                    Console.Write("Radius: ");
                    double radiusInput;
                    try
                    {
                        radiusInput = double.Parse(Console.ReadLine());
                    }
                    catch (Exception)
                    {
                        Console.Clear();
                        Console.WriteLine("The number you entered " +
                            "could not be processed. An error occurred");
                        Console.WriteLine("Press any key to continue . . .");
                        Console.ReadKey();
                        goto StartProgram;
                    }
                    int setRadius =
                        Convert.ToInt32(Math.Round(radiusInput));
                    if (setRadius < 1)
                    {
                        Console.Clear();
                        Console.WriteLine("Radius cannot be set to an " +
                            "interger less than one");
                        Console.WriteLine("Press any key to continue . . .");
                        Console.ReadKey();
                        goto StartProgram;
                    }
                    circle.SetRadius(setRadius);
                    Console.Clear();
                    Console.WriteLine("The circle's radius has been " +
                        "set to: " + setRadius.ToString());
                    Console.WriteLine("Press any key to continue . . .");
                    Console.ReadKey();
                    goto StartProgram;

                case ConsoleKey.D3:
                    Console.Clear();
                    Console.WriteLine("The circle's circumference " +
                        "is equal to: " +
                        circle.GetCircumference().ToString());
                    Console.WriteLine("Press any key to continue . . .");
                    Console.ReadKey();
                    goto StartProgram;

                case ConsoleKey.D4:
                    Console.Clear();
                    Console.WriteLine("The circle's area " +
                        "is equal to: " +
                        circle.GetArea().ToString());
                    Console.WriteLine("Press any key to continue . . .");
                    Console.ReadKey();
                    goto StartProgram;

                case ConsoleKey.D5:
                    Environment.Exit(0);
                    break;
                default:
                    Console.Clear();
                    goto StartProgram;
            }
        }

        private static void PresentMenu()
        {
            Console.WriteLine("1.   Get Circle Radius");
            Console.WriteLine("2.   Change Circle Radius");
            Console.WriteLine("3.   Get Circle Circumference");
            Console.WriteLine("4.   Get Circle Area");
            Console.WriteLine("5.   Exit");
        }
    }
}
