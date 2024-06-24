using System;
namespace ByType{
    class Program{
       
            //method with int parameter
            static void Display(int number){
                System.Console.WriteLine("int type:"+number);
            }
            //method with string parameter
            static void Display(string name){
                System.Console.WriteLine("string type: "+name);
            }
            static void Main(string []args){
                Display(100);
                Display("Naveenkumar");
                Console.ReadLine();
        }
    }
}