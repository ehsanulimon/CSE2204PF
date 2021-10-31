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
    
            string[] listoptions = {"Show the Tenant info","Add new Tenant info","Tenant update","Tenant deletes","Exit"};
            listMenu worklist =new listMenu(listoptions);
            worklist.DisplayOptionsList();
            int SelectedIndex = worklist.run();
              
              switch (SelectedIndex)
            {
                case 0:
                      search_tenant();
                    B1_UpdateTenant n0 =new B1_UpdateTenant();
                    break;
                case 1:
                    addnew_tenant();
                    B1_UpdateTenant n1 =new B1_UpdateTenant();
                    break;
                case 2:
                      update();
                    B1_UpdateTenant n2 =new B1_UpdateTenant();
                    break;
                case 3:
                      delete();
                    B1_UpdateTenant n3 =new B1_UpdateTenant();
                    break;
                case 4:
                    
                      WriteLine("Your work is done and you can go now.");
                 break;
             
            }
        }
        ///////////////////inner part start///////////////////////

    public static void addnew_tenant()
        {
            if (!File.Exists(@"E:/B1_UpdateTenant.txt"))
            {
                File.Create(@"E:/B1_UpdateTenant.txt").Close();
            }

            string name, apartmentID,address,monthlyRent,advanceMoney, phoneNumber,email,date;
             ForegroundColor =ConsoleColor.Yellow;
            WriteLine("Please. Create a new Tenant Account:");
            Write("Name ");
            name = ReadLine();
            Write("Apartment ID ");
            apartmentID = ReadLine();
            Write("Address ");
            address = ReadLine();
            Write("Monthly Rent ");
            monthlyRent = ReadLine();
            Write("Advance Money ");
            advanceMoney = ReadLine();
            Write("Phone Number ");
            phoneNumber = ReadLine();
             Write("Email ");
            email = ReadLine();
             Write("Date ");
            date = ReadLine();

            try
            {
                StreamWriter sw = File.AppendText(@"E:/B1_UpdateTenant.txt");

                sw.WriteLine(name);
                sw.WriteLine(apartmentID);
               sw.WriteLine(address);
             sw.WriteLine(monthlyRent);
             sw.WriteLine(advanceMoney);
                 sw.WriteLine(phoneNumber);
                sw.WriteLine(email);
                 sw.WriteLine(date);

                sw.Close();
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex);
            }

        }
  /* public static void  info()
        {    
                StreamReader sr = new StreamReader(@"E:/sp_20.txt");
               string name="abc", apartmentID,address,monthlyRent,advanceMoney, phoneNumber,email,date;
          

               Write("Show all info (Y)\nSearch info (N): ");
                  string  str = ReadLine();
         
                string sY = "Y";
                bool bY = str.Contains(sY);
                 string sy = "y";
                bool by = str.Contains(sy);
                string sN = "N";
                bool bN = str.Contains(sN);
                 string sn = "n";
                bool bn = str.Contains(sn);

                if (bY == true || by==true)
                {
                 //  allinfo();
          string search_name;
            int found = 0;
            Console.WriteLine("Enter the Tenant name to show details:");
            search_name = Console.ReadLine();

            while (name!=null)
            {
                name = sr.ReadLine();
                apartmentID = sr.ReadLine();
                address = sr.ReadLine();
                monthlyRent = sr.ReadLine();
                advanceMoney = sr.ReadLine();
                phoneNumber = sr.ReadLine();
                email = sr.ReadLine();
                date = sr.ReadLine();

                if (name !=null && name.ToUpper().Equals(search_name.ToUpper()))
                {
                    found = 1;
                         ForegroundColor =ConsoleColor.Blue;
                       
                         WriteLine("--------------------------");
                         WriteLine("|--Name         : "+name+"--|");
                         WriteLine("|--Apartment ID : "+apartmentID+"--|");
                         WriteLine("|--Address      : "+address+"--|");
                         WriteLine("|--Monthly Rent : "+monthlyRent+"--|");
                         WriteLine("|--Advance Money: "+advanceMoney+"--|");
                         WriteLine("|--Phone Number : "+phoneNumber+"--|");
                         WriteLine("|--Email        : "+email+"--|");
                         WriteLine("|--Date         : "+date+"--|");
                         
                         WriteLine("--------------------------");
                   
                    break;
                }
            }

            if(found==0)
            {
                WriteLine("No such Tenant exists.");
            }
            sr.Close();
         
                }
                else if(bN==true ||bn==true)
                {
         
                   //  search_tenant();

                
            while(name!=null)
            {
                name = sr.ReadLine();
                apartmentID = sr.ReadLine();
                address = sr.ReadLine();
                monthlyRent = sr.ReadLine();
                advanceMoney = sr.ReadLine();
                phoneNumber = sr.ReadLine();
                email = sr.ReadLine();
                date = sr.ReadLine();
                if (name != null)
                {
                     ForegroundColor =ConsoleColor.Green;
                       
                         WriteLine("--------------------------");
                         WriteLine("|--Name         : "+name+"--|");
                         WriteLine("|--Apartment ID : "+apartmentID+"--|");
                         WriteLine("|--Address      : "+address+"--|");
                         WriteLine("|--Monthly Rent : "+monthlyRent+"--|");
                         WriteLine("|--Advance Money: "+advanceMoney+"--|");
                         WriteLine("|--Phone Number : "+phoneNumber+"--|");
                         WriteLine("|--Email        : "+email+"--|");
                         WriteLine("|--Date         : "+date+"--|");
                         
                         WriteLine("--------------------------");
                }
            }

                        sr.Close();
                  
                }
            else
            {
                WriteLine("try again");
            }
        }
    */  public static void search_tenant()
        {
            StreamReader sr = new StreamReader(@"E:/B1_UpdateTenant.txt");

            

             string name="abc", apartmentID,address,monthlyRent,advanceMoney, phoneNumber,email,date;
          
            string search_name;
            int found = 0;
            Console.WriteLine("Enter the Tenant name to show details:");
            search_name = Console.ReadLine();

            while (name!=null)
            {
                name = sr.ReadLine();
                apartmentID = sr.ReadLine();
                address = sr.ReadLine();
                monthlyRent = sr.ReadLine();
                advanceMoney = sr.ReadLine();
                phoneNumber = sr.ReadLine();
                email = sr.ReadLine();
                date = sr.ReadLine();

                if (name !=null && name.ToUpper().Equals(search_name.ToUpper()))
                {
                    found = 1;
                         ForegroundColor =ConsoleColor.Blue;
                       
                         WriteLine("--------------------------");
                         WriteLine("|--Name         : "+name+"--|");
                         WriteLine("|--Apartment ID : "+apartmentID+"--|");
                         WriteLine("|--Address      : "+address+"--|");
                         WriteLine("|--Monthly Rent : "+monthlyRent+"--|");
                         WriteLine("|--Advance Money: "+advanceMoney+"--|");
                         WriteLine("|--Phone Number : "+phoneNumber+"--|");
                         WriteLine("|--Email        : "+email+"--|");
                         WriteLine("|--Date         : "+date+"--|");
                         
                         WriteLine("--------------------------");
                   
                    break;
                }
            }

            if(found==0)
            {
                WriteLine("No such Tenant exists.");
            }
            sr.Close();
           ReadLine();
        }
     /*
      public static void allinfo()
        {
            StreamReader sr = new StreamReader(@"E:/sp_20.txt");
            string name="abc", apartmentID,address,monthlyRent,advanceMoney, phoneNumber,email,date;

            while(name!=null)
            {
                name = sr.ReadLine();
                apartmentID = sr.ReadLine();
                address = sr.ReadLine();
                monthlyRent = sr.ReadLine();
                advanceMoney = sr.ReadLine();
                phoneNumber = sr.ReadLine();
                email = sr.ReadLine();
                date = sr.ReadLine();
                if (name != null)
                {
                     ForegroundColor =ConsoleColor.Green;
                       
                         WriteLine("--------------------------");
                         WriteLine("|--Name         : "+name+"--|");
                         WriteLine("|--Apartment ID : "+apartmentID+"--|");
                         WriteLine("|--Address      : "+address+"--|");
                         WriteLine("|--Monthly Rent : "+monthlyRent+"--|");
                         WriteLine("|--Advance Money: "+advanceMoney+"--|");
                         WriteLine("|--Phone Number : "+phoneNumber+"--|");
                         WriteLine("|--Email        : "+email+"--|");
                         WriteLine("|--Date         : "+date+"--|");
                         
                         WriteLine("--------------------------");
                }
            }

         ReadLine();
        }
      */

       public static void update()
        {
            StreamReader sr = new StreamReader(@"E:/B1_UpdateTenant.txt");
            ForegroundColor =ConsoleColor.Yellow;
            BackgroundColor =ConsoleColor.DarkGray;
            List<string> name = new List<string>();
            List<string> apartmentID = new List<string>();
            List<string> address = new List<string>();
            List<string> monthlyRent = new List<string>();
            List<string> advanceMoney = new List<string>();
            List<string> phoneNumber = new List<string>();
            List<string> email = new List<string>();
            List<string> date = new List<string>();

            string search_name,new_Rent;
            WriteLine("Enter Tenant name and new Rent:");
            search_name = ReadLine();
            new_Rent =ReadLine();
            string n="abc";


            while (n != null)
            {
                n = sr.ReadLine();
                name.Add(n);
                apartmentID.Add(sr.ReadLine());
                address.Add(sr.ReadLine());
                monthlyRent.Add(sr.ReadLine());
                advanceMoney.Add(sr.ReadLine());
                phoneNumber.Add(sr.ReadLine());
                email.Add(sr.ReadLine());
                date.Add(sr.ReadLine());
                
            }

            string[] arr_name = name.ToArray();
            string[] arr_apartmentID = apartmentID.ToArray();
            string[] arr_address = address.ToArray();
            string[] arr_monthlyRent = monthlyRent.ToArray();
            string[] arr_advanceMoney= advanceMoney.ToArray();
            string[] arr_phoneNumber = phoneNumber.ToArray();
            string[] arr_email = email.ToArray();
            string[] arr_date = date.ToArray();

            for (int i = 0; i < arr_name.Length-1; i++)
            {
                WriteLine(i+". "+ arr_name[i]);
            }

            
            for (int i=0;i<arr_name.Length-1;i++)
            {
                if(search_name.ToUpper().Equals(arr_name[i].ToUpper()))
                {
                    arr_monthlyRent[i] = new_Rent;
                }
            }
            
            sr.Close();

            StreamWriter sw = new StreamWriter(@"E:/B1_UpdateTenant.txt");


            for (int i = 0; i < arr_name.Length-1; i++)
            {
                if(arr_name[i] == null)
                {
                    continue;
                }
                sw.WriteLine(arr_name[i]);
                sw.WriteLine(arr_apartmentID[i]);
                sw.WriteLine(arr_address[i]);
                sw.WriteLine(arr_monthlyRent[i]);
                sw.WriteLine(arr_advanceMoney[i]);
                sw.WriteLine(arr_phoneNumber[i]);
                sw.WriteLine(arr_email[i]);
                sw.WriteLine(arr_date[i]);
            }
            sw.Close();

        }

        public static void delete()
        {
            StreamReader sr = new StreamReader(@"E:/B1_UpdateTenant.txt");

            ForegroundColor =ConsoleColor.DarkRed;
            BackgroundColor =ConsoleColor.Gray;
            List<string> name = new List<string>();
            List<string> apartmentID = new List<string>();
            List<string> address = new List<string>();
            List<string> monthlyRent = new List<string>();
            List<string> advanceMoney = new List<string>();
            List<string> phoneNumber = new List<string>();
            List<string> email = new List<string>();
            List<string> date = new List<string>();

            string search_name;
             WriteLine("Enter Tenant name to delete:");
            search_name = ReadLine();
            string n = "abc";
            while (n != null)
            {
                n = sr.ReadLine();
                name.Add(n);
                apartmentID.Add(sr.ReadLine());
                address.Add(sr.ReadLine());
                monthlyRent.Add(sr.ReadLine());
                advanceMoney.Add(sr.ReadLine());
                phoneNumber.Add(sr.ReadLine());
                email.Add(sr.ReadLine());
                date.Add(sr.ReadLine());

            }

               string[] arr_name = name.ToArray();
            string[] arr_apartmentID = apartmentID.ToArray();
            string[] arr_address = address.ToArray();
            string[] arr_monthlyRent = monthlyRent.ToArray();
            string[] arr_advanceMoney= advanceMoney.ToArray();
            string[] arr_phoneNumber = phoneNumber.ToArray();
            string[] arr_email = email.ToArray();
            string[] arr_date = date.ToArray();

            sr.Close();

            StreamWriter sw = new StreamWriter(@"E:/B1_UpdateTenant.txt");

            for (int i = 0; i < arr_name.Length-1; i++)
            {
                if (search_name.ToUpper().Equals(arr_name[i].ToUpper()))
                {
                    continue;
                }
                sw.WriteLine(arr_name[i]);
                sw.WriteLine(arr_apartmentID[i]);
                sw.WriteLine(arr_address[i]);
                sw.WriteLine(arr_monthlyRent[i]);
                sw.WriteLine(arr_advanceMoney[i]);
                sw.WriteLine(arr_phoneNumber[i]);
                sw.WriteLine(arr_email[i]);
                sw.WriteLine(arr_date[i]);
            }
            sw.Close();

        }
        /////////////inner part end///////////////
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
                            BackgroundColor = ConsoleColor.DarkRed;
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
