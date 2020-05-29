public class IfElse
{
public static void Main()
{
System.Console.Out.WriteLine("Enter in your age");
string age=System.Console.ReadLine();

int age2=System.Convert.ToInt32(age);

//If Else Statement
if(age2>=18)
	System.Console.Out.WriteLine("You are old enough to vote.");
else
	System.Console.Out.WriteLine("Sorry you are not old enough");
}
}