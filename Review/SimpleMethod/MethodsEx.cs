using System;

namespace SimpleMethod
{
    class MethodsEx
    {
        static void MethodStuff()
        {
            Console.WriteLine("The Name Game");

            Console.WriteLine("What's your first name?");
            string fName = Console.ReadLine();
            
            Console.WriteLine("What's your last name?");
            string lName = Console.ReadLine();               

            Console.WriteLine("In what city were you born?");
            string city = Console.ReadLine();

            string message = fName + " " + lName + " " + city;
            Console.WriteLine(string.Format("{0} {1} {2}", fName, lName, city));
            Console.WriteLine(ReverseString(message));
            Console.ReadLine();
        }

        private static string ReverseString(string message)
        {

            char[] mssgChar = message.ToCharArray();
            Array.Reverse(mssgChar);
            /*foreach (char letter in mssgChar)
            {
                Console.Write(letter);
            }*/
            return String.Concat(mssgChar);
        }
    }
}
