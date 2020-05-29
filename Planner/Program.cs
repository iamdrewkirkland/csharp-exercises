using System;
using System.Collections.Generic;

namespace Planner
{
    class Program
    {
        static void Main(string[] args)
        {
            Building OneMain = new Building("1 Main St.")
            {
                Stories = 10,
                Width = 100,
                Depth = 100,
            };
            OneMain.Construct();
            OneMain.Purchase("Adam Richguy");

            Building TwoMain = new Building("2 Main St.")
            {
                Stories = 20,
                Width = 200,
                Depth = 200,
            };
            TwoMain.Construct();
            TwoMain.Purchase("Mo Lotsamoney");

            Building ThreeMain = new Building("3 Main St.")
            {
                Stories = 30,
                Width = 300,
                Depth = 300,
            };
            ThreeMain.Construct();
            ThreeMain.Purchase("Andy Megawealthy");

            City BigCity = new City("Big City", 2020)
            {
                Mayor = "Steve Brownlee"
            };

            BigCity.AddBuilding(OneMain);
            BigCity.AddBuilding(TwoMain);

           

            foreach (Building thisBuilding in BigCity._buildings)
            {   
                Console.WriteLine(thisBuilding);
            }
        }
    }
}
