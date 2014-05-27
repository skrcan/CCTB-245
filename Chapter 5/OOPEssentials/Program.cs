﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPEssentials
{
    class Program
    {
        static void Main(string[] args)
        {
            DemoInheritance();
            DemoPolymorphism();
        }
        static void DemoPolymorphism()
        {
            Store otherStore = new Store(2, "Future Buy");
            Product myProduct = otherStore.GetProducts(5);
            myProduct.Purchase(); // call the method

            LaptopComputer myMac = new LaptopComputer();
            myMac.Name = "Macbook Pro";
            myMac.Purchase();
        }

        static void DemoInheritance()
        {
            // Use my store and look up a product


            Store myStore = new Store(2, "Future Buy");
            Product myProduct = myStore.GetProducts(5);

            Console.WriteLine("Store is {0}, Product is {1}", myStore.Name, myProduct.Name);
            //Explore the computer class
            //Instatiate (create) an object of data type Computer
            Computer oldMachine = new Computer();
            oldMachine.CPU = "X86";
            oldMachine.OperatingSystem = "Windows XP";
            oldMachine.Name = "HP 1234-X"; // some brand-name I bought
            oldMachine.Id = 25;
            // Instantiate a LaptopComputer, with an Initializer List
            LaptopComputer newMachine = new LaptopComputer()
            {
                Id = 77,
                Name = "HP 532-Y",
                CPU = "Athalon tiger",
                OperatingSystem = "Windows 10",
                MonitorSize = 27.5
            };
            //newMachine.
        }
    }
}
