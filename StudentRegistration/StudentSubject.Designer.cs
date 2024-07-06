namespace StudentRegistration
{
    partial class StudentSubject
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
            this.dgvStudentSubject = new System.Windows.Forms.DataGridView();
            this.btnSSSave = new System.Windows.Forms.Button();
            this.btnSSDelete = new System.Windows.Forms.Button();
            this.btnSSRead = new System.Windows.Forms.Button();
            this.btnSSUpdate = new System.Windows.Forms.Button();
            this.btnSSAdd = new System.Windows.Forms.Button();
            this.txtAddNo = new System.Windows.Forms.TextBox();
            this.txtSubId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentSubject)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStudentSubject
            // 
            this.dgvStudentSubject.AllowUserToAddRows = false;
            this.dgvStudentSubject.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvStudentSubject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentSubject.Location = new System.Drawing.Point(16, 143);
            this.dgvStudentSubject.Name = "dgvStudentSubject";
            this.dgvStudentSubject.RowHeadersWidth = 51;
            this.dgvStudentSubject.RowTemplate.Height = 24;
            this.dgvStudentSubject.Size = new System.Drawing.Size(393, 182);
            this.dgvStudentSubject.TabIndex = 19;
            // 
            // btnSSSave
            // 
            this.btnSSSave.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSSSave.Location = new System.Drawing.Point(334, 23);
            this.btnSSSave.Name = "btnSSSave";
            this.btnSSSave.Size = new System.Drawing.Size(75, 34);
            this.btnSSSave.TabIndex = 12;
            this.btnSSSave.Text = "Save";
            this.btnSSSave.UseVisualStyleBackColor = true;
            this.btnSSSave.Click += new System.EventHandler(this.btnSSSave_Click);
            // 
            // btnSSDelete
            // 
            this.btnSSDelete.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSSDelete.Location = new System.Drawing.Point(253, 23);
            this.btnSSDelete.Name = "btnSSDelete";
            this.btnSSDelete.Size = new System.Drawing.Size(75, 34);
            this.btnSSDelete.TabIndex = 13;
            this.btnSSDelete.Text = "delete";
            this.btnSSDelete.UseVisualStyleBackColor = true;
            this.btnSSDelete.Click += new System.EventHandler(this.btnSSDelete_Click);
            // 
            // btnSSRead
            // 
            this.btnSSRead.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSSRead.Location = new System.Drawing.Point(91, 23);
            this.btnSSRead.Name = "btnSSRead";
            this.btnSSRead.Size = new System.Drawing.Size(75, 34);
            this.btnSSRead.TabIndex = 14;
            this.btnSSRead.Text = "Read";
            this.btnSSRead.UseVisualStyleBackColor = true;
            this.btnSSRead.Click += new System.EventHandler(this.btnSSRead_Click);
            // 
            // btnSSUpdate
            // 
            this.btnSSUpdate.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSSUpdate.Location = new System.Drawing.Point(172, 23);
            this.btnSSUpdate.Name = "btnSSUpdate";
            this.btnSSUpdate.Size = new System.Drawing.Size(75, 34);
            this.btnSSUpdate.TabIndex = 15;
            this.btnSSUpdate.Text = "Update";
            this.btnSSUpdate.UseVisualStyleBackColor = true;
            this.btnSSUpdate.Click += new System.EventHandler(this.btnSSUpdate_Click);
            // 
            // btnSSAdd
            // 
            this.btnSSAdd.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSSAdd.Location = new System.Drawing.Point(10, 23);
            this.btnSSAdd.Name = "btnSSAdd";
            this.btnSSAdd.Size = new System.Drawing.Size(75, 34);
            this.btnSSAdd.TabIndex = 16;
            this.btnSSAdd.Text = "Add";
            this.btnSSAdd.UseVisualStyleBackColor = true;
            this.btnSSAdd.Click += new System.EventHandler(this.btnSSAdd_Click);
            // 
            // txtAddNo
            // 
            this.txtAddNo.Location = new System.Drawing.Point(168, 102);
            this.txtAddNo.Name = "txtAddNo";
            this.txtAddNo.Size = new System.Drawing.Size(213, 22);
            this.txtAddNo.TabIndex = 11;
            // 
            // txtSubId
            // 
            this.txtSubId.Location = new System.Drawing.Point(168, 75);
            this.txtSubId.Name = "txtSubId";
            this.txtSubId.Size = new System.Drawing.Size(213, 22);
            this.txtSubId.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Admission no";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Subject id";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.SkyBlue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Student Subject";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(333, 337);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 34);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // StudentSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(420, 383);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvStudentSubject);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSSSave);
            this.Controls.Add(this.btnSSDelete);
            this.Controls.Add(this.btnSSRead);
            this.Controls.Add(this.btnSSUpdate);
            this.Controls.Add(this.btnSSAdd);
            this.Controls.Add(this.txtAddNo);
            this.Controls.Add(this.txtSubId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "StudentSubject";
            this.Text = "Student Subject";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentSubject)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStudentSubject;
        private System.Windows.Forms.Button btnSSSave;
        private System.Windows.Forms.Button btnSSDelete;
        private System.Windows.Forms.Button btnSSRead;
        private System.Windows.Forms.Button btnSSUpdate;
        private System.Windows.Forms.Button btnSSAdd;
        private System.Windows.Forms.TextBox txtAddNo;
        private System.Windows.Forms.TextBox txtSubId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
    }
}