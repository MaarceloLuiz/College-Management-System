namespace CA1_College
{
    partial class DataView
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
            this.DGVStu = new System.Windows.Forms.DataGridView();
            this.btnShowAbove = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnShowAllStudents = new System.Windows.Forms.Button();
            this.cboShowGender = new System.Windows.Forms.ComboBox();
            this.btnShowGender = new System.Windows.Forms.Button();
            this.cboShowCourse = new System.Windows.Forms.ComboBox();
            this.btnShowCourse = new System.Windows.Forms.Button();
            this.cboShowModule = new System.Windows.Forms.ComboBox();
            this.btnShowModule = new System.Windows.Forms.Button();
            this.txtShowAge = new System.Windows.Forms.TextBox();
            this.btnShowAllLecturers = new System.Windows.Forms.Button();
            this.DGVLec = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVStu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVLec)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVStu
            // 
            this.DGVStu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVStu.Location = new System.Drawing.Point(12, 240);
            this.DGVStu.Name = "DGVStu";
            this.DGVStu.RowHeadersWidth = 51;
            this.DGVStu.RowTemplate.Height = 24;
            this.DGVStu.Size = new System.Drawing.Size(952, 212);
            this.DGVStu.TabIndex = 0;
            // 
            // btnShowAbove
            // 
            this.btnShowAbove.Location = new System.Drawing.Point(214, 132);
            this.btnShowAbove.Name = "btnShowAbove";
            this.btnShowAbove.Size = new System.Drawing.Size(158, 52);
            this.btnShowAbove.TabIndex = 2;
            this.btnShowAbove.Text = "Show Students Above (Age)";
            this.btnShowAbove.UseVisualStyleBackColor = true;
            this.btnShowAbove.Click += new System.EventHandler(this.btnShowAbove_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(418, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Show Data";
            // 
            // btnShowAllStudents
            // 
            this.btnShowAllStudents.Location = new System.Drawing.Point(12, 131);
            this.btnShowAllStudents.Name = "btnShowAllStudents";
            this.btnShowAllStudents.Size = new System.Drawing.Size(158, 52);
            this.btnShowAllStudents.TabIndex = 4;
            this.btnShowAllStudents.Text = "Show All Students";
            this.btnShowAllStudents.UseVisualStyleBackColor = true;
            this.btnShowAllStudents.Click += new System.EventHandler(this.btnShowAllStudents_Click);
            // 
            // cboShowGender
            // 
            this.cboShowGender.FormattingEnabled = true;
            this.cboShowGender.Location = new System.Drawing.Point(389, 89);
            this.cboShowGender.Name = "cboShowGender";
            this.cboShowGender.Size = new System.Drawing.Size(172, 24);
            this.cboShowGender.TabIndex = 47;
            // 
            // btnShowGender
            // 
            this.btnShowGender.Location = new System.Drawing.Point(214, 74);
            this.btnShowGender.Name = "btnShowGender";
            this.btnShowGender.Size = new System.Drawing.Size(158, 52);
            this.btnShowGender.TabIndex = 46;
            this.btnShowGender.Text = "Show Lecturers Gender";
            this.btnShowGender.UseVisualStyleBackColor = true;
            this.btnShowGender.Click += new System.EventHandler(this.btnShowGender_Click);
            // 
            // cboShowCourse
            // 
            this.cboShowCourse.FormattingEnabled = true;
            this.cboShowCourse.Location = new System.Drawing.Point(776, 89);
            this.cboShowCourse.Name = "cboShowCourse";
            this.cboShowCourse.Size = new System.Drawing.Size(172, 24);
            this.cboShowCourse.TabIndex = 51;
            this.cboShowCourse.SelectedIndexChanged += new System.EventHandler(this.cboShowCourse_SelectedIndexChanged);
            // 
            // btnShowCourse
            // 
            this.btnShowCourse.Location = new System.Drawing.Point(601, 74);
            this.btnShowCourse.Name = "btnShowCourse";
            this.btnShowCourse.Size = new System.Drawing.Size(158, 52);
            this.btnShowCourse.TabIndex = 50;
            this.btnShowCourse.Text = "Show Lecturers Course";
            this.btnShowCourse.UseVisualStyleBackColor = true;
            // 
            // cboShowModule
            // 
            this.cboShowModule.FormattingEnabled = true;
            this.cboShowModule.Location = new System.Drawing.Point(776, 147);
            this.cboShowModule.Name = "cboShowModule";
            this.cboShowModule.Size = new System.Drawing.Size(172, 24);
            this.cboShowModule.TabIndex = 49;
            // 
            // btnShowModule
            // 
            this.btnShowModule.Location = new System.Drawing.Point(601, 132);
            this.btnShowModule.Name = "btnShowModule";
            this.btnShowModule.Size = new System.Drawing.Size(158, 52);
            this.btnShowModule.TabIndex = 48;
            this.btnShowModule.Text = "Show Students Module";
            this.btnShowModule.UseVisualStyleBackColor = true;
            // 
            // txtShowAge
            // 
            this.txtShowAge.Location = new System.Drawing.Point(389, 146);
            this.txtShowAge.Name = "txtShowAge";
            this.txtShowAge.Size = new System.Drawing.Size(172, 22);
            this.txtShowAge.TabIndex = 52;
            // 
            // btnShowAllLecturers
            // 
            this.btnShowAllLecturers.Location = new System.Drawing.Point(12, 73);
            this.btnShowAllLecturers.Name = "btnShowAllLecturers";
            this.btnShowAllLecturers.Size = new System.Drawing.Size(158, 52);
            this.btnShowAllLecturers.TabIndex = 53;
            this.btnShowAllLecturers.Text = "Show All Lecturers";
            this.btnShowAllLecturers.UseVisualStyleBackColor = true;
            this.btnShowAllLecturers.Click += new System.EventHandler(this.btnShowAllLecturers_Click);
            // 
            // DGVLec
            // 
            this.DGVLec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVLec.Location = new System.Drawing.Point(12, 508);
            this.DGVLec.Name = "DGVLec";
            this.DGVLec.RowHeadersWidth = 51;
            this.DGVLec.RowTemplate.Height = 24;
            this.DGVLec.Size = new System.Drawing.Size(952, 212);
            this.DGVLec.TabIndex = 54;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(418, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 23);
            this.label2.TabIndex = 55;
            this.label2.Text = "Students";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(418, 476);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 23);
            this.label3.TabIndex = 56;
            this.label3.Text = "Lecturers";
            // 
            // DataView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 732);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DGVLec);
            this.Controls.Add(this.btnShowAllLecturers);
            this.Controls.Add(this.txtShowAge);
            this.Controls.Add(this.cboShowCourse);
            this.Controls.Add(this.btnShowCourse);
            this.Controls.Add(this.cboShowModule);
            this.Controls.Add(this.btnShowModule);
            this.Controls.Add(this.cboShowGender);
            this.Controls.Add(this.btnShowGender);
            this.Controls.Add(this.btnShowAllStudents);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnShowAbove);
            this.Controls.Add(this.DGVStu);
            this.Name = "DataView";
            this.Text = "DataView";
            this.Load += new System.EventHandler(this.DataView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVStu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVLec)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVStu;
        private System.Windows.Forms.Button btnShowAbove;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnShowAllStudents;
        private System.Windows.Forms.ComboBox cboShowGender;
        private System.Windows.Forms.Button btnShowGender;
        private System.Windows.Forms.ComboBox cboShowCourse;
        private System.Windows.Forms.Button btnShowCourse;
        private System.Windows.Forms.ComboBox cboShowModule;
        private System.Windows.Forms.Button btnShowModule;
        private System.Windows.Forms.TextBox txtShowAge;
        private System.Windows.Forms.Button btnShowAllLecturers;
        private System.Windows.Forms.DataGridView DGVLec;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}