using System;
using System.Collections.Generic;
using System.Text;

namespace APShapeCalc
{
	class Cube : _3DShapes, I3DShapes
	{
		private double length = 0.0;
		public override void getInput()
		{

			//User Input
			Console.WriteLine("\nEnter Length of Cube:"); // Asks user for Cube Length Input

			//Vallidation for Cube Length
			if (!double.TryParse(Console.ReadLine(), out length))
			{
				Console.WriteLine(" ERROR - Invalid, (Numbers Only)"); // Appears when user enters a character which isn't a number
				getInput();
			}
			else
			{
				if (length >= 100000000)
				{
					Console.WriteLine(" ERROR - Invalid, (Number To Large)"); // Appears when user enters the number 100000000 or greater
					getInput();
				}
				else if (length <= 0)
				{
					Console.WriteLine(" ERROR - Invalid, (Please Enter A Positive)"); // Appears when the user is to enter a negative number
					getInput();
				}
				else
				{
					calcVolume(); // If the user enters a valid input the the volume will be calculated
				}
			}
		}

		//Volume Calculation
		public override void calcVolume()
		{
			volume = length * length * length;
			calcSurfaceArea();
		}

		//Surface Area Calculation
		public override void calcSurfaceArea()
		{
			surfacearea = 6 * length * length;
			outputVolume();
		}

		//Volume Output
		public override void outputVolume()
		{
			Console.WriteLine("\n Results");
			Console.WriteLine(" -------------------------------------");
			Console.WriteLine($" Cube Volume: " + volume);
			outputSurfaceArea();
		}

		//Area Output
		public override void outputSurfaceArea()
		{
			Console.WriteLine($" Cube Surface Area: " + surfacearea);
			Console.WriteLine(" -------------------------------------");
			txtSave();
		}

		//Textfile Save
		public override void txtSave()
		{
			TextEditor text = new TextEditor();
			ProxyTextEditor proxytext = new ProxyTextEditor(text);
			TextManager textmanager = new TextManager(proxytext);

			textmanager.option(1, volume, surfacearea, length, 0.0, 0.0, "Cube");
		}
	}
}
