using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tryAnimal
{
    class Animals
    {
        public string animalName { get; set; }

        public string diet { get; set; }

        public void newName()
        {
            Console.Write("Name your Animal..\n");
             this.animalName = Console.ReadLine();
        }

        public void eat()
        {
           string food = "Animal Food";
           Console.WriteLine("Your Animal: " + this.animalName + " drank " + food);
        }

        public void drink()
        {
            string water = "Water";
            Console.WriteLine("Your Animal: "+ this.animalName +" drank "+ water);
        }

        public void sleep()
        {
            Console.WriteLine("Your Animal: "+ this.animalName +" sleeps..");
        }

    }
}
