//David Gipe
//CIS 237
//1-18-17
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class WineItem
    {
        //*****************************
        //Variable / Backing fields
        //*****************************
        private string itemnumber;
        private string winename;
        private string volume;

        //*****************************
        //Properties
        //*****************************
        public string ItemNumber
        {
            get { return itemnumber; }
            set { itemnumber = value; }
        }

        public string WineName
        {
            get { return winename; }
            set { winename = value; }
        }

        public string Volume
        {
            get { return volume; }
            set { volume = value; }
        }

        //******************************
        //Public Methods
        //******************************
        
        //Adds number and name to string
        public string NumberAndName()
        {
            return itemnumber + " " + winename;
        }

        //adds all values to string
        public override string ToString()
        {
            return itemnumber + " " + winename + " " + volume;
        }

        //*****************************
        //Constructors
        //*****************************
        public WineItem(string ItemNumber, string WineName, string Volume)
        {
            this.itemnumber = ItemNumber;
            this.winename = WineName;
            this.volume = Volume;
        }
    }
}
