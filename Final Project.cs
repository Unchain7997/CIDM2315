using System;
using System.Collections.Generic;

namespace HotelManagementSystem {
    class Program {
        static string username = "alice";
        static string password = "alice123";
        static string studentName = "Diana Benitez";
        static Dictionary<int, string> reservedRooms = new Dictionary<int, string>();
        static Dictionary<int, int> rooms = new Dictionary<int, int>() {
            {101, 2},
            {102, 2},
            {103, 2},
            {104, 2},
            {105, 2},
            {106, 3},
            {107, 3},
            {108, 3},
            {109, 3},
            {110, 4}
        };

        static void Main(string[] args) {
            Console.WriteLine($"-----CIDM 2315 Final Project: {studentName}-----");
            Console.WriteLine("-----Welcome to Buff Hotel-----");
            Login();
            Console.ReadLine();
        }

        static void Login() {
            Console.WriteLine("--> Please input username");
            string inputUsername = Console.ReadLine();

            Console.WriteLine("--> Please input password");
            string inputPassword = Console.ReadLine();

            if (inputUsername == username && inputPassword == password) {
                Console.WriteLine("--> Login Successfully.");
                ShowMainMenu();
            }
            else {
                Console.WriteLine("--> Wrong Username/Password");
                Environment.Exit(0);
            }
        }

        static void ShowMainMenu() {
            while (true) {
                Console.WriteLine("\n********************");
                Console.WriteLine("--> Please select:");
                Console.WriteLine("1. Show Available Room");
                Console.WriteLine("2. Check-In");
                Console.WriteLine("3. Show Reserved Room");
                Console.WriteLine("4. Check-Out");
                Console.WriteLine("5. Log Out");
                Console.WriteLine("********************");

                int choice;
                if (int.TryParse(Console.ReadLine(), out choice)) {
                    switch (choice) {
                        case 1: ShowAvailableRooms();
                            break;
                        case 2: CheckIn();
                            break;
                        case 3: ShowReservedRooms();
                            break;
                        case 4: CheckOut();
                            break;
                        case 5:
                            Console.WriteLine("--> Log Out system");
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("--> Invalid choice. Please try again.");
                            break;
                    }
                }
                else {
                    Console.WriteLine("--> Invalid choice. Please try again.");
                }
            }
        }

        static void ShowAvailableRooms() {
            Console.WriteLine("---------- Available Rooms ----------");
            int availableRooms = 0;
            foreach (var room in rooms) {
                if (!reservedRooms.ContainsKey(room.Key)) {
                    Console.WriteLine($"+ Room number: {room.Key}; Capacity: {room.Value}");
                    availableRooms++;
                }
            }
            Console.WriteLine($"------- Number of Available Rooms: {availableRooms} -------");
        }

        static void CheckIn() {
            Console.WriteLine("--> Input Number of People:");
            int numberOfPeople = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("---------- Available Rooms ----------");
            int availableRooms = 0;
            foreach (var room in rooms) {
                if (!reservedRooms.ContainsKey(room.Key) && room.Value >= numberOfPeople) {
                    Console.WriteLine($"+ Room number: {room.Key}; Capacity: {room.Value}");
                    availableRooms++;
                }
            }
            Console.WriteLine($"------- Number of Available Rooms: {availableRooms} -------");

            if (availableRooms == 0) {
                Console.WriteLine("--> No suitable room at this time.");
                return;
            }

            Console.WriteLine("--> Input Room Number:");
            int roomNumber = Convert.ToInt32(Console.ReadLine());

            if (!rooms.ContainsKey(roomNumber) || reservedRooms.ContainsKey(roomNumber) || rooms[roomNumber] < numberOfPeople) {
                Console.WriteLine("--> Invalid room number.");
                return;
            }

            Console.WriteLine("--> Input Customer Name:");
            string customerName = Console.ReadLine();

            Console.WriteLine("--> Input Customer Email:");
            string customerEmail = Console.ReadLine();

            reservedRooms.Add(roomNumber, $"{customerName}; Email: {customerEmail}");
            Console.WriteLine($"--> Check-In successfully! Customer is assigned to Room {roomNumber}");
        }

        static void ShowReservedRooms() {
            Console.WriteLine("---------- Reserved Rooms ----------");
            foreach (var room in reservedRooms) {
                Console.WriteLine($"+ Room {room.Key}; Customer: {room.Value}");
            }
        }

        static void CheckOut() {
            Console.WriteLine("--> Please input room number:");
            int roomNumber = Convert.ToInt32(Console.ReadLine());

            if (!reservedRooms.ContainsKey(roomNumber)) {
                Console.WriteLine("--> Could not find customer record of this room.");
                return;
            }

            Console.WriteLine($"--> Room {roomNumber}; Customer Name: {reservedRooms[roomNumber]}");
            Console.WriteLine("--> Please confirm the customer name and input 'y' to continue Check-Out OR input any key to cancel.");
            string confirm = Console.ReadLine();

            if (confirm.ToLower() == "y") {
                reservedRooms.Remove(roomNumber);
                Console.WriteLine("--> Check-Out Successfully!");
            }
            else {
                Console.WriteLine("--> Cancel Check-Out");
            }
        }
    }
}
