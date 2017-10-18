using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.ParkingValidation
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Dictionary<string, string> users = new Dictionary<string, string>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(' ').ToArray();

                string user = input[1];

                switch (input[0])
                {
                    case "register":
                        var plate = input[2];
                        if (users.ContainsKey(user))
                        {
                            Console.WriteLine($"ERROR: already registered with plate number {plate}");
                        }
                        else if (IsInvalid(plate))
                        {
                            Console.WriteLine($"ERROR: invalid license plate {plate}");
                        }
                        else if (users.ContainsValue(plate))
                        {
                            Console.WriteLine($"ERROR: license plate {plate} is busy");
                        }
                        else
                        {
                            users[user] = plate;
                            Console.WriteLine($"{user} registered {plate} successfully");
                        }
                        break;

                    case "unregister":
                        if (!users.ContainsKey(user))
                        {
                            Console.WriteLine($"ERROR: user {user} not found");
                        }
                        else
                        {
                            users.Remove(user);
                            Console.WriteLine($"user {user} unregistered successfully");
                        }
                        break;
                }
            }

            foreach (var user in users)
            {
                Console.WriteLine($"{user.Key} => {user.Value}");
            }
        }

        public static bool IsInvalid(string plate)
        {
            if (plate.Length != 8)
            {
                return true;
            }

            for (int i = 2; i < plate.Length - 2; i++)
            {
                if (!int.TryParse(plate[i].ToString(), out int number))
                {
                    return true;
                }
            }

            if (plate[0] < 65 || plate[0] > 90) return true;
            if (plate[1] < 65 || plate[1] > 90) return true;
            if (plate[6] < 65 || plate[6] > 90) return true;
            if (plate[7] < 65 || plate[7] > 90) return true;
            return false;
        }
    }
}