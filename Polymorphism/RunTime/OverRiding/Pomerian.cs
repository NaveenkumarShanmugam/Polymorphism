using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OverRiding
{
     class Pomerian:Dog
    {
        public override void Eat()//sealing overriding method
        {
            System.Console.WriteLine("I eat Pomerian Dog food");
        }
    }
}