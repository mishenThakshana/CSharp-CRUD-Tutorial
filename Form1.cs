using System.Data;
using System.Data.SqlClient;

namespace CRUDTutorial
{
    public partial class Form1 : Form
    {
        private SqlConnection con;

        public Form1()
        {
            InitializeComponent();
            con = new SqlConnection("Data Source=192.168.1.38;Initial Catalog=tutorialDB;Persist Security Info=True;User ID=sa;Password=Mishen@123;Encrypt=False");
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlCommand sqlCommand = new SqlCommand("INSERT INTO products (ProductID, name, design, color, added_date) VALUES (@Id, @Name, @Design, @Color, getDate(), getDate())", con))
                {
                    sqlCommand.Parameters.AddWithValue("@Id", int.Parse(inpId.Text));
                    sqlCommand.Parameters.AddWithValue("@Name", inpName.Text);
                    sqlCommand.Parameters.AddWithValue("@Design", inpDesign.Text);
                    sqlCommand.Parameters.AddWithValue("@Color", cbColor.Text);

                    con.Open();
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Successfully inserted");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

            finally
            {
                con.Close();
            }

            bindData();

            inpId.Text = "";
            inpName.Text = "";
            inpDesign.Text = "";
            cbColor.Text = "";
        }

        private void bindData()
        {
            try
            {
                con.Open();

                using (SqlCommand sqlCommand = new SqlCommand("SELECT * FROM products", con))
                {
                    SqlDataAdapter sd = new SqlDataAdapter(sqlCommand);
                    DataTable dt = new DataTable();
                    sd.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

            finally
            {
                con.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bindData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlCommand sqlCommand = new SqlCommand("UPDATE products SET name = @Name, design = @Design, color = @Color, updated_date = getDate()  WHERE ProductID = @Id", con))
                {
                    sqlCommand.Parameters.AddWithValue("@Id", int.Parse(inpId.Text));
                    sqlCommand.Parameters.AddWithValue("@Name", inpName.Text);
                    sqlCommand.Parameters.AddWithValue("@Design", inpDesign.Text);
                    sqlCommand.Parameters.AddWithValue("@Color", cbColor.Text);


                    con.Open();
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Successfully updated");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                con.Close();
            }

            bindData();

            inpId.Text = "";
            inpName.Text = "";
            inpDesign.Text = "";
            cbColor.Text = "";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var rN = e.RowIndex;

            inpId.Text = dataGridView1.Rows[rN].Cells["ProductID"].Value.ToString();
            inpName.Text = dataGridView1.Rows[rN].Cells["name"].Value.ToString();
            inpDesign.Text = dataGridView1.Rows[rN].Cells["design"].Value.ToString();
            cbColor.Text = dataGridView1.Rows[rN].Cells["color"].Value.ToString();

            btnInsert.Enabled = false;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            btnCancel.Enabled = true;
        }

        private void clearFields()
        {
            inpId.Text = "";
            inpName.Text = "";
            inpDesign.Text = "";
            cbColor.Text = "";

            btnInsert.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnCancel.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var confirmationResult = MessageBox.Show("Are you sure to delete?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirmationResult == DialogResult.Yes) {
                try
                {
                    using (SqlCommand sqlCommand = new SqlCommand("DELETE FROM products WHERE ProductID = @Id", con))
                    {
                        sqlCommand.Parameters.AddWithValue("@Id", int.Parse(inpId.Text));

                        con.Open();
                        sqlCommand.ExecuteNonQuery();
                        MessageBox.Show("Successfully deleted");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
                finally
                {
                    con.Close();
                }

                bindData();
            }

            
        }
    }
}
