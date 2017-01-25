using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace assignment1
{
    class CSVProcessor
    {
        public bool ImportCsv(string pathToCSVFile, WineItem[] wineitem)
        {
            //Declare the streamReader
            StreamReader streamReader = null;

            try
            {
                //declare a string for the line
                string line;

                //Intanciate the stream reader
                streamReader = new StreamReader(pathToCSVFile);

                int counter = 0;

                //While we are still reading a line from the file
                while ((line = streamReader.ReadLine()) != null)
                {
                    //Process the line\
                    processLine(line, wineitem, counter++);
                }

                //Read through the whole filie, so we can return true.
                return true;

            }

            catch (Exception e)
            {
                //OUtput the exception and the stacktrace for the exception 
                Console.WriteLine(e.ToString());
                Console.WriteLine();
                Console.WriteLine(e.StackTrace);

                //return falce because it no working
                return false;
            }
            finally
            {
                //If the stream reader was instanciated, make sure it is closed
                //before esxiting te reader
                if (streamReader != null)
                {
                    streamReader.Close();
                }
            }
        }

        private void processLine(string line, WineItem[] employees, int index)
        {
            //declare array pf parts that will contain the results of splitting
            //the read in string 
            string[] parts = line.Split(',');

            //Assign each part to a variable
            string firstName = parts[0];
            string lastName = parts[1];
            decimal salary = decimal.Parse(parts[2]);

            //Add a new employee into the array that was passed in.
            employees[index] = new Employee(firstName, lastName, salary);

        }
    }
}
