using Course.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Model
{
	public class CourseClass :Bindable
	{
		private string coursename; 
		public string CourseName { get =>coursename; set=>Set(ref coursename, value); }

		private string credits;
		public string Credits { get => credits; set => Set(ref credits, value); }

		private string lecturer;
		public string Lecturer { get => lecturer; set => Set(ref lecturer, value); }
	}
}
