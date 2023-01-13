using System;

class Program
{
    public void question_3(int[] int_main)
    {
        int int_displaced = 0;
        int int_place = 0;
        
        for (int x = 0; x < int_main.Length; x++)
        {
            int_place = x;
            
            for (int y = x; y < int_main.Length; y++)
            {
                if (int_main[int_place] > int_main[y])
                {
                    int_place = y;
                }
            }
            
            if (int_place > x)
            {
                int_displaced = int_displaced + 1;
                
                int_main[x] = int_main[x] + int_main[int_place];
                int_main[int_place] = int_main[x] - int_main[int_place];
                int_main[x] = int_main[x] - int_main[int_place];
            }
        }
        
        Console.Write("The result array = [");
        
        for (int x = 0; x < int_main.Length - 1 ; x++)
        {
            Console.Write(int_main[x]);
            Console.Write(",");
        }
        
        Console.Write("{0}]", int_main[int_main.Length - 1]);
        
        Console.WriteLine();
        
        Console.WriteLine("The number of displaced = {0}", int_displaced);
        
    }
    
    static void Main()
    {
        string str_main = "";
        int[] int_main = new int[1];
        int int_loop = 0;
        
        Console.Write("Please input the array = ");
        str_main = Console.ReadLine();
        
        for (int y = 1; y < str_main.Length - 1; y++)
        {
            if (str_main[y] != ',')
            {
                int_main[int_loop] = int_main[int_loop] * 10 + Convert.ToInt32(str_main[y]) - 48;
            }
            
            else
            {
                int_loop = int_loop + 1;
                Array.Resize(ref int_main, int_main.Length + 1);
            }
        }
        
        Program program = new Program(); 
        program.question_3(int_main);
    }
}
