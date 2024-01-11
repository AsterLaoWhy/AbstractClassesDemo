using System;

internal class Car:Vehicle
{
	public Car()
	{
	}
	public bool hasRoof { get;set; }
	public override void DriveAbstract() 
	{
		Console.WriteLine("Car go vroom");
	}
    public override void DisplayInfo()
    {
        Console.WriteLine($"\nYear:{year} \n Make:{make} \n Model:{model} \n Has a Roof:{hasRoof}.");
    }
}
