using System;
using System.Collections.Generic;

namespace Lab3App
{
    public class Axe : Tool
    {

        public Axe(string description)
        {
            this.Description = description;
        }

        public override void Display()
        {
            Console.WriteLine("Axe " + this.Description + " is displayed");
        }

        public override void DoAction()
        {
            Console.WriteLine("Axe is Used");
        }

    }

}