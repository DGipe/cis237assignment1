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
        public string FirstAndLastName()
        {
            return itemnumber + " " + winename;
        }

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

        public WineItem()
        {
            //Do Nothing
        }

    }
}
