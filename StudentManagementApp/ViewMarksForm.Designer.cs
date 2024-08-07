namespace StudentManagementApp
{
    partial class ViewMarksForm
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
            this.textBoxStudentName = new System.Windows.Forms.TextBox();
            this.buttonFetchMarks = new System.Windows.Forms.Button();
            this.listBoxMarks = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // textBoxStudentName
            // 
            this.textBoxStudentName.Location = new System.Drawing.Point(113, 56);
            this.textBoxStudentName.Name = "textBoxStudentName";
            this.textBoxStudentName.Size = new System.Drawing.Size(200, 22);
            this.textBoxStudentName.TabIndex = 0;
            // 
            // buttonFetchMarks
            // 
            this.buttonFetchMarks.Location = new System.Drawing.Point(392, 52);
            this.buttonFetchMarks.Name = "buttonFetchMarks";
            this.buttonFetchMarks.Size = new System.Drawing.Size(100, 30);
            this.buttonFetchMarks.TabIndex = 1;
            this.buttonFetchMarks.Text = "Fetch Marks";
            this.buttonFetchMarks.UseVisualStyleBackColor = true;
            this.buttonFetchMarks.Click += new System.EventHandler(this.buttonFetchMarks_Click);
            // 
            // listBoxMarks
            // 
            this.listBoxMarks.BackColor = System.Drawing.SystemColors.Info;
            this.listBoxMarks.FormattingEnabled = true;
            this.listBoxMarks.ItemHeight = 16;
            this.listBoxMarks.Location = new System.Drawing.Point(113, 145);
            this.listBoxMarks.Name = "listBoxMarks";
            this.listBoxMarks.Size = new System.Drawing.Size(379, 196);
            this.listBoxMarks.TabIndex = 2;
            // 
            // ViewMarksForm
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(611, 420);
            this.Controls.Add(this.listBoxMarks);
            this.Controls.Add(this.buttonFetchMarks);
            this.Controls.Add(this.textBoxStudentName);
            this.Name = "ViewMarksForm";
            this.Text = "View Marks";
            this.Load += new System.EventHandler(this.ViewMarksForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxStudentName;
        private System.Windows.Forms.Button buttonFetchMarks;
        private System.Windows.Forms.ListBox listBoxMarks;
    }
}
