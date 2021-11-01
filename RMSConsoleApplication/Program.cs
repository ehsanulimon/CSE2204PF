using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace NewConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            if (!File.Exists(@"L:/Monthly_Rental.txt"))
            {
                File.Create(@"L:/Monthly_Rental.txt").Close();
            }
            MainMenu();
            RPM();
            PUpdate();
        }


        static void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("=================================");
            Console.WriteLine(":::::::::Monthly Rental::::::::");
            Console.WriteLine("=================================");
            Console.WriteLine("Option 1. Show all apartment info");
            Console.WriteLine("Option 2. Rent payments method");
            Console.WriteLine("Option 3. Payments update");
            Console.WriteLine("Option 4. Check the monthly rent");
            Console.WriteLine("Option 5. Exit");
            Console.WriteLine("Please type 1 or 2 or 3 or 4 or 5");
            string myoptions;
            myoptions = Console.ReadLine();
            //myoption = Int32.Parse(Console.ReadLine());
            switch (myoptions)
            {
                case "1":
                    Info();
                    break;
                case "2":
                    RPM();
                    break;
                case "3":
                    PUpdate();
                    break;
                case "4":
                    CMR();
                    break;
                case "5":
                    Exit();
                    break;
                   
            }
            MainMenu();

        }

        static void Info()
        {
            /*
            string[] apartment = { "Apartment-1: This apartment covering 1500 sqft with 3 large Bedroom with attached Bath,\n Open Drawing & Dining Area, 2 balcony, Massive Kitchen,\n Store & Servant Room as well as 1 reserved Car Parking. \n", "Apartment-2:\n", "Apartment-3:\n", "Apartment-4:\n", "Apartment-5:\n", "Apartment-6:\n" };
            for(int i = 0; i < apartment.Length; i++)
            { 
                Console.WriteLine(apartment[i]);
            }
            Console.ReadKey();*/
            //Console.ReadLine();
            
            Console.WriteLine("Apartment-1:\n This apartment covering 1500 sqft with 3 large Bedroom with attached Bath,\n Open Drawing & Dining Area, 2 balcony, Massive Kitchen, Store & Servant\n Room as well as 1 reserved Car Parking.");
            Console.WriteLine("Apartment-2:\n This apartment covering 1500 sqft with 3 large Bedroom with attached Bath,\n Open Drawing & Dining Area, 2 balcony, Massive Kitchen, Store & Servant\n Room as well as 1 reserved Car Parking.");
            Console.WriteLine("Apartment-3:\n This apartment covering 1500 sqft with 3 large Bedroom with attached Bath,\n Open Drawing & Dining Area, 2 balcony, Massive Kitchen, Store & Servant\n Room as well as 1 reserved Car Parking.");
            Console.WriteLine("Apartment-4:\n This apartment covering 1500 sqft with 3 large Bedroom with attached Bath,\n Open Drawing & Dining Area, 2 balcony, Massive Kitchen, Store & Servant\n Room as well as 1 reserved Car Parking.");
            Console.WriteLine("Apartment-5:\n This apartment covering 1500 sqft with 3 large Bedroom with attached Bath,\n Open Drawing & Dining Area, 2 balcony, Massive Kitchen, Store & Servant\n Room as well as 1 reserved Car Parking.");
            Console.WriteLine("Apartment-6:\n This apartment covering 1500 sqft with 3 large Bedroom with attached Bath,\n Open Drawing & Dining Area, 2 balcony, Massive Kitchen, Store & Servant\n Room as well as 1 reserved Car Parking.");
            Console.ReadLine();
            
        }

            
        
          

        static void RPM()
        {
            int choice;
            while (true)
            {

                Console.WriteLine("Rent payments method");
                Console.WriteLine("Choose your Payment Method");
                Console.WriteLine("Option 1. bKash");
                Console.WriteLine("Option 2. Nagad");
                Console.WriteLine("Option 3. Rocket");
                Console.WriteLine("Option 4. Cash");
                Console.WriteLine("If you Payment in Cash Please Choose Option 4");
                //Console.ReadLine();
                choice = Int32.Parse(Console.ReadLine());
                if (choice == 1)
                {
                    bKash();
                    break;
                }
                else if (choice == 2)
                {
                    Nagad();
                    break;
                }
                else if (choice == 3)
                {
                    Rocket();
                    break;
                }
                 else if (choice == 4)
                 {


                     // Console.ReadLine();
                     Cash();
                     break;
                 }
                else
                {
                    Console.WriteLine("Wrong Key And Try Again");
                    Console.ReadLine();
                    break;
                }
            }
        }

        static void bKash()
        {
            Console.WriteLine("Please send money this number");
            Console.WriteLine("BKash-01629054376");
            Console.ReadKey();
        }
        static void Nagad()
        {
            Console.WriteLine("Please send money this number");
            Console.WriteLine("Nagad-01629054376");
            Console.ReadKey();
        }
        static void Rocket()
        {
            Console.WriteLine("Please send money this number");
            Console.WriteLine("Rocket-01629054376");
            Console.ReadKey();
        }
        static void Cash()
        {
            string Cash;
            Console.WriteLine("Write Your Payment and type Enter");
            Cash = Console.ReadLine();
            try
            {
                StreamWriter sw = File.AppendText(@"L:/Monthly_Rental.txt");
                //sw.WriteLine(Cash);
                sw.WriteLine("Cash=" + Cash);
                sw.Close();
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex);
            }


            //Console.ReadLine();
            Console.WriteLine("Thank you for Cash");
            Console.WriteLine("Cash Done");
            Console.ReadKey();
        }

        /// /////////////////////////////////

        static void PUpdate()
        {

            Console.WriteLine("P Update");
            Console.ReadLine();
            StreamReader sr = new StreamReader(@"L:/Monthly_Rental.txt");

            string Cash;
            Cash = sr.ReadLine();
            Console.WriteLine(" ");
            Console.ReadKey();

            /// Console.WriteLine("Payments Updates");
            //Console.ReadLine();
            /////
            /*
            StreamReader sr = new StreamReader(@"L:/Monthly_Rental.txt");

            List<string> Cash = new List<string>();
            string new_Cash;
            Console.WriteLine("Payments Updates");
            new_Cash = Console.ReadLine();
            string n = "abc";


            while(n != null)
            {
                n = sr.ReadLine();
                Cash.Add(n);
            }
            string[] arr_Cash = Cash.ToArray();

            for(int i=0; i<arr_Cash.Length; i++)
            {
                if(new_Cash.Equals(arr_Cash[i]))
                {
                    arr_Cash[i] = new_Cash;
                }
            }
            sr.Close();

            StreamWriter sw = new StreamWriter(@"L:/Monthly_Rental.txt");
            for (int i = 0; i < arr_Cash.Length; i++)
            {
                sw.WriteLine(arr_Cash[i]);
            }
            sw.Close();
            */
        }
        

       // public static void data_write()
        //{
           
        //}

        static void CMR()
        {
            Console.WriteLine("Check the Monthly rent");
            Console.ReadLine();
            StreamReader sr = new StreamReader(@"L:/Monthly_Rental.txt");

            string Cash;
            Cash = sr.ReadLine();
            Console.WriteLine("Monthly rent is "+Cash);
            Console.ReadKey();

        }

        static void Exit()
        {
            Console.WriteLine(".......Are you sure you want to Exit.......\n .......Press the Enter key to Confirm.......");
            Console.ReadLine();
            System.Environment.Exit(1);
        }

    }
}
