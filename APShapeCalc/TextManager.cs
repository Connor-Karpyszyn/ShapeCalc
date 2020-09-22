using System;
using System.Collections.Generic;
using System.Text;

namespace APShapeCalc
{
	class TextManager
	{
		protected IText editor;
		public TextManager(IText editor)

		{
			this.editor = editor;
		}

		//SAVE CALCULATIONS
		void txtSave(double attribute1, double attribute2, double input1, double input2, double input3, string shape)
		{
			editor.txtSave(attribute1, attribute2, input1, input2, input3, shape);
		}

		//TXT FILE OUTPUT
		void outputText()
		{
			editor.outputTextFile();
		}

		//OPTIONS
		public void option(int option, double attribute1, double attribute2, double input1, double input2, double input3, string shape)
		{

			if (option == 1)
			{
				txtSave(attribute1, attribute2, input1, input2, input3, shape);
			}
			else if (option == 2)
			{
				outputText();
			}
			else
			{
				Console.WriteLine("ERROR");
			}
		}
	}
}
