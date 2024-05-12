using System.Data;
using System.Data.SqlClient;

namespace FurnitureProductionManagementSystem
{
    public partial class Project : Form
    {
        Functions Con;
        int Key = 0;

        public Project()
        {
            InitializeComponent();
            Con = new Functions();
            ShowProject();
            GetProject();
        }

        private void ShowProject()
        {
            string Query = "select * from Project";
            pDGV.DataSource = Con.GetData(Query);
        }

        private void SaveProject()
        {
            if (tncb.SelectedIndex == -1 || pntbl.Text == "" || pntbl.Text == "")
            {
                MessageBox.Show("Missing Data!!!");
            }
            else
            {
                try
                {
                    int taskId = Convert.ToInt32(tncb.SelectedValue);
                    string projectName = pntbl.Text;
                    DateTime submissionDate = sd.Value.Date;
                    string Query = "insert into Project (TaskID, ProjectName, SubmissionDate) values('{0}', '{1}', '{2}')";
                    Query = string.Format(Query, taskId, projectName, submissionDate.ToString("yyyy-MM-dd"));

                    Con.SetData(Query);

                    MessageBox.Show("Project Added");
                    Reset();
                    ShowProject();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void UpdateProject()
        {
            if (tncb.SelectedIndex == -1 || pntbl.Text == "")
            {
                MessageBox.Show("Missing Data!");
            }
            else
            {
                try
                {
                    int taskId = Convert.ToInt32(tncb.SelectedValue);
                    string projectName = pntbl.Text;
                    DateTime submissionDate = sd.Value.Date;
                    string Query = "update Project set TaskID = '{0}', ProjectName='{1}', SubmissionDate='{2}' where ProjectID={3}";
                    Query = string.Format(Query, taskId, projectName, submissionDate.ToString("yyyy-MM-dd"), Key);
                    Con.SetData(Query);
                    MessageBox.Show("Project Updated");
                    Reset();
                    ShowProject();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void DeleteProject()
        {
            if (Key == 0)
            {
                MessageBox.Show("Missing Data!!!");
            }
            else
            {
                try
                {
                    string Query = "delete from Project where ProjectID = {0}";
                    Query = string.Format(Query, Key);
                    Con.SetData(Query);
                    MessageBox.Show("Project Deleted");
                    Reset();
                    ShowProject();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private DataTable AllSearch()
        {
            string query = "SELECT * FROM Project ";
            query += "WHERE ProjectID LIKE '%' + @param + '%' ";
            query += "OR TaskId LIKE '%' + @param + '%' ";
            query += "OR ProjectName LIKE '%' + @param + '%' ";
            query += "OR SubmissionDate LIKE '%' + @param + '%' ";
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
                        pDGV.DataSource = dt;
                        return dt;
                    }
                }
            }
        }

        private void Reset()
        {
            tncb.Text = "Select a Task";
            pntbl.Text = "";
        }

        private void RestoreFilter()
        {
            stbl.Text = "";
            ShowProject();
        }

        private void GetProject()
        {
            if (tncb.SelectedItem == "")
            {
                tncb.Text = "Tasks is empty!";
            }
            else
            {
                SqlConnection cn = new SqlConnection("Data Source=ACER;Initial Catalog=BuildingTrust_DB;Integrated Security=True;Encrypt=False");
                cn.Open();
                SqlCommand cmd = new SqlCommand("select * from Task", cn);
                SqlDataReader rdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("TaskID", typeof(int));
                dt.Load(rdr);
                tncb.DisplayMember = "TaskName";
                tncb.ValueMember = "TaskID";
                tncb.DataSource = dt;
                cn.Close();
            }
        }

        private void pDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < pDGV.Rows.Count)
            {
                tncb.SelectedValue = pDGV.Rows[e.RowIndex].Cells[1].Value.ToString();
                pntbl.Text = pDGV.Rows[e.RowIndex].Cells[2].Value.ToString();

                if (pDGV.Rows[e.RowIndex].Cells[3].Value != null)
                {
                    sd.Value = (DateTime)pDGV.Rows[e.RowIndex].Cells[3].Value;
                }

                if (tncb.SelectedIndex == -1 || pntbl.Text == "")
                {
                    Key = 0;
                }
                else
                {
                    Key = Convert.ToInt32(pDGV.Rows[e.RowIndex].Cells[0].Value.ToString());
                }
            }
        }

        private void sbtn_Click(object sender, EventArgs e)
        {
            SaveProject();
        }

        private void ubtn_Click(object sender, EventArgs e)
        {
            UpdateProject();
        }

        private void dbtn_Click(object sender, EventArgs e)
        {
            DeleteProject();
        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void restorebtn_Click(object sender, EventArgs e)
        {
            RestoreFilter();
        }

        private void stbl_TextChanged(object sender, EventArgs e)
        {
            AllSearch();
        }
    }
}