using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Console;

namespace RMSConsoleApplication
{
    class Program 
    {
        static void Main(string[] args)
        {   
   
            
                 Title = "Tenant Management System";
             string Logo;
            
             Logo = @"                                                                                                  
   _____                 _      _____                                   _      _____         _             
  |_   _|___ ___ ___ ___| |_   |     |___ ___ ___ ___ ___ _____ ___ ___| |_   |   __|_ _ ___| |_ ___ _____ 
    | | | -_|   | .'|   |  _|  | | | | .'|   | .'| . | -_|     | -_|   |  _|  |__   | | |_ -|  _| -_|     |
    |_| |___|_|_|__,|_|_|_|    |_|_|_|__,|_|_|__,|_  |___|_|_|_|___|_|_|_|    |_____|_  |___|_| |___|_|_|_|
                                                 |___|                              |___|                  

";
            string[] options = {"Update Tenant","Monthly Rental","Exit"};
            Menu mainManu =new Menu(Logo,options);
            mainManu.DisplayOptions();
            int SelectedIndex = mainManu.run();

            switch (SelectedIndex)
            {
                case 0:
                  B1_UpdateTenant b1=new  B1_UpdateTenant();
                    
                 WriteLine("\nPress any key to exit...");
                 ReadKey(true);
                 Environment.Exit(0);

                   break; 
                case 1:
                   B2_MonthlyRental b2=new  B2_MonthlyRental();

                 WriteLine("\nPress any key to exit...");
                 ReadKey(true);
                 Environment.Exit(0);

                    break; 
                 case 2:

                 WriteLine("\nPress any key to exit...");
                 ReadKey(true);
                 Environment.Exit(0);

                    break;
            }
       
    
            
        }
        
    }
      class Menu
        {
            private int SelectedIndex;
            private string[] Options;
        private string logo;
            public Menu(string Logo, string[] options)
            {
                Options =  options;
                  logo = Logo;
                SelectedIndex = 0;
            }
            public void DisplayOptions()
            {
                      WriteLine(logo);     
                for(int i=0; i < Options.Length; i++)
                {
                string currentOption = Options[i];
                string prefix;
                if (i == SelectedIndex)
                {
                    prefix =">>";
                            ForegroundColor =ConsoleColor.Black;
                            BackgroundColor = ConsoleColor.White;
                }
                else
                {
                    prefix =" ";
                            ForegroundColor =ConsoleColor.White;
                            BackgroundColor = ConsoleColor.Black;
                }
                    
                    WriteLine($"{prefix}<< {currentOption} >>");
                }
                ResetColor();
            }
             public int run()
             { ConsoleKey keypressed;
            do
            {   Clear();
                DisplayOptions();
                ConsoleKeyInfo KeyInfo = ReadKey(true);
                keypressed =KeyInfo.Key;

                if(keypressed == ConsoleKey.UpArrow)
                {
                    SelectedIndex--;
                    if (SelectedIndex == -1)
                    {
                        SelectedIndex = Options.Length-1;
                    }
                }
                else if(keypressed == ConsoleKey.DownArrow)
                {
                    SelectedIndex++;
                      if (SelectedIndex == Options.Length)
                    {
                        SelectedIndex = 0;
                    }
                }
            }while(keypressed != ConsoleKey.Enter);
              
            return SelectedIndex;

             }
        }
  
}
//   ConsoleKeyInfo keypressed = ReadKey();
//keypressed.Key == ConsoleKey.Enter
/*  class exit
    {
          
            
                WriteLine("\nPress any key to exit...");
                ReadKey(true);
                Environment.Exit(0);

            
    }*/