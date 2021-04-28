using SEDC.CSharpAdv.Homework.Class03.Exercise01.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.CSharpAdv.Homework.Class03.Exercise01
{
    public static class DogShelter
    {
        public static List<Dog> ListOfDogs = new List<Dog>
        {

        };
        public static void PrintAll()
        {
            foreach(Dog dog in ListOfDogs)
            {
                Console.WriteLine($"#{dog.Id} - {dog.Name} - {dog.Color}");
            }
        }
    }
}
