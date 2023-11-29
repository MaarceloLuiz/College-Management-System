namespace CA1_College
{
    partial class Form1
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
            this.btnData = new System.Windows.Forms.Button();
            this.btnNewLecturers = new System.Windows.Forms.Button();
            this.btnNewStudents = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnData
            // 
            this.btnData.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnData.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnData.Location = new System.Drawing.Point(29, 198);
            this.btnData.Name = "btnData";
            this.btnData.Size = new System.Drawing.Size(217, 44);
            this.btnData.TabIndex = 9;
            this.btnData.Text = "Data Grid";
            this.btnData.UseVisualStyleBackColor = false;
            this.btnData.Click += new System.EventHandler(this.btnData_Click);
            // 
            // btnNewLecturers
            // 
            this.btnNewLecturers.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNewLecturers.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewLecturers.Location = new System.Drawing.Point(29, 78);
            this.btnNewLecturers.Name = "btnNewLecturers";
            this.btnNewLecturers.Size = new System.Drawing.Size(217, 44);
            this.btnNewLecturers.TabIndex = 8;
            this.btnNewLecturers.Text = "Lecturers";
            this.btnNewLecturers.UseVisualStyleBackColor = false;
            this.btnNewLecturers.Click += new System.EventHandler(this.btnNewLecturers_Click);
            // 
            // btnNewStudents
            // 
            this.btnNewStudents.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNewStudents.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewStudents.Location = new System.Drawing.Point(29, 138);
            this.btnNewStudents.Name = "btnNewStudents";
            this.btnNewStudents.Size = new System.Drawing.Size(217, 44);
            this.btnNewStudents.TabIndex = 7;
            this.btnNewStudents.Text = "Students";
            this.btnNewStudents.UseVisualStyleBackColor = false;
            this.btnNewStudents.Click += new System.EventHandler(this.btnNewStudents_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 28);
            this.label1.TabIndex = 6;
            this.label1.Text = "College System";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 283);
            this.Controls.Add(this.btnData);
            this.Controls.Add(this.btnNewLecturers);
            this.Controls.Add(this.btnNewStudents);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnData;
        private System.Windows.Forms.Button btnNewLecturers;
        private System.Windows.Forms.Button btnNewStudents;
        private System.Windows.Forms.Label label1;
    }
}

