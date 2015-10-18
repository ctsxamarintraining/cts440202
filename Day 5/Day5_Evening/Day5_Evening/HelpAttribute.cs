using System;

namespace Day5_Evening
{
	[AttributeUsage(AttributeTargets.Class)]
	
	public class HelpAttribute : Attribute
	{
		protected String description;
		public String Description 
		{
			get 
			{
				return this.description;

			}            
		}
		public HelpAttribute(String Description_in)
		{
			this.description = Description_in;
		}

	}

	[Help("this is a do-nothing class")]
	public class AnyClass
	{
	}
}

