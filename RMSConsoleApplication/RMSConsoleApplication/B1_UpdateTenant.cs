using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace RMSConsoleApplication
{
    class B1_UpdateTenant
    {
        public B1_UpdateTenant()
        {
           
            Clear();
     
            string[] listoptions = {"Show all Tenant info","Add new Tenant info","Tenant update","Tenant deletes","Exit"};
            listMenu worklist =new listMenu(listoptions);
            worklist.DisplayOptionsList();
            int SelectedIndex = worklist.run();
              
              switch (SelectedIndex)
            {
                case 0:
                    WriteLine("Show all Tenant info");
                         test();
                         ReadKey(true);
                    B1_UpdateTenant n0 =new B1_UpdateTenant();
                    break;
                case 1:
                     WriteLine("Add new Tenant info");
                         ReadKey(true);
                    B1_UpdateTenant n1 =new B1_UpdateTenant();
                    break;
                case 2:
                     WriteLine("Tenant update");
                         ReadKey(true);
                    B1_UpdateTenant n2 =new B1_UpdateTenant();
                    break;
                case 3:
                     WriteLine("Tenant deletes");
                         ReadKey(true);
                    B1_UpdateTenant n3 =new B1_UpdateTenant();
                    break;
                case 4:
                     WriteLine("Exit");
                         ReadKey(true);
                   
                    break;
                   
            }
        }
        public void test()
        {
             WriteLine("Show all Tenant info");
        }

    }
     class listMenu
        {
            private int SelectedIndex;
            private string[] ListOptions;
          
            public listMenu( string[] listoptions)
            {
                ListOptions =  listoptions;
                  
                SelectedIndex = 0;
            }
            public void DisplayOptionsList()
            {
                      
                for(int i=0; i < ListOptions.Length; i++)
                {
                string currentOption = ListOptions[i];
              
                if (i == SelectedIndex)
                {
                   
                            ForegroundColor =ConsoleColor.White;
                            BackgroundColor = ConsoleColor.Red;
                }
                else
                {
                    
                            ForegroundColor =ConsoleColor.Red;
                            BackgroundColor = ConsoleColor.Black;
                }
                    
                    WriteLine($"\t  {currentOption}  \t");
                }
                ResetColor();
            }
             public int run()
             { ConsoleKey keypressed;
            do
            {   Clear();
                DisplayOptionsList();
                ConsoleKeyInfo KeyInfo = ReadKey(true);
                keypressed =KeyInfo.Key;

                if(keypressed == ConsoleKey.UpArrow)
                {
                    SelectedIndex--;
                    if (SelectedIndex == -1)
                    {
                        SelectedIndex = ListOptions.Length-1;
                    }
                }
                else if(keypressed == ConsoleKey.DownArrow)
                {
                    SelectedIndex++;
                      if (SelectedIndex == ListOptions.Length)
                    {
                        SelectedIndex = 0;
                    }
                }
            }while(keypressed != ConsoleKey.Enter);
              
            return SelectedIndex;

             }
        }
}
