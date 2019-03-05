using System;
using System.Collections.Generic;

namespace CollectionPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            // Three Basic Arrays
            // Create an array to hold integer values 0 through 9
            string returnArr = "[";
            int[] IntArr = new int[10];
            for(int i = 0; i < IntArr.Length; i++) {
                returnArr += ", ";
                IntArr[i] = i;
                returnArr += i.ToString();
            }
            returnArr += "]";

            Console.WriteLine(returnArr);

            // Create an array of the names "Tim", "Martin", "Nikki", & "Sara"
            string[] Names = new string[] {"Tim", "Martin", "Nikki", "Sara"};
            Console.WriteLine(Names.Length);
            // Create an array of length 10 that alternates between true and false values, starting with true
            bool[] Truthy = new bool[10];
            for(int i = 0; i < Truthy.Length; i+=2) {
                Truthy[i] = true;
                Truthy[i+1] = false;
                Console.Write(Truthy[i]);
                Console.Write(", ");
                Console.Write(Truthy[i+1]);
            }
            
            // List of Flavors
            // Create a list of ice cream flavors that holds at least 5 different flavors (feel free to add more than 5!)
            List<string> Flavors = new List<string>();
            Flavors.Add("Chocolate");
            Flavors.Add("Lemon");
            Flavors.Add("Vanilla");
            Flavors.Add("Rocky Road");
            Flavors.Add("Rainbow Serbert");
            // Output the length of this list after building it
            Console.WriteLine(Flavors.Count);
            // Output the third flavor in the list, then remove this value
            Console.WriteLine(Flavors[2]);
            Flavors.RemoveAt(2);
            // Output the new length of the list (It should just be one fewer!)
            Console.WriteLine(Flavors.Count);
            Console.WriteLine(Flavors);
            Console.WriteLine(Flavors.ToString());

            // User Info Dictionary
            // Create a dictionary that will store both string keys as well as string values
            Dictionary<string, string> Users = new Dictionary<string, string>();
            // For each name in the array of names you made previously, add it as a new key in this dictionary with value null
            foreach(string name in Names) {
                Users.Add(name, null);
            }
            Console.WriteLine(Users.Values.ToString());
            // For each name key, select a random flavor from the flavor list above and store it as the value
            Random Rand = new Random();
            foreach(string name in Names) {
                Users[name] = Flavors[Rand.Next(0, Flavors.Count)];
            }

            // Loop through the dictionary and print out each user's name and their associated ice cream flavor
            foreach(KeyValuePair<string, string> result in Users) {
                Console.WriteLine($"{result.Key} likes {result.Value}");
            }
            Console.WriteLine("---------------------------------------------");
            foreach(var result in Users) {
                Console.WriteLine($"{result.Key} likes {result.Value}");
            }
        }
    }
}
