using System;
public class deliverable1 {
    public static void Main(string[] args)
    {

        double A2 = 1;

        while (A2 > 0) 
        
        { 


                Console.WriteLine("How many people are we making PB&J sandwiches for?");

                double people = double.Parse(Console.ReadLine());

                //sandwich ingredients
                double bread_slices = 2;
                double pb_tablespoons = 2;
                double jelly_teaspoon = 4;

                //sandwiches per person
                double sandwich = 1;

                //item contents
                double slicesperloaf = 28;
                double pb_jar = 32;
                double jelly_jar = 48;

                double slices_needed = bread_slices * people;
                double pb_tablespoons_needed = pb_tablespoons * people;
                double jelly_teaspoons_needed = jelly_teaspoon * people;

                Console.WriteLine("You need:");
                Console.WriteLine();
                Console.WriteLine(slices_needed + " slices of bread");
                Console.WriteLine(pb_tablespoons_needed + " tablespoons of peanut butter");
                Console.WriteLine(jelly_teaspoons_needed + " teaspoons of jelly");
                Console.WriteLine();
                Console.WriteLine("which is...");
                Console.WriteLine();

                double totalLoavesNeeded = Math.Ceiling(slices_needed / slicesperloaf);
                double totalPBJarsNeeded = Math.Ceiling(pb_tablespoons_needed / pb_jar);
                double totalJellyJarsNeeded = Math.Ceiling(jelly_teaspoons_needed / jelly_jar);

                Console.WriteLine(totalLoavesNeeded + " loaves of bread");
                Console.WriteLine(totalPBJarsNeeded + " jars of peanut butter");
                Console.WriteLine(totalJellyJarsNeeded + " jars of jelly");
                Console.WriteLine();
                Console.WriteLine("Would you like to restart? Enter yes or y to continue, or enter any other key to exit.");

                string answer = Console.ReadLine();

                if (answer == "y")
                {
                    A2 = 1;
                } else if (answer == "yes")
                {
                    A2 = 1;

                } else
                {
                    A2 = 0;
                }

        }
        Console.WriteLine("Goodbye");
    }
}