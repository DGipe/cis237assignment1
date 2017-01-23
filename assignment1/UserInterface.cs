using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class UserInterface
    {
        //*****************************
        //Methods
        //*****************************
        public int GetUserInput()
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
            //At this pint, I kow the input is a valid number of either
            //a 1 or a 2.

            return Int32.Parse(input);
        }

        public void Output(string outputString)
        {
            Console.WriteLine(outputString);
        }


        private void LoadMenu()
        {
            Console.WriteLine("Load Wine list?");
            Console.WriteLine("1. Yes");
            Console.WriteLine("2. No. Exit");
        }

        private void PrintErrorMessage()
        {
            Console.WriteLine("That is not a valid entry Dave");
            Console.WriteLine("Please make a valid choice");
            Console.WriteLine();
        }
    }


}
