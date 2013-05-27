using System;
using System.IO;
using System.Text;
using GildedRose;
using NUnit.Framework;


namespace GildedRoseTests
{
	[TestFixture]
	public class ApprovalTest
	{
		[Test]
		public void ThirtyDays()
		{
            FileStream fs = new FileStream(@"C:\Temp\XPManGildedRose\Output.txt", FileMode.Create);
            TextWriter tmp = Console.Out;

            StreamWriter sw = new StreamWriter(fs);
            Console.SetOut(sw);

			Program.Main(new string[] { });

            sw.Close();
		}
	}
	
}