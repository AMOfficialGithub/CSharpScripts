using System;

public class HandleGetInt
{
	public static void Main()
	{
		String strNum;
		int number;
		
		Console.Write("Enter a whole number: ");
		strNum=Console.ReadLine();
		
		try
		{
			number=Convert.ToInt32(strNum);
		}
		catch(Exception e)
		{
			Console.WriteLine("Invalid whole number, 1 is used instead. ");
			number=1;
		}
		Console.WriteLine("\n\nYour number was "+number);
	}
}