using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;

namespace APShapeCalc
{
	class Circle : _2DShapes, I2DShapes
	{
		private double radius = 0.0;
		private double pi = 3.14;
		public override void getInput()
		{
			//User Input
			Console.WriteLine("\nEnter Radius of Circle:"); // Asks user for Circle Radius Input

			//Validation for Circle Radius
			if (!double.TryParse(Console.ReadLine(), out radius))
			{
				Console.WriteLine(" ERROR - Invalid, (Numbers Only)"); // Appears when user enters a character which isn't a number
				getInput();
			}
			else
			{
				if (radius >= 100000000)
				{
					Console.WriteLine(" ERROR - Invalid, (Number To Large)"); // Appears when user enters the number 100000000 or greater
					getInput();
				}
				else if (radius <= 0)
				{
					Console.WriteLine(" ERROR - Invalid, (Please Enter A Positive)"); // Appears when the user is to enter a negative number
					getInput();
				}
				else
				{
					calcPerimeter(); // If the user enters a valid input the the perimeter will be calculated
				}
			}
		}

		//Calculations
		//Perimiter Calculation
		public override void calcPerimeter()
		{
			perimeter = 2 * pi * radius;
			calcArea();
		}

		//Area Calculation
		public override void calcArea()
		{
			area = pi * radius * radius;
			outputPerimeter();
		}

		//Perimiter Output
		public override void outputPerimeter()
		{
			Console.WriteLine("\n Results");
			Console.WriteLine(" -------------------------------------");
			Console.WriteLine($" Circle Circumference: " + perimeter);
			outputArea();
		}

		//Area Output
		public override void outputArea()
		{
			Console.WriteLine($" Circle Area: " + area);
			Console.WriteLine(" -------------------------------------");
			txtSave();
		}

		//Textfile Save
		public override void txtSave()
		{
			TextEditor text = new TextEditor();
			ProxyTextEditor proxytext = new ProxyTextEditor(text);
			TextManager textmanager = new TextManager(proxytext);

			textmanager.option(1, area, perimeter, radius, 0.0, 0.0, "Circle");
		}
	}
}
