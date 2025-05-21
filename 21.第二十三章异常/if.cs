#define DemoVersionWithoutTimeLimit
#undef DemoVersionWithTimeLimit

using System;

class Demo
{
    static void Main()
    {
        const int intExpireLength = 30;
        string strVersionDesc = null;
        int intExpireCount = 0;

#if DemoVersionWithTimeLimit
        intExpireCount = intExpireLength;
        strVersionDesc = "This version of SuperGame plus will expire in 30 days;"

#elif DemoVersionWithoutTimeLimit
        strVersionDesc = "Demo Version of Supergame plus";

#elif OEMVersion
        strVersionDesc = "Supergram plus, distributed under license";

#else
       strVersionDesc = "The original Supergame Plus!!";
        
#endif
            Console.WriteLine(strVersionDesc);
    }
    }
