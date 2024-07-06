namespace StudentRegistration
{
    partial class Registration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
            this.txtAdmissionNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAdmissionNo = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.lblDOB = new System.Windows.Forms.Label();
            this.dtpDob = new System.Windows.Forms.DateTimePicker();
            this.lblNICNo = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txtNICNo = new System.Windows.Forms.TextBox();
            this.lblTpNO = new System.Windows.Forms.Label();
            this.txtTpNo = new System.Windows.Forms.TextBox();
            this.lblGradeID = new System.Windows.Forms.Label();
            this.lblMedium = new System.Windows.Forms.Label();
            this.lblAdmissionDate = new System.Windows.Forms.Label();
            this.lblResidentAddress = new System.Windows.Forms.Label();
            this.txtResidentAddreass = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cbGradeId = new System.Windows.Forms.ComboBox();
            this.cbMedium = new System.Windows.Forms.ComboBox();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.dtpDOA = new System.Windows.Forms.DateTimePicker();
            this.btnExit = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnUpload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAdmissionNo
            // 
            this.txtAdmissionNo.Location = new System.Drawing.Point(1061, 31);
            this.txtAdmissionNo.Name = "txtAdmissionNo";
            this.txtAdmissionNo.Size = new System.Drawing.Size(185, 22);
            this.txtAdmissionNo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.BackColor = System.Drawing.Color.SkyBlue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1279, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Student registration form ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblAdmissionNo
            // 
            this.lblAdmissionNo.AutoSize = true;
            this.lblAdmissionNo.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmissionNo.Location = new System.Drawing.Point(896, 33);
            this.lblAdmissionNo.Name = "lblAdmissionNo";
            this.lblAdmissionNo.Size = new System.Drawing.Size(117, 20);
            this.lblAdmissionNo.TabIndex = 2;
            this.lblAdmissionNo.Text = "Admission No";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(1061, 59);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(185, 22);
            this.txtFirstName.TabIndex = 2;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(896, 61);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(92, 20);
            this.lblFirstName.TabIndex = 2;
            this.lblFirstName.Text = "First name";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(1061, 87);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(185, 22);
            this.txtLastName.TabIndex = 3;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(896, 89);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(88, 20);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Last name";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(1061, 115);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(185, 22);
            this.txtFullName.TabIndex = 4;
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.Location = new System.Drawing.Point(896, 117);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(85, 20);
            this.lblFullName.TabIndex = 2;
            this.lblFullName.Text = "Full name";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(896, 141);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(66, 20);
            this.lblGender.TabIndex = 2;
            this.lblGender.Text = "Gender";
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMale.Location = new System.Drawing.Point(1061, 143);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(58, 20);
            this.rbMale.TabIndex = 5;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFemale.Location = new System.Drawing.Point(1144, 143);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(72, 20);
            this.rbFemale.TabIndex = 6;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "FeMale";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOB.Location = new System.Drawing.Point(896, 171);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(56, 20);
            this.lblDOB.TabIndex = 2;
            this.lblDOB.Text = "D O B ";
            // 
            // dtpDob
            // 
            this.dtpDob.CustomFormat = "yyyy-MM-dd";
            this.dtpDob.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDob.Location = new System.Drawing.Point(1061, 169);
            this.dtpDob.Name = "dtpDob";
            this.dtpDob.Size = new System.Drawing.Size(185, 22);
            this.dtpDob.TabIndex = 7;
            this.dtpDob.Value = new System.DateTime(2024, 6, 27, 0, 0, 0, 0);
            // 
            // lblNICNo
            // 
            this.lblNICNo.AutoSize = true;
            this.lblNICNo.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNICNo.Location = new System.Drawing.Point(896, 197);
            this.lblNICNo.Name = "lblNICNo";
            this.lblNICNo.Size = new System.Drawing.Size(63, 20);
            this.lblNICNo.TabIndex = 2;
            this.lblNICNo.Text = "NIC No";
            // 
            // txtNICNo
            // 
            this.txtNICNo.Location = new System.Drawing.Point(1061, 195);
            this.txtNICNo.Name = "txtNICNo";
            this.txtNICNo.Size = new System.Drawing.Size(185, 22);
            this.txtNICNo.TabIndex = 8;
            // 
            // lblTpNO
            // 
            this.lblTpNO.AutoSize = true;
            this.lblTpNO.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTpNO.Location = new System.Drawing.Point(896, 227);
            this.lblTpNO.Name = "lblTpNO";
            this.lblTpNO.Size = new System.Drawing.Size(55, 20);
            this.lblTpNO.TabIndex = 2;
            this.lblTpNO.Text = "Tp No";
            // 
            // txtTpNo
            // 
            this.txtTpNo.Location = new System.Drawing.Point(1061, 225);
            this.txtTpNo.Name = "txtTpNo";
            this.txtTpNo.Size = new System.Drawing.Size(185, 22);
            this.txtTpNo.TabIndex = 9;
            // 
            // lblGradeID
            // 
            this.lblGradeID.AutoSize = true;
            this.lblGradeID.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGradeID.Location = new System.Drawing.Point(896, 259);
            this.lblGradeID.Name = "lblGradeID";
            this.lblGradeID.Size = new System.Drawing.Size(78, 20);
            this.lblGradeID.TabIndex = 2;
            this.lblGradeID.Text = "Grade ID";
            // 
            // lblMedium
            // 
            this.lblMedium.AutoSize = true;
            this.lblMedium.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedium.Location = new System.Drawing.Point(896, 291);
            this.lblMedium.Name = "lblMedium";
            this.lblMedium.Size = new System.Drawing.Size(72, 20);
            this.lblMedium.TabIndex = 10;
            this.lblMedium.Text = "Medium";
            // 
            // lblAdmissionDate
            // 
            this.lblAdmissionDate.AutoSize = true;
            this.lblAdmissionDate.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmissionDate.Location = new System.Drawing.Point(896, 320);
            this.lblAdmissionDate.Name = "lblAdmissionDate";
            this.lblAdmissionDate.Size = new System.Drawing.Size(149, 20);
            this.lblAdmissionDate.TabIndex = 2;
            this.lblAdmissionDate.Text = "Date of admission";
            // 
            // lblResidentAddress
            // 
            this.lblResidentAddress.AutoSize = true;
            this.lblResidentAddress.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResidentAddress.Location = new System.Drawing.Point(896, 348);
            this.lblResidentAddress.Name = "lblResidentAddress";
            this.lblResidentAddress.Size = new System.Drawing.Size(143, 20);
            this.lblResidentAddress.TabIndex = 11;
            this.lblResidentAddress.Text = "Resident address";
            // 
            // txtResidentAddreass
            // 
            this.txtResidentAddreass.Location = new System.Drawing.Point(1061, 346);
            this.txtResidentAddreass.Multiline = true;
            this.txtResidentAddreass.Name = "txtResidentAddreass";
            this.txtResidentAddreass.Size = new System.Drawing.Size(185, 50);
            this.txtResidentAddreass.TabIndex = 13;
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.Azure;
            this.btnCreate.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Image = ((System.Drawing.Image)(resources.GetObject("btnCreate.Image")));
            this.btnCreate.Location = new System.Drawing.Point(12, 31);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(34, 34);
            this.btnCreate.TabIndex = 13;
            this.btnCreate.UseVisualStyleBackColor = false;
            // 
            // btnRead
            // 
            this.btnRead.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRead.Location = new System.Drawing.Point(465, 29);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(75, 34);
            this.btnRead.TabIndex = 13;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(570, 29);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 34);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(780, 31);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 34);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cbGradeId
            // 
            this.cbGradeId.FormattingEnabled = true;
            this.cbGradeId.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13"});
            this.cbGradeId.Location = new System.Drawing.Point(1061, 255);
            this.cbGradeId.Name = "cbGradeId";
            this.cbGradeId.Size = new System.Drawing.Size(185, 24);
            this.cbGradeId.TabIndex = 10;
            // 
            // cbMedium
            // 
            this.cbMedium.FormattingEnabled = true;
            this.cbMedium.Items.AddRange(new object[] {
            "Tamil",
            "English"});
            this.cbMedium.Location = new System.Drawing.Point(1061, 287);
            this.cbMedium.Name = "cbMedium";
            this.cbMedium.Size = new System.Drawing.Size(185, 24);
            this.cbMedium.TabIndex = 11;
            // 
            // dgvStudents
            // 
            this.dgvStudents.AllowUserToAddRows = false;
            this.dgvStudents.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dgvStudents.Location = new System.Drawing.Point(12, 71);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.RowHeadersWidth = 51;
            this.dgvStudents.RowTemplate.Height = 24;
            this.dgvStudents.Size = new System.Drawing.Size(853, 380);
            this.dgvStudents.TabIndex = 16;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(675, 31);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 34);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dtpDOA
            // 
            this.dtpDOA.CustomFormat = "yyyy-MM-dd";
            this.dtpDOA.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDOA.Location = new System.Drawing.Point(1061, 318);
            this.dtpDOA.Name = "dtpDOA";
            this.dtpDOA.Size = new System.Drawing.Size(185, 22);
            this.dtpDOA.TabIndex = 12;
            this.dtpDOA.Value = new System.DateTime(2024, 6, 27, 0, 0, 0, 0);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(1171, 417);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 34);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(52, 33);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(204, 30);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnUpload
            // 
            this.btnUpload.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpload.Location = new System.Drawing.Point(371, 29);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(75, 34);
            this.btnUpload.TabIndex = 13;
            this.btnUpload.Text = "Create";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1279, 463);
            this.Controls.Add(this.dgvStudents);
            this.Controls.Add(this.cbMedium);
            this.Controls.Add(this.cbGradeId);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.dtpDOA);
            this.Controls.Add(this.dtpDob);
            this.Controls.Add(this.rbFemale);
            this.Controls.Add(this.rbMale);
            this.Controls.Add(this.lblNICNo);
            this.Controls.Add(this.lblResidentAddress);
            this.Controls.Add(this.lblAdmissionDate);
            this.Controls.Add(this.lblMedium);
            this.Controls.Add(this.lblGradeID);
            this.Controls.Add(this.lblTpNO);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtResidentAddreass);
            this.Controls.Add(this.txtTpNo);
            this.Controls.Add(this.txtNICNo);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblAdmissionNo);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtAdmissionNo);
            this.Name = "Registration";
            this.Text = "Registration";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAdmissionNo;
        protected internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAdmissionNo;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.DateTimePicker dtpDob;
        private System.Windows.Forms.Label lblNICNo;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtNICNo;
        private System.Windows.Forms.Label lblTpNO;
        private System.Windows.Forms.TextBox txtTpNo;
        private System.Windows.Forms.Label lblGradeID;
        private System.Windows.Forms.Label lblMedium;
        private System.Windows.Forms.Label lblAdmissionDate;
        private System.Windows.Forms.Label lblResidentAddress;
        private System.Windows.Forms.TextBox txtResidentAddreass;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cbGradeId;
        private System.Windows.Forms.ComboBox cbMedium;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DateTimePicker dtpDOA;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnUpload;
    }
}

