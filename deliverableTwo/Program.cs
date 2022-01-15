using System;

namespace deliverableTwo
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double buffetPrice = 9.99;
            double coffeePrice = 2.00;
            double totalBill = 0;
            int numCoffee = 0;
            int numWater = 0;
            int x = 0;
            string drinkOrder = "";


            Console.Write("Hi. Welcome to our buffet. All you can eat for $9.99! We only charge extra for coffee. How many people are in your group? Please, parties of 6 or fewer.");
            string input = Console.ReadLine();
            int numPeople = int.Parse(input);

            if (numPeople <= 6) {

                Console.WriteLine("Great, a table for " + numPeople + "! Please follow me and take a seat. Let's get everyone started with some drinks. We've got water or coffee.");

                for (x = 1; x <= numPeople; x++)
                {
                   
                    Console.Write("Alright, person " + x + ", water or coffee?");
                    drinkOrder = Console.ReadLine();

                    if (drinkOrder == "water") {

                        numWater += 1;
                        Console.WriteLine(drinkOrder + "! Excellent choice!");

                    } else if (drinkOrder == "coffee"){

                        numCoffee += 1;
                        Console.WriteLine(drinkOrder + "! Excellent choice!");
                    } else
                    {
                        Console.WriteLine(drinkOrder + " does not compute");
                    }
                    

                }
                double sumCoffee = numCoffee * coffeePrice;
                totalBill = numPeople * buffetPrice + sumCoffee;

                Console.WriteLine("Your total bill comes to $" + totalBill);
                double buffetTotal = numPeople * buffetPrice;

                Console.WriteLine(numPeople + " buffet(s) = " + numPeople + " * $" + buffetPrice + " = $" + buffetTotal);
                Console.WriteLine(numCoffee + " coffee(s) = " + numCoffee + " * $" + coffeePrice + ".00" + " = $" + sumCoffee +".00");
                Console.WriteLine(numWater + " water(s) = free");
                Console.WriteLine("total = $" + totalBill);

            } else {

                Console.WriteLine("We don't serve your kind (large parties). I'm afraid I have the right mind to show you the door.");
            }

           
        }
    }
}
