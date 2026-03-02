namespace WinFormsApp15
{
    partial class RegisterStudent
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
            lblfirstname = new Label();
            lbl1 = new Label();
            lblsection = new Label();
            lblcourse = new Label();
            lbllastname = new Label();
            lblage = new Label();
            txtLast_Name = new TextBox();
            txt_Age = new TextBox();
            btnsaverecord = new Button();
            txtFirst_Name = new TextBox();
            cbregisterstudentcourse = new ComboBox();
            cbregisterstudentsection = new ComboBox();
            SuspendLayout();
            // 
            // lblfirstname
            // 
            lblfirstname.AutoSize = true;
            lblfirstname.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblfirstname.Location = new Point(12, 136);
            lblfirstname.Name = "lblfirstname";
            lblfirstname.Size = new Size(117, 24);
            lblfirstname.TabIndex = 1;
            lblfirstname.Text = "First Name:";
            lblfirstname.Click += lblusername_Click;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl1.Location = new Point(65, 66);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(373, 24);
            lbl1.TabIndex = 2;
            lbl1.Text = "REGISTER STUDENT INFORMATION";
            // 
            // lblsection
            // 
            lblsection.AutoSize = true;
            lblsection.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblsection.Location = new Point(47, 305);
            lblsection.Name = "lblsection";
            lblsection.Size = new Size(83, 24);
            lblsection.TabIndex = 3;
            lblsection.Text = "Section:";
            // 
            // lblcourse
            // 
            lblcourse.AutoSize = true;
            lblcourse.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblcourse.Location = new Point(47, 248);
            lblcourse.Name = "lblcourse";
            lblcourse.Size = new Size(80, 24);
            lblcourse.TabIndex = 4;
            lblcourse.Text = "Course:";
            // 
            // lbllastname
            // 
            lbllastname.AutoSize = true;
            lbllastname.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbllastname.Location = new Point(12, 192);
            lbllastname.Name = "lbllastname";
            lbllastname.Size = new Size(115, 24);
            lbllastname.TabIndex = 5;
            lbllastname.Text = "Last Name:";
            // 
            // lblage
            // 
            lblage.AutoSize = true;
            lblage.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblage.Location = new Point(74, 365);
            lblage.Name = "lblage";
            lblage.Size = new Size(53, 24);
            lblage.TabIndex = 6;
            lblage.Text = "Age:";
            // 
            // txtLast_Name
            // 
            txtLast_Name.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtLast_Name.Location = new Point(133, 184);
            txtLast_Name.Name = "txtLast_Name";
            txtLast_Name.Size = new Size(304, 32);
            txtLast_Name.TabIndex = 8;
            // 
            // txt_Age
            // 
            txt_Age.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_Age.Location = new Point(134, 357);
            txt_Age.Name = "txt_Age";
            txt_Age.Size = new Size(304, 32);
            txt_Age.TabIndex = 11;
            // 
            // btnsaverecord
            // 
            btnsaverecord.BackColor = SystemColors.ActiveBorder;
            btnsaverecord.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnsaverecord.ForeColor = SystemColors.ActiveCaptionText;
            btnsaverecord.Location = new Point(32, 411);
            btnsaverecord.Name = "btnsaverecord";
            btnsaverecord.Size = new Size(406, 64);
            btnsaverecord.TabIndex = 12;
            btnsaverecord.Text = "SAVE RECORD";
            btnsaverecord.UseVisualStyleBackColor = false;
            // 
            // txtFirst_Name
            // 
            txtFirst_Name.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtFirst_Name.Location = new Point(134, 128);
            txtFirst_Name.Name = "txtFirst_Name";
            txtFirst_Name.Size = new Size(304, 32);
            txtFirst_Name.TabIndex = 9;
            // 
            // cbregisterstudentcourse
            // 
            cbregisterstudentcourse.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbregisterstudentcourse.FormattingEnabled = true;
            cbregisterstudentcourse.Location = new Point(133, 240);
            cbregisterstudentcourse.Name = "cbregisterstudentcourse";
            cbregisterstudentcourse.Size = new Size(305, 31);
            cbregisterstudentcourse.TabIndex = 29;
            // 
            // cbregisterstudentsection
            // 
            cbregisterstudentsection.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbregisterstudentsection.FormattingEnabled = true;
            cbregisterstudentsection.Location = new Point(136, 305);
            cbregisterstudentsection.Name = "cbregisterstudentsection";
            cbregisterstudentsection.Size = new Size(302, 31);
            cbregisterstudentsection.TabIndex = 30;
            // 
            // RegisterStudent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(518, 694);
            Controls.Add(cbregisterstudentsection);
            Controls.Add(cbregisterstudentcourse);
            Controls.Add(btnsaverecord);
            Controls.Add(txt_Age);
            Controls.Add(txtFirst_Name);
            Controls.Add(txtLast_Name);
            Controls.Add(lblage);
            Controls.Add(lbllastname);
            Controls.Add(lblcourse);
            Controls.Add(lblsection);
            Controls.Add(lbl1);
            Controls.Add(lblfirstname);
            Name = "RegisterStudent";
            Text = "RegisterStudent";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblfirstname;
        private Label lbl1;
        private Label lblsection;
        private Label lblcourse;
        private Label lbllastname;
        private Label lblage;
        private TextBox txtLast_Name;
        private TextBox txt_Age;
        private Button btnsaverecord;
        private TextBox txtFirst_Name;
        private ComboBox cbregisterstudentcourse;
        private ComboBox cbregisterstudentsection;
    }
}