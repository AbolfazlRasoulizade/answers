using System;

class Program
{
    public void question_2(string str_main)
    {
        int int_removed = 0;
        int x = 0;
        
        while (x < (str_main.Length - 1))
        {
            if ( str_main[x] == str_main[x + 1] )
            {
                int_removed = int_removed + 1 ;
                str_main = str_main.Remove(x, 1);
            }
            else
            {
                x = x + 1;
            }
        }
        
        Console.WriteLine("The result string : {0}", str_main);
        Console.WriteLine("The number of deleted letter : {0}", int_removed);
    }
    
    static void Main()
    {
        string str_main = "";
        
        Console.Write("Please input the string : ");
        str_main = Console.ReadLine();
        
        Program program = new Program();  
        program.question_2(str_main);
    }
}
