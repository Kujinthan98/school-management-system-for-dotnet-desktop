using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentRegistration
{
    public partial class Registration : Form
    {
        DataTable dt = new DataTable();
        DataView dv = new DataView();
        public Registration()
        {
            InitializeComponent();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            String gender;
            gender = null;
            if (rbMale.Checked)
            {
                gender = "Male";
            }
            else if (rbFemale.Checked)
            {
                gender = "Female";
            }
            String connetionString = null;
            SqlConnection connection;
            SqlCommand command;
            String sql = null;

            connetionString = "Server =DESKTOP-UJCSBLC\\SQLEXPRESS; Database =student_registration; Trusted_Connection = True";
            connection = new SqlConnection(connetionString);
            sql = "INSERT INTO students (admission_no, first_name, last_name, full_name, gender, date_of_birth, stu_nic_no, tp_no, grade_id, medium, date_of_admission, resident_address)  VALUES ('" + txtAdmissionNo.Text + "','" + txtFirstName.Text + "', '" + txtLastName.Text + "','" + txtFullName.Text + "','" + gender + "','" + DateTime.Parse(dtpDob.Text).ToString("yyyy-MM-dd") + "','" + txtNICNo.Text + "','" + txtTpNo.Text + "', '" + cbGradeId.Text + "', '" + cbMedium.Text + "','" + DateTime.Parse(dtpDOA.Text).ToString("yyyy-MM-dd") + "','" + txtResidentAddreass.Text + "');";

            try
            {
                connection.Open();
                command = new SqlCommand(sql, connection);
                command.ExecuteNonQuery();
                command.Dispose();
                MessageBox.Show(" data stored successfully !!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            DataView dv = new DataView();
            dt = new DataTable();
            string connetionString = null;
            SqlConnection connection;
            SqlCommand command;
            dv = dt.DefaultView;
            string sql = "Select * from students";
            SqlDataReader dataReader;
            connetionString = "Server =DESKTOP-UJCSBLC\\SQLEXPRESS; Database =student_registration; Trusted_Connection = True";
            connection = new SqlConnection(connetionString);
            try
            {
                connection.Open();
                SqlDataAdapter da = new SqlDataAdapter(sql, connection);
                da.Fill(dt);
                dgvStudents.DataSource = dv;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String id = null;
            id = dgvStudents.SelectedRows[0].Cells["id"].Value.ToString();
            String admissionNo = dgvStudents.SelectedRows[0].Cells["admission_no"].Value.ToString();
            String firstName = dgvStudents.SelectedRows[0].Cells["First_name"].Value.ToString();
            String lastName = dgvStudents.SelectedRows[0].Cells["last_name"].Value.ToString();
            String fullName = dgvStudents.SelectedRows[0].Cells["full_name"].Value.ToString();
            String gender = dgvStudents.SelectedRows[0].Cells["gender"].Value.ToString();
            String DOB = dgvStudents.SelectedRows[0].Cells["date_of_birth"].Value.ToString();
            String nicNo = dgvStudents.SelectedRows[0].Cells["stu_nic_no"].Value.ToString();
            String tpNo = dgvStudents.SelectedRows[0].Cells["tp_no"].Value.ToString();
            String gradeId = dgvStudents.SelectedRows[0].Cells["grade_id"].Value.ToString();
            String medium = dgvStudents.SelectedRows[0].Cells["medium"].Value.ToString();
            String dateofA = dgvStudents.SelectedRows[0].Cells["date_of_admission"].Value.ToString();
            String rAddreass = dgvStudents.SelectedRows[0].Cells["resident_address"].Value.ToString();

            txtAdmissionNo.Text = admissionNo;
            txtFirstName.Text = firstName;
            txtLastName.Text = lastName;
            txtFullName.Text = fullName;
            if(gender == "Male")
            {
                rbMale.Checked = true;
            }
            else if(gender == "Female")
            {
                rbFemale.Checked = true;
            }
            dtpDob.Text = DOB;
            txtNICNo.Text = nicNo;
            txtTpNo.Text = tpNo;
            cbGradeId.Text = gradeId;
            cbMedium.Text = medium;
            dtpDOA.Text=dateofA;
            txtResidentAddreass.Text=rAddreass;
            
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvStudents.SelectedRows.Count > 0)
            {
                int selectedIndex = dgvStudents.SelectedRows[0].Index;
                int id = Convert.ToInt32(dgvStudents[0, selectedIndex].Value);
                //String id = stdtable.SelectedRows[0].Cells["id"].Value.ToString();
                string sql = "DELETE FROM students WHERE id ='" + id + "'";
                string connectionString = "Server =DESKTOP-UJCSBLC\\SQLEXPRESS; Database =student_registration; Trusted_Connection = True";
                using (SqlConnection cnn = new SqlConnection(connectionString))


                    try
                    {

                        cnn.Open();
                        SqlCommand command = new SqlCommand(sql, cnn);
                        // command.Parameters.AddWithValue("@id", id);
                        command.ExecuteNonQuery();
                        DialogResult dr = MessageBox.Show("Do you want delete!", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dr == DialogResult.No)
                        {
                            return;
                        }
                        cnn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Cannot delete row! ");
                    }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String id = dgvStudents.SelectedRows[0].Cells["id"].Value.ToString();
            String gender = null;
            if (rbMale.Checked)
            {
                gender = "Male";
            }
            else if (rbFemale.Checked)
            {
                gender = "Female";
            }
            String gradeID = cbGradeId.SelectedItem.ToString();
            String medium = cbMedium.SelectedItem.ToString();

            string connetionString = null;
            SqlConnection connection;
            SqlCommand command;
            string sql = null;
            connetionString = "Server =DESKTOP-UJCSBLC\\SQLEXPRESS; Database =student_registration; Trusted_Connection = True";
            connection = new SqlConnection(connetionString);
            sql = "UPDATE [STUDENTS] SET [admission_no] = '" + txtAdmissionNo.Text + "',[first_name] = '" + txtFirstName.Text + "',[last_name] = '" + txtLastName.Text + "',[full_name] = '" + txtFullName.Text + "',[gender] = '" + gender + "', [date_of_birth]='" + DateTime.Parse(dtpDob.Text).ToString("yyyy-MM-dd") + "', [stu_nic_no]='" + txtNICNo.Text+ "', [tp_no]='"+ txtTpNo.Text + "', [grade_id]='"+gradeID+ "', [medium]='"+ medium + "', [date_of_admission]='"+DateTime.Parse(dtpDOA.Text).ToString("yyyy-MM-dd")+ "', [resident_address]='"+txtResidentAddreass.Text+"' WHERE [id]='" + id + "';";
            try
            {
                connection.Open();
                command = new SqlCommand(sql, connection);
                command.ExecuteNonQuery();
                command.Dispose();
                MessageBox.Show(" data stored successfully !!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                connection.Close();
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("Can not open connection ! ", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
            try
            {
                dv = new DataView(dt, "first_name LIKE '%" + txtFirstName.Text + "%'", " first_name asc ", DataViewRowState.CurrentRows);
                dgvStudents.DataSource = dv;
            }
            catch (Exception)
            {

                throw;
            }

        }

       
    } 

}
