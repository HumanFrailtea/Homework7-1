
/// Homework No.__ Exercise No.__
/// File Name:     HW7-1.sln
/// @author:       Upendra Samaranayake
/// Date:          Oct. 27, 2019
///
/// Problem Statement: Define an Odometer class to track fuel usage and miles per gallon.
///    
/// Overall Plan (step-by-step, how you want the code to make it happen):
/// 1. Create new odometer using default constructor.
/// 2. Set model of car with efficiency and add 100 miles.
/// 3. Print number of gallons after 100 miles and then add another 50 and print that.
/// 4. Set another model and do the same.

///
using System;

namespace Homework7
{
    public class Driver
    {

        public static void Main(string[] args)
        {

            Odometer o1 = new Odometer(); 

            o1.Model = "fuel efficient Honda Car"; 

            o1.Efficiency = 45.045; 

            o1.addMiles(100); 

            Console.WriteLine("For your fuel efficient Honda Car");


            Console.Write("After 100 miles, {0:F2} gallons used.", o1.numberOfGallons());

            o1.addMiles(50); 


            Console.Write("After another 50 miles, {0:F2} gallons used.\n", o1.numberOfGallons());


            o1.Model = "gas guzzler Porsche Car";

            o1.Efficiency = 13.0039;

            o1.reset();

            o1.addMiles(100);

            Console.WriteLine("For your gas guzzler Porsche Car");

            

            Console.Write("After 100 miles, {0:F2} gallons used.", o1.numberOfGallons());

            o1.addMiles(50);


            Console.Write("After another 50 miles, {0:F2} gallons used.", o1.numberOfGallons());

        }

    }

public class Odometer
    {

        private string model;

        private int miles;

        private double efficiency;

        public Odometer()

        {

            this.model = "Default Model";

            this.miles = 0;

            this.efficiency = 40.00;

        }

        public Odometer(string model, int miles, double efficiency)

        {

            this.model = model;

            this.miles = miles;

            this.efficiency = efficiency;

        }

        public virtual double Efficiency
        {
            set

            {

                this.efficiency = value;

            }
        }

        public virtual string Model
        {
            set

            {

                this.model = value;

            }
        }

        public virtual void reset()

        {

            this.miles = 0;

        }

        public virtual void addMiles(int miles)

        {

            this.miles += miles;

        }

        public virtual double numberOfGallons()

        {

            return (double)miles / efficiency;

        }

    }

}
