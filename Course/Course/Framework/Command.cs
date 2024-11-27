using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Course.Framework
{
	public class Command(Action<object?> action, Predicate<object>? canExecute = null) : ICommand
	{
		public event EventHandler? CanExecuteChanged;

		public bool CanExecute(object? parameter = null)
		=> canExecute is null || canExecute.Invoke(parameter);

		public void Execute(object? parameter = null) => action?.Invoke(parameter);
		public void Notify()=> CanExecuteChanged.Invoke(this, EventArgs.Empty);
	}
}
