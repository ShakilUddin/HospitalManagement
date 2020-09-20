namespace HospitalManagement
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Doctor = new System.Windows.Forms.ToolStripMenuItem();
            this.Add = new System.Windows.Forms.ToolStripMenuItem();
            this.Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.Patient = new System.Windows.Forms.ToolStripMenuItem();
            this.Patients = new System.Windows.Forms.ToolStripMenuItem();
            this.Inpatient = new System.Windows.Forms.ToolStripMenuItem();
            this.Outpatient = new System.Windows.Forms.ToolStripMenuItem();
            this.Lab = new System.Windows.Forms.ToolStripMenuItem();
            this.Room = new System.Windows.Forms.ToolStripMenuItem();
            this.Bill = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1173, 557);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Exit Application";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Doctor,
            this.Patient,
            this.Lab,
            this.Room,
            this.Bill});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1320, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Doctor
            // 
            this.Doctor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Add,
            this.Edit});
            this.Doctor.Name = "Doctor";
            this.Doctor.Size = new System.Drawing.Size(55, 20);
            this.Doctor.Text = "Doctor";
            // 
            // Add
            // 
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(96, 22);
            this.Add.Text = "Add";
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Edit
            // 
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(96, 22);
            this.Edit.Text = "Edit";
            // 
            // Patient
            // 
            this.Patient.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Patients,
            this.Inpatient,
            this.Outpatient});
            this.Patient.Name = "Patient";
            this.Patient.Size = new System.Drawing.Size(56, 20);
            this.Patient.Text = "Patient";
            // 
            // Patients
            // 
            this.Patients.Name = "Patients";
            this.Patients.Size = new System.Drawing.Size(131, 22);
            this.Patients.Text = "Patients";
            // 
            // Inpatient
            // 
            this.Inpatient.Name = "Inpatient";
            this.Inpatient.Size = new System.Drawing.Size(131, 22);
            this.Inpatient.Text = "Inpatient";
            // 
            // Outpatient
            // 
            this.Outpatient.Name = "Outpatient";
            this.Outpatient.Size = new System.Drawing.Size(131, 22);
            this.Outpatient.Text = "Outpatient";
            // 
            // Lab
            // 
            this.Lab.Name = "Lab";
            this.Lab.Size = new System.Drawing.Size(38, 20);
            this.Lab.Text = "Lab";
            // 
            // Room
            // 
            this.Room.Name = "Room";
            this.Room.Size = new System.Drawing.Size(51, 20);
            this.Room.Text = "Room";
            // 
            // Bill
            // 
            this.Bill.Name = "Bill";
            this.Bill.Size = new System.Drawing.Size(35, 20);
            this.Bill.Text = "Bill";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1320, 592);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Doctor;
        private System.Windows.Forms.ToolStripMenuItem Patient;
        private System.Windows.Forms.ToolStripMenuItem Inpatient;
        private System.Windows.Forms.ToolStripMenuItem Outpatient;
        private System.Windows.Forms.ToolStripMenuItem Lab;
        private System.Windows.Forms.ToolStripMenuItem Room;
        private System.Windows.Forms.ToolStripMenuItem Bill;
        private System.Windows.Forms.ToolStripMenuItem Patients;
        private System.Windows.Forms.ToolStripMenuItem Add;
        private System.Windows.Forms.ToolStripMenuItem Edit;
    }
}

