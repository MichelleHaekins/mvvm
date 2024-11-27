using Course.Model;
using Course.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Course.ViewModel.CourseViewModel;

namespace Course.View
{
	public partial class CourseDetail : Form
	{
		private CourseViewModel _viewModel;
		public CourseClass CourseClass { get; set; }
		public CourseDetail(ICourseViewModel viewModel, CourseClass course)
		{
			InitializeComponent();
			viewModel = _viewModel;
			CourseClass = course;
			tbCourseName.DataBindings.Add("Text", CourseClass, "CourseName");
			tbCredits.DataBindings.Add("Text",CourseClass, "Credits");
			tbLecturer.DataBindings.Add("Text", CourseClass, "Lecturer");
			 
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void CourseDetail_Load(object sender, EventArgs e)
		{

		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			if (CourseClass == null)
			{
				CourseClass = new CourseClass();
			}
			CourseClass.CourseName = tbCourseName.Text;
			CourseClass.Credits = tbCredits.Text;
			CourseClass.Lecturer = tbLecturer.Text;	
			DialogResult = DialogResult.OK;
		}
	}
}
