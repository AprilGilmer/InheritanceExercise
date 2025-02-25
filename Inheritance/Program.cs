using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
            var birdOne = new Bird();
            birdOne.Name = "Eagle";
            birdOne.Age = 2;
            birdOne.diet = "insects and small rodents";
            birdOne.IsNocturnal = false;
            birdOne.BeakType = "hooked";
            birdOne.CanFly = true;
            birdOne.FeatherColor = "golden brown and white";
            birdOne.WingSpan = 12;

            Console.WriteLine($"Name; {birdOne.Name}\nAge: {birdOne.Age}\nDiet: {birdOne.diet}\nNocturnal: {birdOne.IsNocturnal}\n" +
                $"Beak: {birdOne.BeakType}\nFlight: {birdOne.CanFly}\nFeather {birdOne.FeatherColor}\nWing Span: {birdOne.WingSpan}");

            var reptile = new Reptile();
            reptile.Name = "Snake";
            reptile.Age = 58;
            reptile.diet = "small rodents";
            reptile.IsNocturnal = false;
            reptile.IsVenomous = true;
            reptile.ForkTongue = true;
            reptile.ScaleColor = "brown and black";
            reptile.HasShell = false;

            Console.WriteLine($"Name; {reptile.Name}\nAge: {reptile.Age}\nDiet: {reptile.diet}\nNocturnal: {reptile.IsNocturnal}\nVenomous: " +
                $"{reptile.IsVenomous}\nDoes it have a Fork Tongue?: {reptile.ForkTongue}\nScale color: {reptile.ScaleColor}\nDoes it have a shell?: {reptile.HasShell}");

        }
    }
}
