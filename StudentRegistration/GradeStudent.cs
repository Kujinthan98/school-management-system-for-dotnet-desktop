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
    public partial class GradeStudent : Form
    {
        public GradeStudent()
        {
            InitializeComponent();
        }

        private void btnGSAdd_Click(object sender, EventArgs e)
        {
            String connetionString = null;
            SqlConnection connection;
            SqlCommand command;
            String sql = null;

            connetionString = "Server =DESKTOP-UJCSBLC\\SQLEXPRESS; Database =student_registration; Trusted_Connection = True";
            connection = new SqlConnection(connetionString);
            sql = "INSERT INTO grade_subject ( grade_id, subject_id)  VALUES ('" + txtGradeId.Text + "','" + txtSubId.Text + "');";

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

        private void btnGSRead_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            DataView dv = new DataView();
            dt = new DataTable();
            string connetionString = null;
            SqlConnection connection;
            SqlCommand command;
            dv = dt.DefaultView;
            string sql = "Select * from grade_subject";
            SqlDataReader dataReader;
            connetionString = "Server =DESKTOP-UJCSBLC\\SQLEXPRESS; Database =student_registration; Trusted_Connection = True";
            connection = new SqlConnection(connetionString);
            try
            {
                connection.Open();
                SqlDataAdapter da = new SqlDataAdapter(sql, connection);
                da.Fill(dt);
                dgvGradeStudent.DataSource = dv;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
            }
        }

        private void btnGSUpdate_Click(object sender, EventArgs e)
        {
            String id = null;
            id = dgvGradeStudent.SelectedRows[0].Cells["id"].Value.ToString();
            String grade_id = dgvGradeStudent.SelectedRows[0].Cells["grade_id"].Value.ToString();
            String subject_id = dgvGradeStudent.SelectedRows[0].Cells["subject_id"].Value.ToString();


            txtGradeId.Text = grade_id;
            txtSubId.Text = subject_id;
        }

        private void btnGSDelete_Click(object sender, EventArgs e)
        {
            if (dgvGradeStudent.SelectedRows.Count > 0)
            {
                int selectedIndex = dgvGradeStudent.SelectedRows[0].Index;
                int id = Convert.ToInt32(dgvGradeStudent[0, selectedIndex].Value);
                //String id = stdtable.SelectedRows[0].Cells["id"].Value.ToString();
                string sql = "DELETE FROM grade_subject WHERE id ='" + id + "'";
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

        private void btnGSSave_Click(object sender, EventArgs e)
        {
            String id = dgvGradeStudent.SelectedRows[0].Cells["id"].Value.ToString();

            string connetionString = null;
            SqlConnection connection;
            SqlCommand command;
            string sql = null;
            connetionString = "Server =DESKTOP-UJCSBLC\\SQLEXPRESS; Database =student_registration; Trusted_Connection = True";
            connection = new SqlConnection(connetionString);
            sql = "UPDATE [grade_subject] SET [grade_id] = '" + txtGradeId.Text + "',[subject_id] = '" + txtSubId.Text + "' WHERE [id]='" + id + "';";
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