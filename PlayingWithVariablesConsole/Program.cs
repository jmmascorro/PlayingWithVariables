using System;

namespace PlayingWithVariablesConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variable declarations and initializations 
            int age = 33;
            bool isMarried = true;        
            string fullName = "Jesse Mascorro";
            char nickName = 'J';
            double longerPi = 3.1415926535897932384626433832795028841971693993751058209749445923078164062862089986280348253421170679;
            decimal pi = 3.14m;

           
            //interpolate variables in Console.Writeline();
            Console.WriteLine($" My name is {fullName}, I am {age} years old, My friends just call me {nickName} ");
            Console.WriteLine($" My favorite number is actually an irrational number, which is {pi}, or something closer to {longerPi} ");
            Console.WriteLine($" Is married {isMarried}");
        }
    }
}
