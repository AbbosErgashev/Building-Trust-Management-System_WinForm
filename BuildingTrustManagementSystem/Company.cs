using System.Data;
using System.Data.SqlClient;

namespace FurnitureProductionManagementSystem
{
    public partial class Warehouse : Form
    {
        Functions Con;
        int Key = 0;

        public Warehouse()
        {
            InitializeComponent();
            Con = new Functions();
            ShowCompany();
            GetProject();
        }

        private void ShowCompany()
        {
            string Query = "select * from Company";
            wDGV.DataSource = Con.GetData(Query);
        }

        private void SaveCompany()
        {
            if (pncb.SelectedIndex == -1 || cntbl.Text == "")
            {
                MessageBox.Show("Missing Data!!!");
            }
            else
            {
                try
                {
                    int projectId = Convert.ToInt32(pncb.SelectedValue);
                    string companyName = cntbl.Text;
                    string Query = "insert into Company (ProjectId, CompanyName) values('{0}', '{1}')";
                    Query = string.Format(Query, projectId, companyName);

                    Con.SetData(Query);

                    MessageBox.Show("Company Added");
                    Reset();
                    ShowCompany();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void UpdateCompany()
        {
            if (pncb.SelectedIndex == -1 || cntbl.Text == "")
            {
                MessageBox.Show("Missing Data!");
            }
            else
            {
                try
                {
                    int projectId = Convert.ToInt32(pncb.SelectedValue);
                    string companyName = cntbl.Text;
                    string Query = "update Company set ProjectId = '{0}', CompanyName='{1}' where CompanyId={2}";
                    Query = string.Format(Query, projectId, companyName, Key);
                    Con.SetData(Query);
                    MessageBox.Show("Company Updated");
                    Reset();
                    ShowCompany();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void DeleteCompany()
        {
            if (Key == 0)
            {
                MessageBox.Show("Missing Data!!!");
            }
            else
            {
                try
                {
                    string Query = "delete from Company where CompanyID = {0}";
                    Query = string.Format(Query, Key);
                    Con.SetData(Query);
                    MessageBox.Show("Company Deleted");
                    Reset();
                    ShowCompany();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private DataTable AllSearch()
        {
            string query = "SELECT * FROM Company ";
            query += "WHERE CompanyId LIKE '%' + @param + '%' ";
            query += "OR ProjectID LIKE '%' + @param + '%' ";
            query += "OR CompanyName LIKE '%' + @param + '%' ";
            string con = "Data Source=ACER;Initial Catalog=BuildingTrust_DB;Integrated Security=True;Encrypt=False";

            using SqlConnection conn = new(con);
            using SqlCommand cmd = new(query, conn);
            cmd.Parameters.AddWithValue("@param", stbl.Text);
            using SqlDataAdapter da = new(cmd);
            DataTable dt = new();
            da.Fill(dt);
            wDGV.DataSource = dt;
            return dt;
        }

        private void Reset()
        {
            cntbl.Text = "";
            pncb.Text = "Select a Project";
        }

        private void RestoreFilter()
        {
            stbl.Text = "";
            ShowCompany();
        }

        private void GetProject()
        {
            if (pncb.SelectedItem == "")
            {
                pncb.Text = "Projects is empty!";
            }
            else
            {
                SqlConnection cn = new("Data Source=ACER;Initial Catalog=BuildingTrust_DB;Integrated Security=True;Encrypt=False");
                cn.Open();
                SqlCommand cmd = new("select * from Project", cn); 
                SqlDataReader rdr = cmd.ExecuteReader();
                DataTable dt = new();
                dt.Columns.Add("ProjectID", typeof(int));
                dt.Load(rdr);
                pncb.DisplayMember = "ProjectName";
                pncb.ValueMember = "ProjectID";
                pncb.DataSource = dt;
                cn.Close();
            }
        }

        private void wDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < wDGV.Rows.Count)
            {
                pncb.SelectedValue = wDGV.Rows[e.RowIndex].Cells[1].Value.ToString();
                cntbl.Text = wDGV.Rows[e.RowIndex].Cells[2].Value.ToString();
                if (pncb.SelectedIndex == -1 || cntbl.Text == "")
                {
                    Key = 0;
                }
                else
                {
                    Key = Convert.ToInt32(wDGV.Rows[e.RowIndex].Cells[0].Value.ToString());
                }
            }
        }

        private void sbtn_Click(object sender, EventArgs e)
        {
            SaveCompany();
        }

        private void ubtn_Click(object sender, EventArgs e)
        {
            UpdateCompany();
        }

        private void dbtn_Click(object sender, EventArgs e)
        {
            DeleteCompany();
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