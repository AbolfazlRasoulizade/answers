using System;

class Program
{
    public void questsion_1(string str_base, string str_key, string str_len)
    {
        int int_total = 0;
        int int_len = Convert.ToInt32(str_len);
        
        for (int x = 0; str_base.Length < int_len; x++)
        {
            str_base = str_base + str_base[x];
        }
        
        for (int x = 0; x < str_base.Length; x++)
        {
            if (str_base[x] == str_key[0])
            {
                int_total = int_total + 1; 
            }
        }
        
        Console.WriteLine("The Result String : {0}",str_base);
        Console.WriteLine("The Number of {0} : {1} ", str_key, int_total);
    }
        
    static void Main()
    {
        string str_base = "";
        string str_key = "";
        string str_len = "";

        Console.Write("Please Input String : ");
        str_base = Console.ReadLine();
        Console.Write("Please Input Length String : ");
        str_len = Console.ReadLine();
        Console.Write("Please Input Key Character : ");
        str_key = Console.ReadLine();
        
        Program program = new Program();
        program.questsion_1(str_base, str_key, str_len);
    }
}
