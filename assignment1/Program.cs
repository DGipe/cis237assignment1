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
    class Program
    {
        
        static void Main(string[] args)
        {
            // Create class instances
            UserInterface ui = new UserInterface();
            CSVProcessor csv = new CSVProcessor();
            WineItemCollection wic = new WineItemCollection();
          
            //Make the string for the path to the csv file
            string pathToCsv = "../../../datafiles/WineList.csv";

            //intial Wine Item array
            WineItem[] wineitems = new WineItem[4000];

            //Recieve user input in regards to load file
            int choice = ui.GetLoadInput();
                        
           //See if the input they sent is equal to 1.
           if (choice == 1)
           {


                    //Instanciate the csvProcessor
                    CSVProcessor csvProcessor = new CSVProcessor();
                    //Call the ImportCSV method sending over the path and
                    //the array to store the read in records to.
                    csvProcessor.ImportCsv(pathToCsv, wineitems);
                    Console.WriteLine("");
                    Console.WriteLine("Complete!");
            }
           
           else
            {
                Environment.Exit(0);
            }

           //Return tag 
            MenuReturn:

            //Recieve user input
            int choice1 = ui.GetInput();

            //Keep running menu untill user exits
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
                    string searchString = search;
                    char csvSeparator = ',';

                    foreach (string line in File.ReadLines(pathToCsv))
                        foreach (string value in line.Replace("\"", "").Split('\r', '\n', csvSeparator))
                            if (value.Trim() == searchString.Trim())
                            {
                                Console.WriteLine("");
                                Console.WriteLine("Search Sucess!");
                                Console.WriteLine("");
                                Console.WriteLine("[ {0} ]  {1}", value, line);
                                goto MenuReturn;
                            }

                    Console.WriteLine("");
                    Console.WriteLine("No Results Found!");
                    Console.WriteLine("");
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
