using System;
using System.ComponentModel;

namespace Assignment
{
	public class BaseViewModel : INotifyPropertyChanged
	{
		#region INotifyPropertyChanged implementation

		public event PropertyChangedEventHandler PropertyChanged;

		#endregion

		protected void RaisePropertyChanged(string propertyName)
		{
			if (PropertyChanged != null) 
			{
				PropertyChanged.Invoke (this, new PropertyChangedEventArgs (propertyName));
			}
		}

		public BaseViewModel ()
		{
		}
	}
}

