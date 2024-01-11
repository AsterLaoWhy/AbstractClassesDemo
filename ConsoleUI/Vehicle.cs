using System;

internal abstract class Vehicle
{
	public string year { get; set; } = "something generic in the Vehicle class";
    public string make { get; set; } = "something generic in the Vehicle class";
    public string model { get; set; } = "something generic in the Vehicle class";
	public abstract void DriveAbstract();
	public virtual void DriveVirtual() 
	{ 
		Console.WriteLine($"Here in my garage is an {year} {make} {model} but you know what I love more than cars? Knowledge!"); 
	}
    public virtual void DisplayInfo()
    {
        Console.WriteLine($"\nYear:{year} \n Make:{make} \n Model:{model}.");
    }
}
