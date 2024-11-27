namespace Course
{
	partial class MainForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			dgvCourse = new DataGridView();
			btnAdd = new Button();
			btnEdit = new Button();
			btnDelete = new Button();
			btnLoad = new Button();
			btnSave = new Button();
			((System.ComponentModel.ISupportInitialize)dgvCourse).BeginInit();
			SuspendLayout();
			// 
			// dgvCourse
			// 
			dgvCourse.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvCourse.Location = new Point(113, 56);
			dgvCourse.Name = "dgvCourse";
			dgvCourse.RowHeadersWidth = 51;
			dgvCourse.Size = new Size(561, 315);
			dgvCourse.TabIndex = 0;
			// 
			// btnAdd
			// 
			btnAdd.Location = new Point(151, 394);
			btnAdd.Name = "btnAdd";
			btnAdd.Size = new Size(148, 30);
			btnAdd.TabIndex = 1;
			btnAdd.Text = "Add Course";
			btnAdd.UseVisualStyleBackColor = true;
			btnAdd.Click += btnAdd_Click;
			// 
			// btnEdit
			// 
			btnEdit.Location = new Point(335, 394);
			btnEdit.Name = "btnEdit";
			btnEdit.Size = new Size(148, 30);
			btnEdit.TabIndex = 2;
			btnEdit.Text = "Edit Course";
			btnEdit.UseVisualStyleBackColor = true;
			btnEdit.Click += btnEdit_Click;
			// 
			// btnDelete
			// 
			btnDelete.Location = new Point(516, 394);
			btnDelete.Name = "btnDelete";
			btnDelete.Size = new Size(148, 30);
			btnDelete.TabIndex = 3;
			btnDelete.Text = "Delete Course";
			btnDelete.UseVisualStyleBackColor = true;
			btnDelete.Click += button3_Click;
			// 
			// btnLoad
			// 
			btnLoad.Location = new Point(142, 12);
			btnLoad.Name = "btnLoad";
			btnLoad.Size = new Size(148, 30);
			btnLoad.TabIndex = 4;
			btnLoad.Text = "Load";
			btnLoad.UseVisualStyleBackColor = true;
			// 
			// btnSave
			// 
			btnSave.Location = new Point(335, 12);
			btnSave.Name = "btnSave";
			btnSave.Size = new Size(148, 30);
			btnSave.TabIndex = 5;
			btnSave.Text = "Save";
			btnSave.UseVisualStyleBackColor = true;
			btnSave.Click += btnSave_Click;
			// 
			// MainForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(btnSave);
			Controls.Add(btnLoad);
			Controls.Add(btnDelete);
			Controls.Add(btnEdit);
			Controls.Add(btnAdd);
			Controls.Add(dgvCourse);
			Name = "MainForm";
			Text = "MainForm";
			Load += MainForm_Load;
			((System.ComponentModel.ISupportInitialize)dgvCourse).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private DataGridView dgvCourse;
		private Button btnAdd;
		private Button btnEdit;
		private Button btnDelete;
		private Button btnLoad;
		private Button btnSave;
	}
}
