using System;
using System.ComponentModel;

namespace coreApi.Models
{
	public class ToDo:INotifyPropertyChanged
	{
		public ToDo()
		{
		}

		int _id;
		string _todoname;


		public int Id {
			get => _id;
			
			set
			{
				if (_id == value) return;
				_id = value;
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Id)));

			}
		}

		public string ToDoName
		{
			get => _todoname;
			set
			{
				if (_todoname == value) return;
				_todoname = value;
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ToDoName)));
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;
    }
}

