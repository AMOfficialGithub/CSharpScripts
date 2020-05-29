public class HoursRate
{
	public static void Main()
	{
		string strHours, strRate, strAnswer;
		double hours, rate, pay;
		char answer;
		
		System.Console.Out.Write("How many hours did you work last week?");
		strHours=System.Console.ReadLine();
		hours=System.Convert.ToDouble(strHours);
		
		System.Console.Out.WriteLine();
		System.Console.Out.Write("What is your hourly rate?");
		strRate=System.Console.ReadLine();
		rate=System.Convert.ToDouble(strRate);
		
		if(hours<=40.0)
			pay=hours*rate;
		else{
			pay=hours*rate;
			//Calculate overtime pay as time and a half for all over 40 hours
			pay=pay+((hours-40)*(rate/2.0));
			}
		System.Console.Out.WriteLine();
		System.Console.Out.WriteLine("Your weekly pay is: "+pay);
		
		System.Console.Out.WriteLine();
		System.Console.Out.WriteLine("Are you happy with your pay?");
		strAnswer=System.Console.ReadLine();
		answer=System.Convert.ToChar(strAnswer);
		
		if(answer =='y' || answer == 'Y')
			System.Console.Out.WriteLine("I'm glad that you are happy!");
		else
			System.Console.Out.WriteLine("Maybe next week");
	}
}
			
		