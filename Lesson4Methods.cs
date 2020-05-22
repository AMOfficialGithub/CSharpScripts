using System;

public class Lesson4Methods
{
public static void Main()
{
//declaring local main variables
//user input 
string strFirst, strSecond;
//storage input
int first, second, result;

Console.Out.Write("Enter a number: ");

//using strFirst as the user value
strFirst=Console.ReadLine();
//Converting strFirst into an Int and storing it in first
first=Convert.ToInt32(strFirst);

Console.Out.Write("Enter a second number: ");
strSecond=Console.ReadLine();
second=Convert.ToInt32(strSecond);

//Once the Sum method is called, execution to the main method
//stops until the Sum method is finished executing its code
result=Sum(first, second);

Console.Out.WriteLine("The sum is: "+result);
}

//Sum Method. The values of first is copied into the number1 variables
//the value of second is copied into the number2 variable
public static int Sum(int number1, int number2)
	{
	int answer= number1+number2;
	//When the value of answer is returned, it is copied into 
	//the result variable
	return answer;
	}
}

