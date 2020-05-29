using System;
using System.Collections.Generic;

namespace Planner
{

    class City
    {
        private string _cityName;

        private int _yearEstablished;
        public string Mayor { get; set; }

        private List<Building> _buildings = new List<Building>();

        public void AddBuilding(Building building)
        {
            _buildings.Add(building);
        }

        public City(string name, int year)
        {
            _cityName = name;
             _yearEstablished = year;
        }
    }
}