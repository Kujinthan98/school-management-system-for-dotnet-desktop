namespace StudentRegistration
{
    partial class GradeStudent
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvGradeStudent = new System.Windows.Forms.DataGridView();
            this.btnGSSave = new System.Windows.Forms.Button();
            this.btnGSDelete = new System.Windows.Forms.Button();
            this.btnGSRead = new System.Windows.Forms.Button();
            this.btnGSUpdate = new System.Windows.Forms.Button();
            this.btnGSAdd = new System.Windows.Forms.Button();
            this.txtSubId = new System.Windows.Forms.TextBox();
            this.txtGradeId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGradeStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(431, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "Grade Subject";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvGradeStudent
            // 
            this.dgvGradeStudent.AllowUserToAddRows = false;
            this.dgvGradeStudent.BackgroundColor = System.Drawing.Color.Azure;
            this.dgvGradeStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGradeStudent.Location = new System.Drawing.Point(20, 130);
            this.dgvGradeStudent.Name = "dgvGradeStudent";
            this.dgvGradeStudent.RowHeadersWidth = 51;
            this.dgvGradeStudent.RowTemplate.Height = 24;
            this.dgvGradeStudent.Size = new System.Drawing.Size(388, 223);
            this.dgvGradeStudent.TabIndex = 30;
            // 
            // btnGSSave
            // 
            this.btnGSSave.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGSSave.Location = new System.Drawing.Point(344, 23);
            this.btnGSSave.Name = "btnGSSave";
            this.btnGSSave.Size = new System.Drawing.Size(75, 34);
            this.btnGSSave.TabIndex = 25;
            this.btnGSSave.Text = "Save";
            this.btnGSSave.UseVisualStyleBackColor = true;
            this.btnGSSave.Click += new System.EventHandler(this.btnGSSave_Click);
            // 
            // btnGSDelete
            // 
            this.btnGSDelete.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGSDelete.Location = new System.Drawing.Point(263, 23);
            this.btnGSDelete.Name = "btnGSDelete";
            this.btnGSDelete.Size = new System.Drawing.Size(75, 34);
            this.btnGSDelete.TabIndex = 26;
            this.btnGSDelete.Text = "delete";
            this.btnGSDelete.UseVisualStyleBackColor = true;
            this.btnGSDelete.Click += new System.EventHandler(this.btnGSDelete_Click);
            // 
            // btnGSRead
            // 
            this.btnGSRead.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGSRead.Location = new System.Drawing.Point(101, 23);
            this.btnGSRead.Name = "btnGSRead";
            this.btnGSRead.Size = new System.Drawing.Size(75, 34);
            this.btnGSRead.TabIndex = 27;
            this.btnGSRead.Text = "Read";
            this.btnGSRead.UseVisualStyleBackColor = true;
            this.btnGSRead.Click += new System.EventHandler(this.btnGSRead_Click);
            // 
            // btnGSUpdate
            // 
            this.btnGSUpdate.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGSUpdate.Location = new System.Drawing.Point(182, 23);
            this.btnGSUpdate.Name = "btnGSUpdate";
            this.btnGSUpdate.Size = new System.Drawing.Size(75, 34);
            this.btnGSUpdate.TabIndex = 28;
            this.btnGSUpdate.Text = "Update";
            this.btnGSUpdate.UseVisualStyleBackColor = true;
            this.btnGSUpdate.Click += new System.EventHandler(this.btnGSUpdate_Click);
            // 
            // btnGSAdd
            // 
            this.btnGSAdd.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGSAdd.Location = new System.Drawing.Point(20, 23);
            this.btnGSAdd.Name = "btnGSAdd";
            this.btnGSAdd.Size = new System.Drawing.Size(75, 34);
            this.btnGSAdd.TabIndex = 29;
            this.btnGSAdd.Text = "Add";
            this.btnGSAdd.UseVisualStyleBackColor = true;
            this.btnGSAdd.Click += new System.EventHandler(this.btnGSAdd_Click);
            // 
            // txtSubId
            // 
            this.txtSubId.Location = new System.Drawing.Point(195, 90);
            this.txtSubId.Name = "txtSubId";
            this.txtSubId.Size = new System.Drawing.Size(213, 22);
            this.txtSubId.TabIndex = 24;
            // 
            // txtGradeId
            // 
            this.txtGradeId.Location = new System.Drawing.Point(195, 63);
            this.txtGradeId.Name = "txtGradeId";
            this.txtGradeId.Size = new System.Drawing.Size(213, 22);
            this.txtGradeId.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Subject id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Grade id";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(344, 369);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 34);
            this.btnExit.TabIndex = 25;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // GradeStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(431, 413);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvGradeStudent);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnGSSave);
            this.Controls.Add(this.btnGSDelete);
            this.Controls.Add(this.btnGSRead);
            this.Controls.Add(this.btnGSUpdate);
            this.Controls.Add(this.btnGSAdd);
            this.Controls.Add(this.txtSubId);
            this.Controls.Add(this.txtGradeId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "GradeStudent";
            this.Text = "Grade Student";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGradeStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvGradeStudent;
        private System.Windows.Forms.Button btnGSSave;
        private System.Windows.Forms.Button btnGSDelete;
        private System.Windows.Forms.Button btnGSRead;
        private System.Windows.Forms.Button btnGSUpdate;
        private System.Windows.Forms.Button btnGSAdd;
        private System.Windows.Forms.TextBox txtSubId;
        private System.Windows.Forms.TextBox txtGradeId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExit;
    }
}