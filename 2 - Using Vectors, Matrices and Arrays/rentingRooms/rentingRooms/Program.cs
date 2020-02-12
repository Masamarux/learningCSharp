using System;

namespace rentingRooms {
    class Program {
        static void Main(string[] args) {
            int rooms;
            string name, email;
            int roomNumber;
            Room[] rentedRooms = new Room[9];

            Console.Write("How many rooms will be rented? ");
            rooms = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 0; i < rooms; i++) {
                Console.WriteLine($"Rent #{i + 1}");
                Console.Write("Name: ");
                name = Console.ReadLine();
                Console.Write("Email: ");
                email = Console.ReadLine();
                Console.Write("Room: ");
                roomNumber = int.Parse(Console.ReadLine());
                rentedRooms[roomNumber - 1] = new Room(name, email);
                Console.WriteLine();
            }

            Console.WriteLine("Busy rooms");
            for (int i = 0; i < rentedRooms.Length; i++) {
                if (rentedRooms[i] != null) {
                    Console.WriteLine($"{i + 1}: " + rentedRooms[i]);
                }
            }
        }
    }
}
