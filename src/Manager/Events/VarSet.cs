using Sufficit.Asterisk.Manager.Events.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sufficit.Asterisk.Manager.Events
{
	public class VarSetEvent : ManagerEvent
	{
		private string variable_name;
		private string variable_value;
		private string file;
		private string func;
		private int line;
		private int sequencenumber;

		public string File
		{
			get { return file; }
			set { file = value; }
		}
		public string Func
		{
			get { return func; }
			set { func = value; }
		}
		public int Line
		{
			get { return line; }
			set { line = value; }
		}
		public int SequenceNumber
		{
			get { return sequencenumber; }
			set { sequencenumber = value; }
		}

		/// <summary>
		/// Get/Set the name of variable.
		/// </summary>
		public string Variable
		{
			get { return variable_name; }
			set { variable_name = value; }
		}

		/// <summary>
		/// Get/Set value of variable.
		/// </summary>
		public string Value
		{
			get { return variable_value; }
			set { variable_value = value; }
		}
	}
}
