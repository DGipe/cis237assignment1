using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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
                        
           //See if the input they sent is equal to 1.
           if (choice == 1)
           {
                    //Make the string for the path to the csv file
                    string pathToCsv = "../../../datafiles/WineList.csv";

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

           //Return tag 
            MenuReturn:

            //Recieve user input
            int choice1 = ui.GetInput();

            //Keep running menu untill exited
            while (choice1 != 4)
            {

                //******************************************
                //Print option
                //******************************************
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
                    goto MenuReturn;

                }
                //****************************************
                //Search Option
                //****************************************
                if (choice1 == 2)
                {
                    string search = ui.Search();
                    string csvFile = "../../../datafiles/WineList.csv";
                    string searchString = search;
                    char csvSeparator = ',';

                    foreach (string line in File.ReadLines(csvFile))
                          foreach (string value in line.Replace("\"", "").Split('\r', '\n', csvSeparator))
                              if (value.Trim() == searchString.Trim()) // case sensitive
                                   Console.WriteLine("[ {0} ] found in: {1}", value, line);

                    goto MenuReturn;
                 }

                //****************************************
                //Add Item option 
                //****************************************
                if (choice1 == 3)
                {
                    ui.AddItem();

                    goto MenuReturn;
                }

                Environment.Exit(0);
            }

        }
    }
}
