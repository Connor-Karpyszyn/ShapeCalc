using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection.Emit;
using System.Text;

namespace APShapeCalc
{
	class MainMenu
	{
		private static MainMenu instance;
		private int option = 0;

		private MainMenu()
		{

		}

		public void Options()
		{
			//2D Shapes
			_2DShapes square = new Square();
			_2DShapes rectangle = new Rectangle();
			_2DShapes triangle = new EquilateralTriangle();
			_2DShapes circle = new Circle();

			//3D Shapes
			_3DShapes cube = new Cube();
			_3DShapes cuboid = new Cuboid();
			_3DShapes cylinder = new RightCylinder();
			_3DShapes sphere = new Sphere();

			//Text Editor
			TextEditor text = new TextEditor();
			ProxyTextEditor proxytext = new ProxyTextEditor(text);
			TextManager textmanager = new TextManager(proxytext);

			//Main Menu Text
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine("\n | SHAPE CALCULATOR|");
			Console.WriteLine("           OPTIONS");
			Console.WriteLine(" \n 2D SHAPES");
			Console.WriteLine(" ___________________________________________________");
			Console.WriteLine(" 1 | Square - Area and Perimeter");
			Console.WriteLine(" 2 | Rectangle - Area & Perimeter");
			Console.WriteLine(" 3 | Equilateral Triangle - Area & Perimeter");
			Console.WriteLine(" 4 | Circle - Area & Circumference");
			Console.WriteLine(" \n 3D SHAPES");
			Console.WriteLine(" ___________________________________________________");
			Console.WriteLine(" 5 | Cube - Volume & Surface Area");
			Console.WriteLine(" 6 | Cuboid - Volume & Surface Area");
			Console.WriteLine(" 7 | Right Cylinder - Volume & Surface Area");
			Console.WriteLine(" 8 | Sphere - Volume & Surface Area");
			Console.WriteLine(" 9 | CALCULATIONS DONE PREVIOUSLY");
			Console.WriteLine(" \n 10| Quit.");
			Console.WriteLine(" \n Choice");
			Console.WriteLine("----------");


			//Vallidation
			if (!int.TryParse(Console.ReadLine(), out option))
			{
				Console.Clear();
				Console.WriteLine("ERROR - Invalid, (Numbers Only)");
				Options();
			}
			else
			{
				if (option >= 11)
				{
					Console.Clear();
					Console.WriteLine("ERROR - Invalid, (Option 1-10 only!)");
					Options();
				}
				else if (option <= 0)
				{
					Console.Clear();
					Console.WriteLine("ERROR - Invalid, (Option 1-10 only!)");
					Options();
				}

				//Menu Options
				else
				{
					switch (option)
					{
						case 1:
							Console.Clear();
							square.getInput();
							break;
						case 2:
							Console.Clear();
							rectangle.getInput();
							break;
						case 3:
							Console.Clear();
							triangle.getInput();
							break;
						case 4:
							Console.Clear();
							circle.getInput();
							break;
						case 5:
							Console.Clear();
							cube.getInput();
							break;
						case 6:
							Console.Clear();
							cuboid.getInput();
							break;
						case 7:
							Console.Clear();
							cylinder.getInput();
							break;
						case 8:
							Console.Clear();
							sphere.getInput();
							break;
						case 9:
							Console.Clear();
							textmanager.option(2, 0.0, 0.0, 0.0, 0.0, 0.0, "h");
							break;
						case 10:

							break;
						default:
							Console.WriteLine("ERROR - Invalid, (Option 1-10 only!)");

							Options();
							break;
					}
				}

			}

		}
		public static MainMenu GetInstance()
		{
			if (instance == null) 
			{
				instance = new MainMenu();
			}
			else 
			{

			}
			return instance;
		}
	}
}
