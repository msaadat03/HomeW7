using System;

namespace HomeW7
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                ReversingHomeW7("Hi, guys!");
            }
            static void ReversingHomeW7(string sentence)
            {
                string str;
                str = string.Empty;
                for (int i = sentence.Length - 1; i >= 0; i--)
                {
                    str += sentence[i];
                }
                Console.WriteLine(str);
            }
        }
    }
}
