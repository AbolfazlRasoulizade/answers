using System.IO;
using System;

class Program
{
    static void Main()
    {
        string str_base = "";
        string str_key = "";
        int int_len = 0;
        int int_loop = 0;
        int int_total = 0;
        
        Console.Write("Please Input String : ");
        str_base = Console.ReadLine();
        Console.Write("Please Input Length String : ");
        int_len = Convert.ToInt32(Console.ReadLine());
        Console.Write("Please Input Key Character : ");
        str_key = Console.ReadLine();
        
        
        while ( str_base.Length < int_len ) 
        {
            str_base = str_base + str_base[int_loop];
            int_loop = int_loop + 1;
        }
        
        for (int x = 0; x < str_base.Length; x++)
        {
            if (str_base[x] == str_key[0])
            {
                int_total = int_total + 1; 
            }
        }
        Console.WriteLine("The Result String is : {0}",str_base);
        Console.WriteLine("The Number of {0} is : {1} ",str_key,int_total);
    }
}
