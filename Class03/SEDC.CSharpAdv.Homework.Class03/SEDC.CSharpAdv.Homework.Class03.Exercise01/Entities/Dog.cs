using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.CSharpAdv.Homework.Class03.Exercise01.Entities
{
    public class Dog
    {
        public Dog()
        {

        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public void Bark()
        {
            Console.WriteLine("Bark Bark");
        }

        public static bool Validate(Dog dog)
        {
            if (dog.Id >= 0 && dog.Name.Length >= 2 && dog.Color.Length != 0)
            {
                return true;
            }
            return false;
        }
    }
}
