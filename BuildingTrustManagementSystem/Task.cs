using System.Data;
using System.Data.SqlClient;

namespace FurnitureProductionManagementSystem
{
    public partial class Product : Form
    {
        Functions Con;
        int Key = 0;

        public Product()
        {
            InitializeComponent();
            Con = new Functions();
            ShowTasks();
        }

        private void ShowTasks()
        {
            string Query = "select * from Task";
            tDGV.DataSource = Con.GetData(Query);
        }

        private void SaveTask()
        {
            if (tntbl.Text == "" || ptbl.Text == "" || dtbl.Text == "")
            {
                MessageBox.Show("Missing Data!");
            }
            else
            {
                try
                {
                    string taskName = tntbl.Text;
                    string description = dtbl.Text;
                    string price = ptbl.Text;
                    string Query = "insert into Task (TaskName, Description, Price) values('{0}', '{1}', '{2}')";
                    Query = string.Format(Query, taskName, description, price);
                    Con.SetData(Query);
                    MessageBox.Show("Task Added");
                    Reset();
                    ShowTasks();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void UpdateTask()
        {
            if (tntbl.Text == "" || ptbl.Text == "" || dtbl.Text == "")
            {
                MessageBox.Show("Missing Data!");
            }
            else
            {
                try
                {
                    string taskName = tntbl.Text;
                    string description = dtbl.Text;
                    string price = ptbl.Text;
                    string Query = "update Task set TaskName = '{0}', description='{1}', price='{2}' where TaskId={3}";
                    Query = string.Format(Query, taskName, description, price, Key);
                    Con.SetData(Query);
                    MessageBox.Show("Task Updated");
                    Reset();
                    ShowTasks();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void DeleteTask()
        {
            if (Key == 0)
            {
                MessageBox.Show("Missing Data!");
            }
            else
            {
                try
                {
                    string Query = "delete from Task where TaskId = {0}";
                    Query = string.Format(Query, Key);
                    Con.SetData(Query);
                    MessageBox.Show("Task Deleted");
                    Reset();
                    ShowTasks();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private DataTable AllSearch()
        {
            string query = "SELECT * FROM Task ";
            query += "WHERE TaskID LIKE '%' + @param + '%' ";
            query += "OR TaskName LIKE '%' + @param + '%' ";
            query += "OR Description LIKE '%' + @param + '%' ";
            query += "OR Price LIKE '%' + @param + '%' ";
            string con = "Data Source=ACER;Initial Catalog=BuildingTrust_DB;Integrated Security=True;Encrypt=False";

            using (SqlConnection conn = new SqlConnection(con))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@param", stbl.Text);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        tDGV.DataSource = dt;
                        return dt;
                    }
                }
            }
        }

        private void Reset()
        {
            tntbl.Text = "";
            ptbl.Text = "";
            dtbl.Text = "";
        }

        private void pDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tntbl.Text = tDGV.Rows[e.RowIndex].Cells[1].Value.ToString();
            dtbl.Text = tDGV.Rows[e.RowIndex].Cells[2].Value.ToString();
            ptbl.Text = tDGV.Rows[e.RowIndex].Cells[3].Value.ToString();
            if (tntbl.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(tDGV.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
        }

        private void RestoreFilter()
        {
            stbl.Text = "";
            ShowTasks();
        }

        private void sbtn_Click(object sender, EventArgs e)
        {
            SaveTask();
        }

        private void ubtn_Click(object sender, EventArgs e)
        {
            UpdateTask();
        }

        private void dbtn_Click(object sender, EventArgs e)
        {
            DeleteTask();
        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void restorebtn_Click(object sender, EventArgs e)
        {
            RestoreFilter();
            ShowTasks();
        }

        private void stbl_TextChanged(object sender, EventArgs e)
        {
            AllSearch();
        }
    }
}