namespace Course.View
{
	partial class CourseDetail
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			btnOK = new Button();
			btnCancel = new Button();
			lbName = new Label();
			tbCourseName = new TextBox();
			tbLecturer = new TextBox();
			lbLecturer = new Label();
			tbCredits = new TextBox();
			lbCredits = new Label();
			SuspendLayout();
			// 
			// btnOK
			// 
			btnOK.Location = new Point(391, 294);
			btnOK.Name = "btnOK";
			btnOK.Size = new Size(148, 30);
			btnOK.TabIndex = 2;
			btnOK.Text = "OK";
			btnOK.UseVisualStyleBackColor = true;
			btnOK.Click += btnOK_Click;
			// 
			// btnCancel
			// 
			btnCancel.Location = new Point(205, 294);
			btnCancel.Name = "btnCancel";
			btnCancel.Size = new Size(148, 30);
			btnCancel.TabIndex = 3;
			btnCancel.Text = "Cancel";
			btnCancel.UseVisualStyleBackColor = true;
			btnCancel.Click += btnCancel_Click;
			// 
			// lbName
			// 
			lbName.AutoSize = true;
			lbName.Location = new Point(124, 27);
			lbName.Name = "lbName";
			lbName.Size = new Size(98, 20);
			lbName.TabIndex = 4;
			lbName.Text = "Course Name";
			// 
			// tbCourseName
			// 
			tbCourseName.Location = new Point(299, 30);
			tbCourseName.Name = "tbCourseName";
			tbCourseName.Size = new Size(125, 27);
			tbCourseName.TabIndex = 5;
			// 
			// tbLecturer
			// 
			tbLecturer.Location = new Point(299, 188);
			tbLecturer.Name = "tbLecturer";
			tbLecturer.Size = new Size(125, 27);
			tbLecturer.TabIndex = 7;
			// 
			// lbLecturer
			// 
			lbLecturer.AutoSize = true;
			lbLecturer.Location = new Point(124, 195);
			lbLecturer.Name = "lbLecturer";
			lbLecturer.Size = new Size(111, 20);
			lbLecturer.TabIndex = 6;
			lbLecturer.Text = "Course Lecturer";
			// 
			// tbCredits
			// 
			tbCredits.Location = new Point(299, 106);
			tbCredits.Name = "tbCredits";
			tbCredits.Size = new Size(125, 27);
			tbCredits.TabIndex = 9;
			// 
			// lbCredits
			// 
			lbCredits.AutoSize = true;
			lbCredits.Location = new Point(124, 103);
			lbCredits.Name = "lbCredits";
			lbCredits.Size = new Size(104, 20);
			lbCredits.TabIndex = 8;
			lbCredits.Text = "Course Credits";
			// 
			// CourseDetail
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(tbCredits);
			Controls.Add(lbCredits);
			Controls.Add(tbLecturer);
			Controls.Add(lbLecturer);
			Controls.Add(tbCourseName);
			Controls.Add(lbName);
			Controls.Add(btnCancel);
			Controls.Add(btnOK);
			Name = "CourseDetail";
			Text = "CourseDetail";
			Load += CourseDetail_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnOK;
		private Button btnCancel;
		private Label lbName;
		private TextBox tbCourseName;
		private TextBox tbLecturer;
		private Label lbLecturer;
		private TextBox tbCredits;
		private Label lbCredits;
	}
}