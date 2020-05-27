//Contains both a void and return-type methods

using System;

public class ManyMethods
{
	public static void Main()
	{
		//Get two values return method
		int value1=GetNumber();
		int value2=GetNumber();
		
		//Call void Division Method
		Division(value1, value2);
	}
	
	public static int GetNumber()
	{
		string numString;
		int number;
		Console.Out.Write("Enter a whole number: ");
		numString=Console.ReadLine();
		number=Convert.ToInt32(numString);
		return number;
	}
	
	public static void Division(int numerator, int denominator)
	{
		int quotient=numerator/denominator;
		int remainder=numerator %denominator;
		
		Console.Out.WriteLine( numerator +" divided by "+denominator +
		" equals");
		Console.Out.WriteLine(quotient +" with a remainder of "+remainder);
		return;
	}
}