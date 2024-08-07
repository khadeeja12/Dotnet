namespace StudentManagementApp
{
    partial class AddMarksForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox comboBoxStudent;
        private System.Windows.Forms.TextBox textBoxMarks;
        private System.Windows.Forms.Button buttonAddMarks;
        private System.Windows.Forms.Label labelStudent;
        private System.Windows.Forms.Label labelMarks;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.comboBoxStudent = new System.Windows.Forms.ComboBox();
            this.textBoxMarks = new System.Windows.Forms.TextBox();
            this.buttonAddMarks = new System.Windows.Forms.Button();
            this.labelStudent = new System.Windows.Forms.Label();
            this.labelMarks = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxStudent
            // 
            this.comboBoxStudent.FormattingEnabled = true;
            this.comboBoxStudent.Location = new System.Drawing.Point(280, 76);
            this.comboBoxStudent.Name = "comboBoxStudent";
            this.comboBoxStudent.Size = new System.Drawing.Size(200, 24);
            this.comboBoxStudent.TabIndex = 0;
            // 
            // textBoxMarks
            // 
            this.textBoxMarks.Location = new System.Drawing.Point(280, 136);
            this.textBoxMarks.Name = "textBoxMarks";
            this.textBoxMarks.Size = new System.Drawing.Size(100, 22);
            this.textBoxMarks.TabIndex = 1;
            // 
            // buttonAddMarks
            // 
            this.buttonAddMarks.Location = new System.Drawing.Point(220, 209);
            this.buttonAddMarks.Name = "buttonAddMarks";
            this.buttonAddMarks.Size = new System.Drawing.Size(100, 30);
            this.buttonAddMarks.TabIndex = 2;
            this.buttonAddMarks.Text = "Add Marks";
            this.buttonAddMarks.UseVisualStyleBackColor = true;
            this.buttonAddMarks.Click += new System.EventHandler(this.buttonAddMarks_Click);
            // 
            // labelStudent
            // 
            this.labelStudent.AutoSize = true;
            this.labelStudent.Location = new System.Drawing.Point(157, 76);
            this.labelStudent.Name = "labelStudent";
            this.labelStudent.Size = new System.Drawing.Size(52, 16);
            this.labelStudent.TabIndex = 3;
            this.labelStudent.Text = "Student";
            // 
            // labelMarks
            // 
            this.labelMarks.AutoSize = true;
            this.labelMarks.Location = new System.Drawing.Point(157, 142);
            this.labelMarks.Name = "labelMarks";
            this.labelMarks.Size = new System.Drawing.Size(44, 16);
            this.labelMarks.TabIndex = 4;
            this.labelMarks.Text = "Marks";
            // 
            // AddMarksForm
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(586, 372);
            this.Controls.Add(this.labelMarks);
            this.Controls.Add(this.labelStudent);
            this.Controls.Add(this.buttonAddMarks);
            this.Controls.Add(this.textBoxMarks);
            this.Controls.Add(this.comboBoxStudent);
            this.Name = "AddMarksForm";
            this.Text = "Add Marks";
            this.Load += new System.EventHandler(this.AddMarksForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
