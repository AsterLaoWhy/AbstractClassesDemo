using System;

internal class Motorcycle:Vehicle
{
	public Motorcycle()
	{
	}
    public bool hasTwoWheels { get; set; }
    public override void DriveAbstract()
    {
        Console.WriteLine("Motorcycle go vroom.");

    }
    public override void DriveVirtual()
    {
        Console.WriteLine($"Here in my garage is an {year} {make} {model} but you know what I love more than motorcycles? Knowledge!");
    }
    public override void DisplayInfo()
    {
        Console.WriteLine($"\nYear:{year} \n Make:{make} \n Model:{model} \n Has Two Wheels:{hasTwoWheels}.");
    }
}
