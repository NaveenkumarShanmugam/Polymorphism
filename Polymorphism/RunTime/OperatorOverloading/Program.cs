using System;
namespace OperatorOverloading{
    class Program{
        public static void Main(string[] args)
        {
            Box box1=new Box(1.2,3.2,4.2);
            Box box2=new Box(10.1,11.1,12.2);
            //volumme of box1
            System.Console.WriteLine("Volume of Box1 :{0}",box1.CalculateVolume());
            //volume of box2
            System.Console.WriteLine("Volume of Box2 :{0}",box1.CalculateVolume());
            Box box3=box1+box2;
            System.Console.WriteLine("Volume of Box3 :{0}",box3.CalculateVolume());
            Box box4=Box.Add(box1,box2);
        }

    
    }
}