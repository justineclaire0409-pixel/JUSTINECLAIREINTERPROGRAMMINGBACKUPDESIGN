namespace WinFormsApp15
{
    partial class Dashboard
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
            btnregister_student = new Button();
            btnstudent_list = new Button();
            SuspendLayout();
            // 
            // btnregister_student
            // 
            btnregister_student.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnregister_student.Location = new Point(65, 178);
            btnregister_student.Name = "btnregister_student";
            btnregister_student.Size = new Size(260, 64);
            btnregister_student.TabIndex = 0;
            btnregister_student.Text = "REGISTER STUDENT";
            btnregister_student.UseVisualStyleBackColor = true;
            btnregister_student.Click += button1_Click;
            // 
            // btnstudent_list
            // 
            btnstudent_list.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnstudent_list.Location = new Point(361, 178);
            btnstudent_list.Name = "btnstudent_list";
            btnstudent_list.Size = new Size(260, 64);
            btnstudent_list.TabIndex = 1;
            btnstudent_list.Text = "STUDENT LIST";
            btnstudent_list.UseVisualStyleBackColor = true;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(705, 450);
            Controls.Add(btnstudent_list);
            Controls.Add(btnregister_student);
            Name = "Dashboard";
            Text = "Dashboard";
            ResumeLayout(false);
        }

        #endregion

        private Button btnregister_student;
        private Button btnstudent_list;
    }
}