using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Course.Framework
{
	public class Bindable : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler? PropertyChanged;
		protected void Notify(string property)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));

		}
		protected void Set<T>(ref T field, T value, [CallerMemberName] string property = "")
		{
			field = value;
			Notify(property);
		}


	}
}
