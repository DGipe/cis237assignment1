using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create class instances
            UserInterface ui = new UserInterface();
            CSVProcessor csv = new CSVProcessor();
            WineItemCollection wic = new WineItemCollection();
            WineItem wines = new WineItem();

            //Recieve user input
            int choice = ui.GetUserInput();

            //While the chouse they slected is not 2, continue to do work
            while (choice != 2)
            {
                //See if the input they sent is equal to 1.
                if (choice == 1)
                {
                    //Load CSV file
                    csv.LoadWine();




                }

                //re-prompt te user for input
                choice = ui.GetUserInput();
            }

        }
    }
}
