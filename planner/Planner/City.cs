using System;
using System.Collections.Generic;

namespace Planner
{

    class City
    {
        private string _cityName;

        private int _yearEstablished;
        public string Mayor { get; set; }

        private List<Building> _buildings;

        public void AddBuilding(Building building)
        {
            _buildings.Add(building);
        }

        public void Establish(int year)
        {
            _yearEstablished = year;
        }
        public City(string name)
        {
            _cityName = name;
        }
    }
}