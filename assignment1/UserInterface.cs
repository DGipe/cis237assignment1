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
            this.LoadMenu();  //calling a method

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
            //Request load
            
            this.MainMenu();  //calling a method

            //Get the input from the user
            String input = Console.ReadLine();

            //While te imput is not valid re-get the input
            while (input != "1" && input != "2" && input != "3" && input != "4")
            {

                //Print Error message
                this.PrintErrorMessage();

                //re-spring the menu
                this.MainMenu();

                //et the input from the console again
                input = Console.ReadLine();

            }
            //At this pint, I kow the input is a valid number of either
            //a 1 or a 2.

            return Int32.Parse(input);
        }

        public string Search()
        {
            this.SearchMenu();

            string input = Console.ReadLine();

            return input;

        }

        public string AddItem()
        {
            Console.WriteLine("Item number?");

            string input1 = Console.ReadLine();

            Console.WriteLine("Item name?");

            string input2 = Console.ReadLine();

            Console.WriteLine("Item volume?");

            string input3 = Console.ReadLine();

            List<string> newLines = new List<string>();
            newLines.Add(input1 + "," + input2 + "," + input3);
            File.AppendAllLines("../../../datafiles/WineList.csv", newLines);

            return null;             
        }
                

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
            Console.WriteLine("Complete!");
            Console.WriteLine("");
            Console.WriteLine("Please make a selection:");
            Console.WriteLine("1. Print");
            Console.WriteLine("2. Search");
            Console.WriteLine("3. Add Item");
            Console.WriteLine("4. Exit");


        }

        private void PrintErrorMessage()
        {
            Console.WriteLine("That is not a valid entry Dave");
            Console.WriteLine("Please make a valid choice");
            Console.WriteLine();
        }

        private void SearchMenu()
        {
            Console.WriteLine("Please enter item number you wish to search for:");
        }


    }


}
