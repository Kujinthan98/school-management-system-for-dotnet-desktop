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
    public partial class grades : Form
    {
        public grades()
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
            sql = "INSERT INTO GRADES ( grade_name, grade_group, grade_order)  VALUES ('" + txtGradeName.Text + "','" + txtGradeGroup.Text + "', '" + txtGradeOrder.Text + "');";

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
            string sql = "Select * from grades";
            SqlDataReader dataReader;
            connetionString = "Server =DESKTOP-UJCSBLC\\SQLEXPRESS; Database =student_registration; Trusted_Connection = True";
            connection = new SqlConnection(connetionString);
            try
            {
                connection.Open();
                SqlDataAdapter da = new SqlDataAdapter(sql, connection);
                da.Fill(dt);
                dgvGrades.DataSource = dv;
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
            id = dgvGrades.SelectedRows[0].Cells["id"].Value.ToString();
            String grade_name = dgvGrades.SelectedRows[0].Cells["grade_name"].Value.ToString();
            String grade_group = dgvGrades.SelectedRows[0].Cells["grade_group"].Value.ToString();
            String grade_order = dgvGrades.SelectedRows[0].Cells["grade_order"].Value.ToString();

            txtGradeGroup.Text = grade_group;
            txtGradeName.Text = grade_name;
            txtGradeOrder.Text = grade_order;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvGrades.SelectedRows.Count > 0)
            {
                int selectedIndex = dgvGrades.SelectedRows[0].Index;
                int id = Convert.ToInt32(dgvGrades[0, selectedIndex].Value);
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
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String id = dgvGrades.SelectedRows[0].Cells["id"].Value.ToString();

            string connetionString = null;
            SqlConnection connection;
            SqlCommand command;
            string sql = null;
            connetionString = "Server =DESKTOP-UJCSBLC\\SQLEXPRESS; Database =student_registration; Trusted_Connection = True";
            connection = new SqlConnection(connetionString);
            sql = "UPDATE [grades] SET [grade_group] = '" + txtGradeGroup.Text + "',[grade_name] = '" + txtGradeName.Text + "',[grade_order] = '" + txtGradeOrder.Text + "' WHERE [id]='" + id + "';";
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