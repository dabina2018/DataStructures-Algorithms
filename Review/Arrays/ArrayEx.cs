using System;

namespace Review
{
    class ArrayEx
    {
        static void Main()
        {
            int[] numbers = new int[5];
            numbers[0] = 4;
            numbers[1] = 8;
            numbers[2] = 15;
            numbers[3] = 16;
            numbers[4] = 23;

            //Console.WriteLine("the vale of index 1 is" + numbers[1]);
            // Console.WriteLine("The length of the Array is" + numbers.Length);

            int[] nums = new int[] { 3, 4, 5, 7, 4, 6, 53 };

            string[] names = new string[] { "billy", "joel", "michael", "david banner" };
            /*
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
            Console.ReadLine();
            */

            /*
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            */
            string zig = "You can get what you want out of life" + "if you punch people.";
            char[] charArray = zig.ToCharArray();
            Array.Reverse(charArray);

            foreach (char zigChar in charArray)
            {
                Console.Write(zigChar);
            }

        }
    }
}
