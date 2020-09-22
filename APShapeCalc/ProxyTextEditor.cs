using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace APShapeCalc
{
	class ProxyTextEditor : IText
	{
		private TextEditor proxyedit;

		public ProxyTextEditor(TextEditor editor)
		{
			this.proxyedit = editor;
		}

		//Save Calculations
		public void txtSave(double attribute1, double attribute2, double input1, double input2, double input3, string shape)
		{
			proxyedit.txtSave(attribute1, attribute2, input1, input2, input3, shape);
		}
		
		//Output To Txt File - Calculations
		public void outputTextFile()
		{
			proxyedit.outputTextFile();
		}
	}
}
