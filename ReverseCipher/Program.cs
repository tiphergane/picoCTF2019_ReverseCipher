using System;
using System.IO;
using System.Text;


namespace ReverseCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] BaseFlag = new byte[32];
            BaseFlag = Encoding.UTF8.GetBytes("picoCTF{w1{1wq80haib767}");
            int i;
            for (i = 8; i < BaseFlag.Length - 1; i++)
            {
                int value = i % 2; //check si i est pair ou impair
                if (value == 0) // si pair alors
                {
                   BaseFlag[i] -= 5;
                }
                else
                    BaseFlag[i] += 2;
            };
            string f = Encoding.UTF8.GetString(BaseFlag, 0, BaseFlag.Length);
            Console.WriteLine("La clef est : {0}", f);
            var path = @"./Flag.txt";
            File.WriteAllText(path,f);
            Console.WriteLine("Press Enter to quit");
            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
        }
    }
}
