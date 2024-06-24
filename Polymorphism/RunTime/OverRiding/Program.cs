using System;
namespace OverRiding{
    class Program{
         static void Main(string[] args)
        {
           Animal animal=new Animal();
           animal.Eat();

           //Object of dervied class
           Dog labrador=new Dog();
           labrador.Eat();
           Pomerian pomerian=new Pomerian();
           pomerian.Eat();
           new Pomerian().Eat(); 
        }
    }
}