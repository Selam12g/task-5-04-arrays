
// See https://aka.ms/new-console-template for more information
using System;
public class program
{
    public static void Main(string[] args)
    {
        int a, i, p, k;
        Console.WriteLine("Inter a number;");
        a = int.Parse(Console.ReadLine());  
        for (i = 2; i <= a; i++)
        {
            k = 2;
            p = 1;
            while (k < i)
            {
                if (i % k ==0)
                {
                    p = 0; 
                    break;
                }
                k++;
            }
            if (p == 1)
            {
                Console.WriteLine(i + "= prime");
                
            }
        } 

    }
}
