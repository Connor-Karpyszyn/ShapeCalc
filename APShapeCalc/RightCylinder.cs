using System;
using System.Collections.Generic;
using System.Text;

namespace APShapeCalc
{
    class RightCylinder : _3DShapes, I3DShapes
    {
        private double height = 0.0;
        private double radius = 0.0;
        private double pi = 3.14;
        public override void getInput()
        {

            //User Input
            Console.WriteLine("\nEnter Height of Right Cylinder."); // Asks user Right Cylinder Height Input

            //Validation for Right Cylinder Height
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

                //RADIUS
                else
                {
                    Console.WriteLine("\nEnter Radius of Right Cylinder"); // Asks user Right Cylinder Radius Input

                    //Validation for Right Cylinder Radius
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
                            calcVolume(); // If the user enters a valid input the the volume will be calculated
                        }
                    }
                }
            }
        }

        //Calculations
        //Volume Calculation
        public override void calcVolume()
        {
            volume = pi * radius * radius * height;
            calcSurfaceArea();
        }

        //Surface Area Calculation
        public override void calcSurfaceArea()
        {
            surfacearea = (2 * pi * radius * height) + (2 * pi * radius * radius);
            outputVolume();
        }

        //Volume Output
        public override void outputVolume()
        {
            Console.WriteLine("\n Results");
            Console.WriteLine(" -------------------------------------");
            Console.WriteLine($" Right Cylinder Volume: " + volume);
            outputSurfaceArea();
        }

        //Surface Area Output
        public override void outputSurfaceArea()
        {
            Console.WriteLine($" Right Cylinder Surface Area: " + surfacearea);
            Console.WriteLine(" -------------------------------------");
            txtSave();
        }

        //Textfile Save
        public override void txtSave()
        {
            TextEditor text = new TextEditor();
            ProxyTextEditor proxytext = new ProxyTextEditor(text);
            TextManager textmanager = new TextManager(proxytext);

            textmanager.option(1, volume, surfacearea, height, radius, 0.0, "Right Cylinder");
        }
    }
}