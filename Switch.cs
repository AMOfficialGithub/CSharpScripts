using System;

public class Switch
{
	public static void Main()
	{
		String strLetter;
		char letter;
		
		Console.WriteLine("Enter your letter grade: ");
		strLetter=Console.ReadLine();
		letter=Convert.ToChar(strLetter);
		
		Console.Out.WriteLine("Your letter grade is "+getMessageSwitch(letter));
	}
	
	public static String getMessageSwitch(char grade)
	{
		String message;
		switch(grade)
		{
			case 'a':
			case'A':
				message="Outstanding";
				break;
			case 'c':
			case 'C':
				message="Average";
				break;
			case 'f':
			case 'F':
				message="Poor";
				break;
			default:
				message=":an error occured!";
				break;
		}
		return message;
	}
}