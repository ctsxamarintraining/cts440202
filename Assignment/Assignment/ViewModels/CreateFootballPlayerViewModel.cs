using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace Assignment
{
	public class CreateFootballPlayerViewModel : BaseViewModel
	{
		public CreateFootballPlayerViewModel ()
		{			
			SavePlayerProfileBTNClicked = new Command (OnSavePlayerProfileBTNClicked);
			UploadImageFromProfilePictureClicked = new Command (OnUploadImageFromProfilePictureClicked);
		}

		public string[] Countries = new string[] {"Argentina","Brazil","Germany","India","Spain"};

		private string _firstName;
		public string FirstName
		{
			get{  return _firstName;}
			set{   
				_firstName = value;
				RaisePropertyChanged ("FirstName");
			}
		}

		private string _lastName;
		public string LastName
		{
			get{ return _lastName; }
			set
			{
				_lastName = value;
				RaisePropertyChanged("LastName");
			}
		}

		private DateTime _dateOfBirth;
		public DateTime DateOfBirth
		{
			get{ return _dateOfBirth; }
			set
			{
				_dateOfBirth = value;
				RaisePropertyChanged ("DateOfBirth");
			}
		}

		private int _country;
		public int Country
		{
			get { return _country; }
			set
			{ 
				_country = value;
				RaisePropertyChanged ("Country");
			}
		}

		public string _playerdescription;
		public string Description
		{
			get { return _playerdescription; }
			set
			{
				_playerdescription = value;
				RaisePropertyChanged ("Description");
			}
		}

		public ICommand SavePlayerProfileBTNClicked{ get; private set;}

		void OnSavePlayerProfileBTNClicked()
		{
			//Write for Image Picker
			string saveDataStatus = "";
			if (_firstName == null || _lastName == null) 
			{
				saveDataStatus = "Please Enter First Name and Last Name";
			} 
			else if (_country < 0) 
			{
				saveDataStatus = "Please Enter Country";
			} 
			else if (_playerdescription == null) 
			{
				saveDataStatus = "Please Enter Description";
			} 
			else 
			{
				FootballPlayer player = new FootballPlayer {
					FirstName = _firstName,
					LastName = _lastName,
					DateOfBirth = _dateOfBirth,
					Country = Countries[_country],
					Description = _playerdescription
				};

				SQLiteHelper databaseHelper = new SQLiteHelper ();
				databaseHelper.Save (player);
				saveDataStatus = "Player Data Saved Successfully";
			}
			MessagingCenter.Send (this, "SaveFootballPlayerProfileStatusAlert",saveDataStatus);
		}

		public ICommand UploadImageFromProfilePictureClicked {get; private set;}
		void OnUploadImageFromProfilePictureClicked()
		{
			var ImagePicker = DependencyService.Get<IUploadImage> ();
			if (ImagePicker != null) 
			{
				ImagePicker.GetImagePath ();
			}
		}
	}
}



