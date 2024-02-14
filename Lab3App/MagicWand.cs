using System;
namespace Lab3App
{
    public class MagicWand: Tool
    {
        public MagicWand(string description)
        {
            this.Description = description;
        }

        public override void Display()
        {
            Console.WriteLine("MagicWand " + this.Description + " is displayed");
        }

        public override void DoAction()
        {
            Console.WriteLine("MagicWand is Used");
        }

    }
}