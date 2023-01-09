using System.IO;
using System;

class Program
{
    static void Main()
    {
        string str_base = "";
        int int_len = 0;
        int int_loop = 0;
        Console.Write("Please Input String : ");
        str_base = Console.ReadLine();
        Console.Write("Please Input Length String : ");
        int_len = Convert.ToInt32(Console.ReadLine());
        while ( str_base.Length < int_len ) 
        {
            str_base = str_base + str_base[int_loop];
            int_loop = int_loop + 1;
        }
        Console.WriteLine(str_base);
    }
}
