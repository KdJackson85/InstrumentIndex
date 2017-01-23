using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Exercise
{
    class Instruments
    { 
        //***Fields***
        private string color;
        private string material;
        private string name;
        private double price;
        private int weight;

        protected bool strings;

        //***Constructors***

        public Instruments()
        {

        }
   
        public Instruments(string name,string color, string material, double price, int weight)
        {
            this.name = name;
            this.color = color;
            this.material = material;
            this.price = price;
            this.weight = weight;
        }

        public Instruments(double price, int weight)
        {
            this.price = price;
            this.weight = weight;
        }

        //***Properties***


        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }


        //***Methods***

        public void displayStats()
        {
            Console.WriteLine(name + ":");
            Console.WriteLine("This instrument is the color " + color + ".");
            Console.WriteLine("This instrument is made of " + material + ".");
            Console.WriteLine("This instrument typically costs $" + price + ".");
            Console.WriteLine("This instrument typically weighs " + weight + ".");

        }
        
    }
}
