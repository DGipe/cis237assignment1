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

            //intial Wine Item array
            WineItem[] wineitems = new WineItem[4000];

            //Recieve user input
            int choice = ui.GetLoadInput();


            //While the chouse they slected is not 2, continue to do work
          //  while (choice != 2)

           //See if the input they sent is equal to 1.
           if (choice == 1)
           {
                    //Make the string for the path to the csv file
                    string pathToCsv = "WineList.csv";

                    //Instanciate the csvProcessor
                    CSVProcessor csvProcessor = new CSVProcessor();
                    //Call the ImportCSV method sending over the path and
                    //the array to store the read in records to.
                    csvProcessor.ImportCsv(pathToCsv, wineitems);
            }
           
           else
            {
                Environment.Exit(0);
            }
  
            

            //Recieve user input
            int choice1 = ui.GetInput();

            //Keep running menu untill exited
            while (choice1 != 4)
            {   
                //Print option
                if (choice1 == 1)
                {
                    //Create a string that can be concated to
                    string outputString = "";

                    //Print out the employees in the array
                    foreach (WineItem wineitem in wineitems)
                    {
                        if (wineitem != null)
                        {
                            //Concat to the outputString
                            outputString += wineitem.ToString() +
                                Environment.NewLine;
                        }
                    }

                    //Use the UI class to print out the string
                    ui.Output(outputString);
                    choice1 = ui.GetInput();
                }

                //Search Option
                if (choice1 == 2)
                {

                    choice1 = ui.GetInput();
                }

                //Add Item option 
                if (choice1 == 3)
                {

                    choice1 = ui.GetInput();
                }

                Environment.Exit(0);
            }


            //re-prompt te user for input
            //                choice = ui.GetPrintInput();


        }
    }
}
