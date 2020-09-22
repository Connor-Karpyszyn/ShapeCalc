using System;
using System.Collections.Generic;
using System.Text;

namespace APShapeCalc
{
	interface IText
	{
		//Text File Interface
		public void txtSave(double attribute1, double attribute2, double input1, double input2, double input3, string shape); 
		public void outputTextFile();
	}
}
