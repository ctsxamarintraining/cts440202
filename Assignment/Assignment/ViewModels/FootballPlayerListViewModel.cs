using System;
using System.Windows.Input;
using Xamarin.Forms;
using SQLite;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Assignment
{
	public class FootballPlayerListViewModel : BaseViewModel
	{

		public FootballPlayerListViewModel ()
		{
			AddPlayerBTNTapped = new Command (OnAddPlayerBTNTapped);
			SQLiteHelper databaseHelper = new SQLiteHelper ();
			FootballPlayerCollection = new ObservableCollection<FootballPlayer> (databaseHelper.GetItems ());
		}

		public ObservableCollection<FootballPlayer> _footballPlayerCollection{ get; set;}
		public ObservableCollection<FootballPlayer> FootballPlayerCollection
		{
			get{ 
				return  _footballPlayerCollection;
			}
			set{
				_footballPlayerCollection = value;
				RaisePropertyChanged ("FootballPlayerCollection");

			}
		}



		public ICommand AddPlayerBTNTapped{ get; private set;}

		void OnAddPlayerBTNTapped()
		{
			MessagingCenter.Send (this, "AddFootballPlayer");
		}


	}
}

