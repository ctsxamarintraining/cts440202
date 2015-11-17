using System;

namespace TripExpenceManager
{
	public class Trip
	{
		public string Name{ get; set;}
		public string Description { get; set;}
		public double budget;
		public DateTime FromDate{ get; set;}
		public DateTime ToDate{ get; set;}

		public Trip ()
		{
		}

	}
}

