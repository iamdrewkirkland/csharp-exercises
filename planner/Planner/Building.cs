using System;

namespace Planner
{
    class Building
    {
        private string _designer = "Drew Kirkland";
        private DateTime _dateConstructed;
        private string _address;
        private string _owner;

        public int Stories { get; set; }
        public double Width { get; set; }
        public double Depth { get; set; }
        public double Volume
        {
            get
            {
                return Width * Depth * (Stories * 3);
            }
        }

        public void Construct()
        {
            _dateConstructed = DateTime.Now;
        }
        public void Purchase(string owner)
        {
            _owner = owner;
        }
        //Constructor Method
        public Building(string address)
        {
            _address = address;


        }
        public override string ToString()
        {
            return $@"
            {_address}
            -------------
            Designed by {_designer}
            Constructed on {_dateConstructed}
            Owned by {_owner}
            {Volume} cubic units of space
            ";
        }
    }
};
