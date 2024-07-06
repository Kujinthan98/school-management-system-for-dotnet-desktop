namespace StudentRegistration
{
    partial class index
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(index));
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegistration = new System.Windows.Forms.Button();
            this.btnGrades = new System.Windows.Forms.Button();
            this.btnSubject = new System.Windows.Forms.Button();
            this.btnrdStu = new System.Windows.Forms.Button();
            this.btnStuSub = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.SkyBlue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Main";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnRegistration
            // 
            this.btnRegistration.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistration.Location = new System.Drawing.Point(22, 39);
            this.btnRegistration.Name = "btnRegistration";
            this.btnRegistration.Size = new System.Drawing.Size(164, 32);
            this.btnRegistration.TabIndex = 1;
            this.btnRegistration.Text = "Registration";
            this.btnRegistration.UseVisualStyleBackColor = true;
            this.btnRegistration.Click += new System.EventHandler(this.btnRegistration_Click);
            // 
            // btnGrades
            // 
            this.btnGrades.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrades.Location = new System.Drawing.Point(22, 77);
            this.btnGrades.Name = "btnGrades";
            this.btnGrades.Size = new System.Drawing.Size(164, 32);
            this.btnGrades.TabIndex = 1;
            this.btnGrades.Text = "Grades";
            this.btnGrades.UseVisualStyleBackColor = true;
            this.btnGrades.Click += new System.EventHandler(this.btnGrades_Click);
            // 
            // btnSubject
            // 
            this.btnSubject.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubject.Location = new System.Drawing.Point(22, 115);
            this.btnSubject.Name = "btnSubject";
            this.btnSubject.Size = new System.Drawing.Size(164, 32);
            this.btnSubject.TabIndex = 1;
            this.btnSubject.Text = "Subjects";
            this.btnSubject.UseVisualStyleBackColor = true;
            this.btnSubject.Click += new System.EventHandler(this.btnSubject_Click);
            // 
            // btnrdStu
            // 
            this.btnrdStu.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrdStu.Location = new System.Drawing.Point(22, 153);
            this.btnrdStu.Name = "btnrdStu";
            this.btnrdStu.Size = new System.Drawing.Size(164, 32);
            this.btnrdStu.TabIndex = 1;
            this.btnrdStu.Text = "GradeStudent";
            this.btnrdStu.UseVisualStyleBackColor = true;
            this.btnrdStu.Click += new System.EventHandler(this.btnrdStu_Click);
            // 
            // btnStuSub
            // 
            this.btnStuSub.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStuSub.Location = new System.Drawing.Point(22, 191);
            this.btnStuSub.Name = "btnStuSub";
            this.btnStuSub.Size = new System.Drawing.Size(164, 32);
            this.btnStuSub.TabIndex = 1;
            this.btnStuSub.Text = "Student Subject";
            this.btnStuSub.UseVisualStyleBackColor = true;
            this.btnStuSub.Click += new System.EventHandler(this.btnStuSub_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(229, 89);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(110, 43);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(378, 239);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnStuSub);
            this.Controls.Add(this.btnrdStu);
            this.Controls.Add(this.btnSubject);
            this.Controls.Add(this.btnGrades);
            this.Controls.Add(this.btnRegistration);
            this.Controls.Add(this.label1);
            this.Name = "index";
            this.Text = "index";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegistration;
        private System.Windows.Forms.Button btnGrades;
        private System.Windows.Forms.Button btnSubject;
        private System.Windows.Forms.Button btnrdStu;
        private System.Windows.Forms.Button btnStuSub;
        private System.Windows.Forms.Button btnExit;
    }
}