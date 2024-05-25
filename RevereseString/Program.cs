using System;


namespace RevereseString
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            String input = Console.ReadLine();
            String output = "";
            char[] chars = input.ToCharArray();
            for (int  i = chars.Length-1; i>0;i--)
            {
                output += chars[i];
            }
            Console.WriteLine(output);
        }
    }
}
