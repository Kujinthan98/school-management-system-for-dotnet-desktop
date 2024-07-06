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
    public partial class subjects : Form
    {
        public subjects()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            String connetionString = null;
            SqlConnection connection;
            SqlCommand command;
            String sql = null;

            connetionString = "Server =DESKTOP-UJCSBLC\\SQLEXPRESS; Database =student_registration; Trusted_Connection = True";
            connection = new SqlConnection(connetionString);
            sql = "INSERT INTO subjects (subject_name, subject_index, subject_number, subject_order)  VALUES ('" + txtSubName.Text + "','" + txtSubIndex.Text + "', '" + txtSubNumber.Text + "','" + txtSubOrder.Text + "');";

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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String id = null;
            id = dgvSubject.SelectedRows[0].Cells["id"].Value.ToString();
            String subName = dgvSubject.SelectedRows[0].Cells["subject_name"].Value.ToString();
            String subIndex = dgvSubject.SelectedRows[0].Cells["subject_index"].Value.ToString();
            String subNumber = dgvSubject.SelectedRows[0].Cells["subject_number"].Value.ToString();
            String subOrder = dgvSubject.SelectedRows[0].Cells["subject_order"].Value.ToString();

            txtSubName.Text = subName;
            txtSubIndex.Text = subIndex;
            txtSubNumber.Text = subNumber;
            txtSubOrder.Text = subOrder;
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
            string sql = "Select * from subjects";
            SqlDataReader dataReader;
            connetionString = "Server =DESKTOP-UJCSBLC\\SQLEXPRESS; Database =student_registration; Trusted_Connection = True";
            connection = new SqlConnection(connetionString);
            try
            {
                connection.Open();
                SqlDataAdapter da = new SqlDataAdapter(sql, connection);
                da.Fill(dt);
                dgvSubject.DataSource = dv;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String id = dgvSubject.SelectedRows[0].Cells["id"].Value.ToString();

            string connetionString = null;
            SqlConnection connection;
            SqlCommand command;
            string sql = null;
            connetionString = "Server =DESKTOP-UJCSBLC\\SQLEXPRESS; Database =student_registration; Trusted_Connection = True";
            connection = new SqlConnection(connetionString);
            sql = "UPDATE [subjects] SET [subject_name] = '" + txtSubName.Text + "',[subject_index] = '" + txtSubIndex.Text + "',[subject_number] = '" + txtSubNumber.Text + "',[subject_order] = '" + txtSubOrder.Text + "' WHERE [id]='" + id + "';";
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

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (dgvSubject.SelectedRows.Count > 0)
            {
                int selectedIndex = dgvSubject.SelectedRows[0].Index;
                int id = Convert.ToInt32(dgvSubject[0, selectedIndex].Value);
                //String id = stdtable.SelectedRows[0].Cells["id"].Value.ToString();
                string sql = "DELETE FROM subjects WHERE id ='" + id + "'";
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
