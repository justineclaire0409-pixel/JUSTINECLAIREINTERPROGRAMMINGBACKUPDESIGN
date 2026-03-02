namespace WinFormsApp15
{
    partial class Student
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
            lbl1 = new Label();
            txtstudentmasterlist = new TextBox();
            dataGridView1 = new DataGridView();
            btnsearch = new Button();
            label1 = new Label();
            lblfirstname = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button1 = new Button();
            button2 = new Button();
            txtid = new TextBox();
            txtstudentfirstname = new TextBox();
            txtstudentlastname = new TextBox();
            txtstudentage = new TextBox();
            cbcourse = new ComboBox();
            cbsection = new ComboBox();
            btnrefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl1.Location = new Point(12, 51);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(256, 24);
            lbl1.TabIndex = 3;
            lbl1.Text = " STUDENT MASTER LIST";
            lbl1.Click += lbl1_Click;
            // 
            // txtstudentmasterlist
            // 
            txtstudentmasterlist.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtstudentmasterlist.Location = new Point(12, 88);
            txtstudentmasterlist.Name = "txtstudentmasterlist";
            txtstudentmasterlist.Size = new Size(304, 32);
            txtstudentmasterlist.TabIndex = 10;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 141);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(734, 442);
            dataGridView1.TabIndex = 11;
            // 
            // btnsearch
            // 
            btnsearch.BackColor = SystemColors.ButtonFace;
            btnsearch.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnsearch.Location = new Point(424, 78);
            btnsearch.Name = "btnsearch";
            btnsearch.Size = new Size(229, 42);
            btnsearch.TabIndex = 12;
            btnsearch.Text = "SEARCH";
            btnsearch.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(971, 28);
            label1.Name = "label1";
            label1.Size = new Size(373, 24);
            label1.TabIndex = 13;
            label1.Text = "REGISTER STUDENT INFORMATION";
            // 
            // lblfirstname
            // 
            lblfirstname.AutoSize = true;
            lblfirstname.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblfirstname.Location = new Point(902, 122);
            lblfirstname.Name = "lblfirstname";
            lblfirstname.Size = new Size(117, 24);
            lblfirstname.TabIndex = 14;
            lblfirstname.Text = "First Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(902, 167);
            label2.Name = "label2";
            label2.Size = new Size(115, 24);
            label2.TabIndex = 15;
            label2.Text = "Last Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(939, 209);
            label3.Name = "label3";
            label3.Size = new Size(80, 24);
            label3.TabIndex = 16;
            label3.Text = "Course:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(936, 252);
            label4.Name = "label4";
            label4.Size = new Size(83, 24);
            label4.TabIndex = 17;
            label4.Text = "Section:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(966, 292);
            label5.Name = "label5";
            label5.Size = new Size(53, 24);
            label5.TabIndex = 18;
            label5.Text = "Age:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(980, 78);
            label6.Name = "label6";
            label6.Size = new Size(39, 24);
            label6.TabIndex = 19;
            label6.Text = "ID:";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonFace;
            button1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(1061, 332);
            button1.Name = "button1";
            button1.Size = new Size(229, 42);
            button1.TabIndex = 20;
            button1.Text = "SAVE RECORD";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonFace;
            button2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(1061, 393);
            button2.Name = "button2";
            button2.Size = new Size(229, 42);
            button2.TabIndex = 21;
            button2.Text = "DELETE RECORD";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // txtid
            // 
            txtid.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtid.Location = new Point(1025, 78);
            txtid.Name = "txtid";
            txtid.Size = new Size(295, 22);
            txtid.TabIndex = 22;
            // 
            // txtstudentfirstname
            // 
            txtstudentfirstname.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtstudentfirstname.Location = new Point(1025, 122);
            txtstudentfirstname.Name = "txtstudentfirstname";
            txtstudentfirstname.Size = new Size(295, 22);
            txtstudentfirstname.TabIndex = 23;
            // 
            // txtstudentlastname
            // 
            txtstudentlastname.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtstudentlastname.Location = new Point(1025, 167);
            txtstudentlastname.Name = "txtstudentlastname";
            txtstudentlastname.Size = new Size(295, 22);
            txtstudentlastname.TabIndex = 24;
            // 
            // txtstudentage
            // 
            txtstudentage.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtstudentage.Location = new Point(1025, 292);
            txtstudentage.Name = "txtstudentage";
            txtstudentage.Size = new Size(295, 22);
            txtstudentage.TabIndex = 27;
            // 
            // cbcourse
            // 
            cbcourse.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbcourse.FormattingEnabled = true;
            cbcourse.Location = new Point(1025, 210);
            cbcourse.Name = "cbcourse";
            cbcourse.Size = new Size(295, 23);
            cbcourse.TabIndex = 28;
            // 
            // cbsection
            // 
            cbsection.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbsection.FormattingEnabled = true;
            cbsection.Location = new Point(1025, 256);
            cbsection.Name = "cbsection";
            cbsection.Size = new Size(295, 23);
            cbsection.TabIndex = 29;
            // 
            // btnrefresh
            // 
            btnrefresh.BackColor = SystemColors.ButtonFace;
            btnrefresh.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnrefresh.Location = new Point(517, 12);
            btnrefresh.Name = "btnrefresh";
            btnrefresh.Size = new Size(229, 42);
            btnrefresh.TabIndex = 30;
            btnrefresh.Text = "REFRESH";
            btnrefresh.UseVisualStyleBackColor = false;
            // 
            // Student
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1404, 609);
            Controls.Add(btnrefresh);
            Controls.Add(cbsection);
            Controls.Add(cbcourse);
            Controls.Add(txtstudentage);
            Controls.Add(txtstudentlastname);
            Controls.Add(txtstudentfirstname);
            Controls.Add(txtid);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblfirstname);
            Controls.Add(label1);
            Controls.Add(btnsearch);
            Controls.Add(dataGridView1);
            Controls.Add(txtstudentmasterlist);
            Controls.Add(lbl1);
            Name = "Student";
            Text = "Student";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl1;
        private TextBox txtstudentmasterlist;
        private DataGridView dataGridView1;
        private Button btnsearch;
        private Label label1;
        private Label lblfirstname;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button1;
        private Button button2;
        private TextBox txtid;
        private TextBox txtstudentfirstname;
        private TextBox txtstudentlastname;
        private TextBox txtstudentage;
        private ComboBox cbcourse;
        private ComboBox cbsection;
        private Button btnrefresh;
    }
}