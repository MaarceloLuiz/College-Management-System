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
            this.btnShowLecturers = new System.Windows.Forms.Button();
            this.btnShowStudents = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCollege)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVCollege
            // 
            this.DGVCollege.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVCollege.Location = new System.Drawing.Point(12, 136);
            this.DGVCollege.Name = "DGVCollege";
            this.DGVCollege.RowHeadersWidth = 51;
            this.DGVCollege.RowTemplate.Height = 24;
            this.DGVCollege.Size = new System.Drawing.Size(952, 400);
            this.DGVCollege.TabIndex = 0;
            // 
            // btnShowLecturers
            // 
            this.btnShowLecturers.Location = new System.Drawing.Point(12, 12);
            this.btnShowLecturers.Name = "btnShowLecturers";
            this.btnShowLecturers.Size = new System.Drawing.Size(158, 52);
            this.btnShowLecturers.TabIndex = 1;
            this.btnShowLecturers.Text = "Show Lecturers";
            this.btnShowLecturers.UseVisualStyleBackColor = true;
            // 
            // btnShowStudents
            // 
            this.btnShowStudents.Location = new System.Drawing.Point(12, 78);
            this.btnShowStudents.Name = "btnShowStudents";
            this.btnShowStudents.Size = new System.Drawing.Size(158, 52);
            this.btnShowStudents.TabIndex = 2;
            this.btnShowStudents.Text = "Show Students";
            this.btnShowStudents.UseVisualStyleBackColor = true;
            // 
            // DataView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 548);
            this.Controls.Add(this.btnShowStudents);
            this.Controls.Add(this.btnShowLecturers);
            this.Controls.Add(this.DGVCollege);
            this.Name = "DataView";
            this.Text = "DataView";
            ((System.ComponentModel.ISupportInitialize)(this.DGVCollege)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVCollege;
        private System.Windows.Forms.Button btnShowLecturers;
        private System.Windows.Forms.Button btnShowStudents;
    }
}