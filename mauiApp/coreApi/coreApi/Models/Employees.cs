using System;
using System.ComponentModel;

namespace coreApi.Models
{
	public class Employees:INotifyPropertyChanged
	{
		public int _id;
		public string _firstName;
		public string _lastName;
		public string _position;


		public int Id {
			get => _id;
			set
			{
				if (_id == value) return;
				_id = value;
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Id)));
			}

		}


        public string FirstName
        {
            get => _firstName;
            set
            {
                if (_firstName == value) return;
                _firstName = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(FirstName)));
            }

        }

        public string LastName
        {
            get => _lastName;
            set
            {
                if (_lastName == value) return;
                _lastName = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(LastName)));
            }

        }

        public string Position
        {
            get => _position;
            set
            {
                if (_position == value) return;
                _position = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Position)));
            }

        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}

