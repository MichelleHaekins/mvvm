using Course.Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static Course.ViewModel.CourseViewModel;
using Course.Model;
using System.Text.Json;
using Course.View;

namespace Course.ViewModel
{
	public class CourseViewModel : Bindable, ICourseViewModel
	{
		readonly string file = "data.json";
		public CourseViewModel() {
			Load();
			CommandSave = new(async o =>
			{
				await Save();

			});
			CommandDelete = new(o =>
			{
				if (Current != null)
				{
					_courses.Remove(Current);
				}
			}, o => Current != null);
			CommandAdd = new(o =>
			{
				var newCourse = new CourseClass();
				var detailForm = new CourseDetail(this, newCourse);

				if (detailForm.ShowDialog() == DialogResult.OK)
				{
					Courses.Add(newCourse);
					MessageBox.Show("Course added successfully.", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			});
			CommandSort = new(o => SortCourses());
			CommandEdit = new(o =>
			{
				if (Current != null)
				{
					var detailForm = new CourseDetail(this, Current);

					if (detailForm.ShowDialog() == DialogResult.OK)
					{
						MessageBox.Show("Course updated successfully.", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
				}
			}, o => Current != null);

		}
		private BindingList<CourseClass> _courses;
		public BindingList<CourseClass> Courses
		{
			get => _courses;
			set => Set(ref _courses, value);
		}
		private CourseClass? _current;
		public CourseClass? Current
		{
			get => _current; set
			{
				Set(ref _current, value);
				CommandDelete.Notify();
				CommandEdit.Notify();

			}
		}
		public void SortCourses()
		{
			var sortedCourses = Courses
				.OrderBy(c => c.Credits)
				.ThenBy(c => c.CourseName)
				.ToList();

			Courses.Clear();
			foreach (var course in sortedCourses)
			{
				Courses.Add(course);
			}
		}
		public Command CommandSort {  get; set; }
		public Command CommandSave { get; set; }
		public Command CommandAdd { get; set; }
		public Command CommandEdit { get; set; }
		public Command CommandDelete { get; set; }
		public interface ICourseViewModel
		{
			BindingList<CourseClass> Courses { get; }
			CourseClass Current { get; set; }

			Command CommandSave { get; }
			Command CommandDelete { get; }
			Command CommandAdd { get; }
			Command CommandEdit { get; }
			Task<IEnumerable<CourseClass>> Load();
			Task Save();
		}
		public async Task<IEnumerable<CourseClass>> Load()
		{
			if (!File.Exists(file))
			{
				await Save();
			}
			else
			{
				var fs = await File.ReadAllBytesAsync(file);
				_courses = JsonSerializer.Deserialize<BindingList<CourseClass>>(fs) ?? new BindingList<CourseClass>();

			}
			SortCourses();
			return _courses;	
		}
		public async Task Save()
		{
			var json = JsonSerializer.Serialize(_courses);
			await File.WriteAllTextAsync(file, json);
		}



	} }
