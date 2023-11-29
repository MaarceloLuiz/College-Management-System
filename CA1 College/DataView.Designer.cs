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
            this.DGVCollege = new System.Windows.Forms.DataGridView();
            this.btnShowAge = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.cboShowAge = new System.Windows.Forms.ComboBox();
            this.cboShowGender = new System.Windows.Forms.ComboBox();
            this.btnShowGender = new System.Windows.Forms.Button();
            this.cboShowCourse = new System.Windows.Forms.ComboBox();
            this.btnShowCourse = new System.Windows.Forms.Button();
            this.cboShowModule = new System.Windows.Forms.ComboBox();
            this.btnShowModule = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCollege)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVCollege
            // 
            this.DGVCollege.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVCollege.Location = new System.Drawing.Point(12, 189);
            this.DGVCollege.Name = "DGVCollege";
            this.DGVCollege.RowHeadersWidth = 51;
            this.DGVCollege.RowTemplate.Height = 24;
            this.DGVCollege.Size = new System.Drawing.Size(952, 347);
            this.DGVCollege.TabIndex = 0;
            // 
            // btnShowAge
            // 
            this.btnShowAge.Location = new System.Drawing.Point(214, 132);
            this.btnShowAge.Name = "btnShowAge";
            this.btnShowAge.Size = new System.Drawing.Size(158, 52);
            this.btnShowAge.TabIndex = 2;
            this.btnShowAge.Text = "Show Age";
            this.btnShowAge.UseVisualStyleBackColor = true;
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
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(12, 131);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(158, 52);
            this.btnShowAll.TabIndex = 4;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.UseVisualStyleBackColor = true;
            // 
            // cboShowAge
            // 
            this.cboShowAge.FormattingEnabled = true;
            this.cboShowAge.Location = new System.Drawing.Point(389, 147);
            this.cboShowAge.Name = "cboShowAge";
            this.cboShowAge.Size = new System.Drawing.Size(172, 24);
            this.cboShowAge.TabIndex = 45;
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
            this.btnShowGender.Text = "Show Gender";
            this.btnShowGender.UseVisualStyleBackColor = true;
            // 
            // cboShowCourse
            // 
            this.cboShowCourse.FormattingEnabled = true;
            this.cboShowCourse.Location = new System.Drawing.Point(776, 89);
            this.cboShowCourse.Name = "cboShowCourse";
            this.cboShowCourse.Size = new System.Drawing.Size(172, 24);
            this.cboShowCourse.TabIndex = 51;
            // 
            // btnShowCourse
            // 
            this.btnShowCourse.Location = new System.Drawing.Point(601, 74);
            this.btnShowCourse.Name = "btnShowCourse";
            this.btnShowCourse.Size = new System.Drawing.Size(158, 52);
            this.btnShowCourse.TabIndex = 50;
            this.btnShowCourse.Text = "Show Course";
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
            this.btnShowModule.Text = "Show Module";
            this.btnShowModule.UseVisualStyleBackColor = true;
            // 
            // DataView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 548);
            this.Controls.Add(this.cboShowCourse);
            this.Controls.Add(this.btnShowCourse);
            this.Controls.Add(this.cboShowModule);
            this.Controls.Add(this.btnShowModule);
            this.Controls.Add(this.cboShowGender);
            this.Controls.Add(this.btnShowGender);
            this.Controls.Add(this.cboShowAge);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnShowAge);
            this.Controls.Add(this.DGVCollege);
            this.Name = "DataView";
            this.Text = "DataView";
            ((System.ComponentModel.ISupportInitialize)(this.DGVCollege)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVCollege;
        private System.Windows.Forms.Button btnShowAge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.ComboBox cboShowAge;
        private System.Windows.Forms.ComboBox cboShowGender;
        private System.Windows.Forms.Button btnShowGender;
        private System.Windows.Forms.ComboBox cboShowCourse;
        private System.Windows.Forms.Button btnShowCourse;
        private System.Windows.Forms.ComboBox cboShowModule;
        private System.Windows.Forms.Button btnShowModule;
    }
}