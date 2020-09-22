using System;
using System.Collections.Generic;
using System.Text;

namespace APShapeCalc
{
	class Cuboid : _3DShapes, I3DShapes
	{
		private double length = 0.0;
		private double width = 0.0;
		private double height = 0.0;
		public override void getInput()
		{

			//User Input
			Console.WriteLine("\nEnter Length of Cuboid:"); // Asks user Cuboid Length Input

			//Vallidation for Cuboid Length
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

				//WIDTH
				else
				{
					Console.WriteLine("\nEnter Width of Cuboid:"); // Asks user Cuboid Width Input

					//Vallidation for Cuboid Width
					if (!double.TryParse(Console.ReadLine(), out width))
					{
						Console.WriteLine(" ERROR - Invalid, (Numbers Only)"); // Appears when user enters a character which isn't a number
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

						//HEIGHT
						else
						{
							Console.WriteLine("\nEnter Height of Cuboid:"); // Asks user Cuboid Height Input

							//Vallidation for Cuboid Height
							if (!double.TryParse(Console.ReadLine(), out height))
							{
								Console.WriteLine(" ERROR - Invalid, (Numbers Only)"); // Appears when user enters a character which isn't a number
								getInput();
							}
							else
							{
								if (height >= 100000000)
								{
									Console.WriteLine(" ERROR - Invalid, (Number To Large)"); // Appears when user enters the number 100000000 or greater
									getInput();
								}
								else if (height <= 0)
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
					}
				}
			}
		}

		//Calculations
		//Perimeter Calculation
		public override void calcVolume()
		{
			volume = length * width * height;
			calcSurfaceArea();
		}

		//Surface Area Calculation
		public override void calcSurfaceArea()
		{
			surfacearea = (length * height + length * width + height * width) * 2;
			outputVolume();
		}

		//Volume Output
		public override void outputVolume()
		{
			Console.WriteLine("\n Results");
			Console.WriteLine(" -------------------------------------");
			Console.WriteLine($" Cuboid Volume: " + volume);
			outputSurfaceArea();
		}

		//Surface Area Output
		public override void outputSurfaceArea()
		{
			Console.WriteLine($" Cuboid Surface Area: " + surfacearea);
			Console.WriteLine(" -------------------------------------");
			txtSave();
		}

		//Textfile Save
		public override void txtSave()
		{
			TextEditor text = new TextEditor();
			ProxyTextEditor proxytext = new ProxyTextEditor(text);
			TextManager textmanager = new TextManager(proxytext);

			textmanager.option(1, volume, surfacearea, length, width, height, "Cuboid");
		}
	}
}