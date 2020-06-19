using System;
using System.Windows.Forms;

public class CountQuestion
{
	public static void Main()
	{
		int count=1;
		String message= "The value of count is; ";
		String question="\nDo you want to add one?";
		
		if(MessageBox.Show(message+count+question,"Count Program", MessageBoxButtons.YesNo)==DialogResult.Yes)
		{
			count= count +1;
			MessageBox.Show(message + count, "Count Program");
		}
	}
}