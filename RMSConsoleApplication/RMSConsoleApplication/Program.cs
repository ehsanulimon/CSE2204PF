using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RMSConsoleApplication
{
    class Program 
    {
        static void Main(string[] args)
        {   int choice;
        string logo;
             logo = @"                                                                                                  
   _____                 _      _____                                   _      _____         _             
  |_   _|___ ___ ___ ___| |_   |     |___ ___ ___ ___ ___ _____ ___ ___| |_   |   __|_ _ ___| |_ ___ _____ 
    | | | -_|   | .'|   |  _|  | | | | .'|   | .'| . | -_|     | -_|   |  _|  |__   | | |_ -|  _| -_|     |
    |_| |___|_|_|__,|_|_|_|    |_|_|_|__,|_|_|__,|_  |___|_|_|_|___|_|_|_|    |_____|_  |___|_| |___|_|_|_|
                                                 |___|                              |___|                  
";
             Console.WriteLine(logo);
             choice = Int32.Parse(Console.ReadLine());
            if (choice == 1)
            {
                B1_UpdateTenant b1 = new B1_UpdateTenant();
            }
            else if (choice ==2)
            {
                B2_MonthlyRental b2 = new B2_MonthlyRental();
            }
            else if (choice ==3)
            {
               Program n= new Program();
            }
        }
    }
}
