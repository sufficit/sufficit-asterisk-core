using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Collections.Specialized;
using System;

namespace Sufficit.Asterisk.Manager.Events.Abstracts
{	
	public abstract class AbstractAgentVariables : ManagerEvent
	{
		private NameValueCollection variables;

		public string Channel { get; set; } 

		public string Server { get; set; }

		public double Timestamp { get; set; }

		public string UniqueId { get; set; }

		#region Variable

		/// <summary>
		/// Get/Set the variables to set on the queue call in native asterisk format.<br/>
		/// Example: "VAR1=abc|VAR2=def".
		/// </summary>
		[Obsolete("Use GetVariables and SetVariables instead.", true)]
		public string? Variable
		{
			get { return null; /* return Helper.JoinVariables(variables, Common.GET_VAR_DELIMITER(this.Server), "="); */ }
			set { /* variables = Helper.ParseVariables(variables, value, Common.GET_VAR_DELIMITER(this.Server)); */ }
		}
		#endregion

		#region GetVariables()
		/// <summary>
		/// Get the variables dictionary to set on the originated call.
		/// </summary>
		public NameValueCollection GetVariables()
		{
			return variables;
		}
		#endregion

		#region SetVariables(Dictionary<string, string> vars)
		/// <summary>
		/// Set the variables dictionary to set on the originated call.
		/// </summary>
		public void SetVariables(NameValueCollection vars)
		{
			this.variables = vars;
		}
		#endregion

		#region SetVariable(string name, string val)
		/// <summary>
		/// Sets a variable dictionary on the originated call. Replaces any existing variable with the same name.
		/// </summary>
		public void SetVariable(string key, string val)
		{
			variables ??= new NameValueCollection();			
			variables.Set(key, val);
		}

		#endregion

		#region GetVariable(string name)
		/// <summary>
		/// Gets a variable on the originated call. Replaces any existing variable with the same name.
		/// </summary>
		public string GetVariable(string key)
		{
			if (variables == null)
				return string.Empty;
			return variables[key];
		}
		#endregion
	}
}
