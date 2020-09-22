using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace APShapeCalc
{
	class TextEditor : IText
	{
		public void txtSave(double attribute1, double attribute2, double input1, double input2, double input3, string shape)
		{
			try
			{
				//Text File Location
				StreamWriter sw = new StreamWriter("C:\\Users\\karpz\\Desktop\\APShapeCalc\\Calculations.txt", true, Encoding.ASCII);

				//CALCULATIONS DONE PREVIOUSLLY OPTION OUTPUTS
				//SQUARE
				if (shape == "Square")
				{
					sw.WriteLine("\n Square");
					sw.WriteLine(" -------------------------------------");
					sw.WriteLine($" Length Input: " + input1);
					sw.WriteLine(" -------------------------------------");
					sw.WriteLine($" Square Area: " + attribute1);
					sw.WriteLine($" Square Perimiter: " + attribute2);
					sw.WriteLine(" -------------------------------------\n");


				}
				//RECTANGLE
				else if (shape == "Rectangle")
				{
					sw.WriteLine("\n Rectangle");
					sw.WriteLine(" -------------------------------------");
					sw.WriteLine($" Length Input: " + input1);
					sw.WriteLine($" Width Input: " + input2);
					sw.WriteLine(" -------------------------------------");
					sw.WriteLine($" Rectangle Area: " + attribute1);
					sw.WriteLine($" Rectangle Perimiter: " + attribute2);
					sw.WriteLine(" -------------------------------------\n");

				}
				//EQUILATERAL TRIANGLE
				else if (shape == "Equilateral Triangle")
				{
					sw.WriteLine("\n Equilateral Triangle");
					sw.WriteLine(" -------------------------------------");
					sw.WriteLine($" Length Input: " + input1);
					sw.WriteLine(" -------------------------------------");
					sw.WriteLine($" Equilateral Triangle Area: " + attribute1);
					sw.WriteLine($" Equilateral Triangle Perimeter: " + attribute2);
					sw.WriteLine(" -------------------------------------\n");

				}
				//CIRCLE
				else if (shape == "Circle")
				{
					sw.WriteLine("\n Circle");
					sw.WriteLine(" -------------------------------------");
					sw.WriteLine($" Radius Input: " + input1);
					sw.WriteLine(" -------------------------------------");
					sw.WriteLine($" Circle Area: " + attribute1);
					sw.WriteLine($" Circle Circumference: " + attribute2);
					sw.WriteLine(" -------------------------------------\n");

				}
				//CUBE
				else if (shape == "Cube")
				{
					sw.WriteLine("\n Cube");
					sw.WriteLine(" -------------------------------------");
					sw.WriteLine($" Length Input: " + input1);
					sw.WriteLine(" -------------------------------------");
					sw.WriteLine($" Cube Volume: " + attribute1);
					sw.WriteLine($" Cube Surface Area: " + attribute2);
					sw.WriteLine(" -------------------------------------\n");

				}
				//CUBOID
				else if (shape == "Cuboid")
				{
					sw.WriteLine("\n Cuboid");
					sw.WriteLine(" -------------------------------------");
					sw.WriteLine($" Length Input: " + input1);
					sw.WriteLine($" Width Input: " + input2);
					sw.WriteLine($" Height Input: " + input3);
					sw.WriteLine(" -------------------------------------");
					sw.WriteLine($" Cuboid Volume: " + attribute1);
					sw.WriteLine($" Cuboid Surface Area: " + attribute2);
					sw.WriteLine(" -------------------------------------\n");

				}
				//SPHERE
				else if (shape == "Sphere")
				{
					sw.WriteLine("\n Sphere");
					sw.WriteLine(" -------------------------------------");
					sw.WriteLine($" Radius Input: " + input1);
					sw.WriteLine(" -------------------------------------");
					sw.WriteLine($" Sphere Volume: " + attribute1);
					sw.WriteLine($" Sphere Surface Area: " + attribute2);
					sw.WriteLine(" -------------------------------------\n");
					sw.WriteLine(" SCROLL UP TO VIEW PREVIOUS CALCULATIONS");
				}
				//RIGHT CYLINDER
				else if (shape == "Right Cylinder")
				{
					sw.WriteLine("\n Right Cylinder");
					sw.WriteLine(" -------------------------------------");
					sw.WriteLine($" Height Input: " + input1);
					sw.WriteLine($" Radius Input: " + input2);
					sw.WriteLine(" -------------------------------------");
					sw.WriteLine($" Right Cylinder Volume: " + attribute1);
					sw.WriteLine($" Right Cylinder Surface Area: " + attribute2);
					sw.WriteLine(" -------------------------------------\n");
					

				}
				//ERROR IF NO CALCULATION
				else
				{
					Console.WriteLine("ERROR");
				}

				sw.Close();
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception: " + e.Message);
				throw;
			}
			finally
			{
				Console.WriteLine("");
			}

			MainMenu menu = MainMenu.GetInstance();

			menu.Options();
		}

		//SEND CALCULATIONS TO TXT FILE
		public void outputTextFile()
		{
			String line;

			try
			{
				StreamReader sr = new StreamReader("C:\\Users\\karpz\\Desktop\\APShapeCalc\\Calculations.txt"); // Text File Location

				line = sr.ReadLine();

				while (line != null)
				{
					Console.WriteLine(line);
					line = sr.ReadLine();
				}
				sr.Close();
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception: " + e.Message);
			}
			finally
			{
				Console.WriteLine("");
			}

			MainMenu menu = MainMenu.GetInstance();
			menu.Options();
			
		}
	}
}
