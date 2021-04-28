using SEDC.CSharpAdv.Homework.Class03.Exercise01.Entities;
using System;

namespace SEDC.CSharpAdv.Homework.Class03.Exercise01
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog sharko = new Dog() { Name = "Sharko", Id = -1, Color = "shareno" };
            Dog validDog = new Dog() { Name = "validno", Id = 1, Color = "crno" };
            Dog sparky = new Dog() { Name = "Sparky", Id = 10, Color = "white" };

            if (Dog.Validate(sharko))
            {
                DogShelter.ListOfDogs.Add(sharko);
            }
            if (Dog.Validate(validDog))
            {
                DogShelter.ListOfDogs.Add(validDog);
            }
            if (Dog.Validate(sparky))
            {
                DogShelter.ListOfDogs.Add(sparky);
            }
            DogShelter.PrintAll();
            Console.ReadLine();
        }
    }
}
