using System;
using System.Collections.Generic;
using System.Text;

namespace APShapeCalc
{
	class Rectangle : _2DShapes, I2DShapes
	{
		private double length = 0.0;
		private double width = 0.0;
		public override void getInput()
		{
			//User Input
			Console.WriteLine("\nEnter Length of Rectangle:"); // Asks user Rectangle Length Input

			//Vallidation for Rectangle Length
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

				//Width
				else
				{
					Console.WriteLine("\nEnter Width of Rectangle: "); // Asks user Rectangle Width Input

					//Vallidation for Rectangle Width
					if (!double.TryParse(Console.ReadLine(), out width))
					{
						Console.WriteLine(" Invalid input, please only enter numbers"); // Appears when user enters a character which isn't a number
						getInput();
					}
					else
					{
						if (width >= 100000000)
						{
							Console.WriteLine(" ERROR - Invalid, (Number To Large)"); // Appears when user enters the number 100000000 or greater
							getInput();
						}
						else if (width <= 0)
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
			}
		}

		//Calculations
		//Perimiter Calculation
		public override void calcPerimeter()
		{
			perimeter = length * 2 + width * 2;
			calcArea();
		}

		//Area Calculation
		public override void calcArea()
		{
			area = length * width;
			outputPerimeter();
		}

		//Perimiter Output
		public override void outputPerimeter()
		{
			Console.WriteLine("\n Results");
			Console.WriteLine(" -------------------------------------");
			Console.WriteLine($" Rectangle Perimiter: " + perimeter);
			outputArea();
		}

		//Area Output
		public override void outputArea()
		{
			Console.WriteLine($" Rectangle Area: " + area);
			Console.WriteLine(" -------------------------------------");
			txtSave();
		}

		//Textfile Save
		public override void txtSave()
		{
			TextEditor text = new TextEditor();
			ProxyTextEditor proxytext = new ProxyTextEditor(text);
			TextManager textmanager = new TextManager(proxytext);

			textmanager.option(1, area, perimeter, length, width, 0.0, "Rectangle");
		}
	}
}
