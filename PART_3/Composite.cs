using System;
using System.Collections.Generic;

class CompositeDemo
{
    static void Main(string[] args)
    {
        List<string> names = new List<string> { "Pablo", "Luisa", "Castri", "Sebastian", "Daniel" };
        foreach (string name in names)
        {
            Console.Write(name + ", ");
        }
        Console.WriteLine();
        Car rb21 = new Car("Honda", "Pirelli P Zero C4");
        Console.WriteLine("Engine: " + rb21.Engine);
        Console.WriteLine("Tyres: " + rb21.Tyres);
        Dictionary<string, double> grades = new Dictionary<string, double>
        {
            { "Pablo", 3.5 },
            { "Luisa", 5 },
            { "Castri", 4.8 },
            { "Sebas", 4.8 },
            { "Daniel", 4.81 }
        };
        foreach (var kvp in grades)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        }
    }
}
class Car
{
    public string Engine { get; set; }
    public string Tyres { get; set; }
    public Car(string engine, string tyres)
    {
        Engine = engine;
        Tyres = tyres;
        Console.WriteLine("Car Created!!");
    }
}