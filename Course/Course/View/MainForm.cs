using Course.Model;
using Course.View;
using Course.ViewModel;
using System.Data.Common;
using static Course.ViewModel.CourseViewModel;

namespace Course
{
	public partial class MainForm : Form
	{
		private readonly ICourseViewModel _viewModel;
		//private readonly IServiceProvider _serviceProvider;
		readonly BindingSource _bindingSource;
		public MainForm(ICourseViewModel viewModel)
		{
			InitializeComponent();
			_viewModel = viewModel;
			//_serviceProvider = serviceProvider;
			_bindingSource = new BindingSource();
			
			dgvCourse.DataSource = viewModel.Courses;
			_bindingSource.DataSource = viewModel.Courses;
		}



		private void button3_Click(object sender, EventArgs e)
		{

		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
            

		}

		private void btnEdit_Click(object sender, EventArgs e)
		{


		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			dgvCourse.SelectionChanged += delegate
			{
				_viewModel.Current = dgvCourse.CurrentRow?.DataBoundItem as CourseClass;
				
			};
			btnAdd.Command = _viewModel.CommandAdd;
			btnSave.Command = _viewModel.CommandSave;
			btnEdit.Command = _viewModel.CommandEdit;
			btnDelete.Command = _viewModel.CommandDelete;
			
		}

		private void btnSave_Click(object sender, EventArgs e)
		{

		}
	}
}
