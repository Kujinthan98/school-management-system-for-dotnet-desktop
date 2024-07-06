using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentRegistration
{
    public partial class StudentSubject : Form
    {
        public StudentSubject()
        {
            InitializeComponent();
        }

        private void btnSSAdd_Click(object sender, EventArgs e)
        {

            String connetionString = null;
            SqlConnection connection;
            SqlCommand command;
            String sql = null;

            connetionString = "Server =DESKTOP-UJCSBLC\\SQLEXPRESS; Database =student_registration; Trusted_Connection = True";
            connection = new SqlConnection(connetionString);
            sql = "INSERT INTO student_subject ( subject_id, admission_no)  VALUES ('" + txtSubId.Text + "','" + txtAddNo.Text + "');";

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

        private void btnSSRead_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            DataView dv = new DataView();
            dt = new DataTable();
            string connetionString = null;
            SqlConnection connection;
            SqlCommand command;
            dv = dt.DefaultView;
            string sql = "Select * from student_subject";
            SqlDataReader dataReader;
            connetionString = "Server =DESKTOP-UJCSBLC\\SQLEXPRESS; Database =student_registration; Trusted_Connection = True";
            connection = new SqlConnection(connetionString);
            try
            {
                connection.Open();
                SqlDataAdapter da = new SqlDataAdapter(sql, connection);
                da.Fill(dt);
                dgvStudentSubject.DataSource = dv;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
            }
        }

        private void btnSSUpdate_Click(object sender, EventArgs e)
        {
            String id = null;
            id = dgvStudentSubject.SelectedRows[0].Cells["id"].Value.ToString();
            String subject_id = dgvStudentSubject.SelectedRows[0].Cells["subject_id"].Value.ToString();
            String admission_no = dgvStudentSubject.SelectedRows[0].Cells["admission_no"].Value.ToString();
           

            txtAddNo.Text = subject_id;
            txtSubId.Text = admission_no;
        }

        private void btnSSDelete_Click(object sender, EventArgs e)
        {
            if (dgvStudentSubject.SelectedRows.Count > 0)
            {
                int selectedIndex = dgvStudentSubject.SelectedRows[0].Index;
                int id = Convert.ToInt32(dgvStudentSubject[0, selectedIndex].Value);
                //String id = stdtable.SelectedRows[0].Cells["id"].Value.ToString();
                string sql = "DELETE FROM student_subject WHERE id ='" + id + "'";
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
        }

        private void btnSSSave_Click(object sender, EventArgs e)
        {
            String id = dgvStudentSubject.SelectedRows[0].Cells["id"].Value.ToString();

            string connetionString = null;
            SqlConnection connection;
            SqlCommand command;
            string sql = null;
            connetionString = "Server =DESKTOP-UJCSBLC\\SQLEXPRESS; Database =student_registration; Trusted_Connection = True";
            connection = new SqlConnection(connetionString);
            sql = "UPDATE [student_subject] SET [subject_id] = '" + txtSubId.Text + "',[admission_no] = '" + txtAddNo.Text + "' WHERE [id]='" + id + "';";
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
    }
}
