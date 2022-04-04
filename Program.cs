// See https://aka.ms/new-console-template for more information
using FactoryDesign;

Console.WriteLine("Hello, World!");
var car = CarFactory.GetTypeCar("B");
car.Start();
ford();
Honda();
Console.ReadLine();



static  void ford()
{
    var car = CarFactory.GetTypeCar("F");
    car.Start();
}
static void Honda()
{
    var car = CarFactory.GetTypeCar("H");
    car.Start();
}
