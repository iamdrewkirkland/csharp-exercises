using System;
using System.Collections.Generic;
using Roommates.Models;
using Roommates.Repositories;

namespace Roommates
{
    class Program
    {
        /// <summary>
        ///  This is the address of the database.
        ///  We define it here as a constant since it will never change.
        /// </summary>
        private const string CONNECTION_STRING = @"server=localhost\SQLExpress;database=Roommates;integrated security=true";

        static void Main(string[] args)
        {
            RoomRepository roomRepo = new RoomRepository(CONNECTION_STRING);

            Console.WriteLine("Getting All Rooms:");
            Console.WriteLine();

            List<Room> allRooms = roomRepo.GetAll();

            foreach (Room room in allRooms)
            {
                Console.WriteLine($"{room.Id} {room.Name} {room.MaxOccupancy}");
            }

            //Console.WriteLine("----------------------------");
            //Console.WriteLine("Getting Room with Id 1");

            //Room singleRoom = roomRepo.GetById(1);

            //Console.WriteLine($"{singleRoom.Id} {singleRoom.Name} {singleRoom.MaxOccupancy}");

            //Room bathroom = new Room
            //{
            //    Name = "Bathroom",
            //    MaxOccupancy = 1
            //};

            //roomRepo.Insert(bathroom);

            //Console.WriteLine("-------------------------------");
            //Console.WriteLine($"Added the new Room with id {bathroom.Id} and name {bathroom.Name}: {bathroom.MaxOccupancy}");

            //bathroom.Name = "updated room";
            //bathroom.MaxOccupancy = 3;
            //roomRepo.Update(bathroom);

            Room frontbedroom = roomRepo.GetById(1);
            Console.WriteLine("Please enter a new name for the front bedroom.");
            frontbedroom.Name = Console.ReadLine();
            roomRepo.Update(frontbedroom);

            Console.WriteLine("I just updated a room.");
            Console.WriteLine("Now I'm getting all the rooms again.");

            roomRepo.Delete(8);
            roomRepo.Delete(9);
            roomRepo.Delete(10);
            roomRepo.Delete(11);
            roomRepo.Delete(12);



            allRooms = roomRepo.GetAll();

            foreach (Room room in allRooms)
            {
                Console.WriteLine($"{room.Id} {room.Name} {room.MaxOccupancy}");
            }

        }
    }
}