using System;

namespace Deliverable1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write ("What kind of trip would you like to go on, musical, tropical, or adventurous? ");
            string vacationType = Console.ReadLine();

            Console.Write ("How many are in your group? ");
            int groupSize = int.Parse(Console.ReadLine());

            string destination = "";
            if (vacationType == "musical") {          
                destination = "New Orleans";
            } else if (vacationType == "tropical") {
                destination = "a beach vacation in Mexico";
            } else {
                destination = "whitewater rafting in the Grand Canyon";
            }

            string travel = "";
            if (groupSize <= 2) {
                travel = "first class flight";
            } else if (groupSize <=5) {
                travel = "helicopter";
            } else {
                travel = "charter flight";
            }

            
            string result = "Since you’re a group of " + groupSize + " going on a " + vacationType + " vacation, you should take a " + travel + " to " + destination;

            Console.WriteLine(result);

        }
    }
}
