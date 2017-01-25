//David Gipe
//CIS 237
//1-18-17
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace assignment1
{
    class UserInterface
    {
        //*****************************
        //Methods
        //*****************************
        public int GetLoadInput()
        {
            //Request load
            this.LoadMenu();

            //Get the input from the user
            String input = Console.ReadLine();

            //While te imput is not valid re-get the input
            while (input != "1" && input != "2")
            {

                //Print Error message
                this.PrintErrorMessage();

                //re-spring the menu
                this.LoadMenu();

                //et the input from the console again
                input = Console.ReadLine();
            }
            return Int32.Parse(input);
        }



        public int GetInput()
        {
            //Main menu update            
            this.MainMenu();  

            //Get the input from the user
            String input = Console.ReadLine();

            //While te imput is not valid re-get the input
            while (input != "1" && input != "2" && input != "3" && input != "4")
            {

                //Print Error message
                this.PrintErrorMessage();

                //re-spring the menu
                this.MainMenu();

                //Get the input from the console again
                input = Console.ReadLine();

            }

            return Int32.Parse(input);
        }

        //Search option
        public string Search()
        {
            //display menu
            this.SearchMenu();
            //Pull user selection
            string input = Console.ReadLine();
            
            return input;

        }

        //Add option (I realize this shouldnt all  be in  the UI but I had issues getting 3 strings moved around to a diffrent class)
        public string AddItem()
        {
            Console.WriteLine("Item number?");

            string input1 = Console.ReadLine();

            Console.WriteLine("Item name?");

            string input2 = Console.ReadLine();

            Console.WriteLine("Item volume?");

            string input3 = Console.ReadLine();

            //Add to CSV
            List<string> newLines = new List<string>();
            newLines.Add(input1 + "," + input2 + "," + input3);
            File.AppendAllLines("../../../datafiles/WineList.csv", newLines);

            Console.WriteLine("");
            Console.WriteLine("Complete!");

            return null;             
        }
                
        //Output, used for print
        public void Output(string outputString)
        {
            Console.WriteLine(outputString);
        }


        private void LoadMenu()
        {
            Console.WriteLine("Load Wine list?");
            Console.WriteLine("1. Yes");
            Console.WriteLine("2. No, Exit");
        }

        private void MainMenu()
        {
            Console.WriteLine("");
            Console.WriteLine("Please make a selection:");
            Console.WriteLine("1. Print");
            Console.WriteLine("2. Search");
            Console.WriteLine("3. Add Item");
            Console.WriteLine("4. Exit");


        }

        private void PrintErrorMessage()
        {
            Console.WriteLine("That is not a valid entry");
            Console.WriteLine("Please make a valid choice");
            Console.WriteLine();
        }

        private void SearchMenu()
        {
            Console.WriteLine("Please enter item number you wish to search for:");
        }


    }


}
