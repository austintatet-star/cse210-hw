using System;

namespace Learning03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Testing Constructors ---");

            Fraction f1 = new Fraction();
            Console.WriteLine(f1.GetFractionString());
            Console.WriteLine(f1.GetDecimalValue());

            Fraction f2 = new Fraction(5);
            Console.WriteLine(f2.GetFractionString());
            Console.WriteLine(f2.GetDecimalValue());

            Fraction f3 = new Fraction(3, 4);
            Console.WriteLine(f3.GetFractionString());
            Console.WriteLine(f3.GetDecimalValue());

            Fraction f4 = new Fraction(1, 3);
            Console.WriteLine(f4.GetFractionString());
            Console.WriteLine(f4.GetDecimalValue());

            Console.WriteLine("\n--- Testing Getters & Setters ---");
            Fraction testGetSet = new Fraction();
            testGetSet.SetTop(6);
            testGetSet.SetBottom(7);
            Console.WriteLine($"Retrieved Top: {testGetSet.GetTop()}");
            Console.WriteLine($"Retrieved Bottom: {testGetSet.GetBottom()}");
            Console.WriteLine($"Updated Fraction: {testGetSet.GetFractionString()}");

            Console.WriteLine("\n--- Running Random Loop Practice ---");
            
            Fraction randomFraction = new Fraction();
            Random rand = new Random();

            for (int i = 1; i <= 20; i++)
            {
                int randomTop = rand.Next(1, 21);
                int randomBottom = rand.Next(1, 21);

                randomFraction.SetTop(randomTop);
                randomFraction.SetBottom(randomBottom);

                Console.WriteLine($"Fraction {i}: string: {randomFraction.GetFractionString()} Number: {randomFraction.GetDecimalValue()}");
            }
        }
    }
}