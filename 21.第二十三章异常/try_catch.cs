﻿using System;

class Program
{
    static void  Main()
    {
        int x = 10;

        try
        {
            int y = 0;
            x /= y;
        }
       
        /*
        catch(DivideByZeroException)
        {
            Console.WriteLine("Handing all exceptions - keep on Running");
        }
        */

        catch(DivideByZeroException e)
        {
            Console.WriteLine("Message: {0}", e.Message);
            Console.WriteLine("Source: {0}", e.Source);
            Console.WriteLine("Stack: {0}", e.StackTrace);
        }
         

    }
}
