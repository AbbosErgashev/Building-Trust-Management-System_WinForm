namespace FurnitureProductionManagementSystem
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void plbl_Click(object sender, EventArgs e)
        {
            Product p = new Product();
            p.TopLevel = false;
            mainpanel.Controls.Add(p);
            p.BringToFront();
            p.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }

        private void wlbl_Click(object sender, EventArgs e)
        {
            Project main = new Project();
            main.TopLevel = false;
            mainpanel.Controls.Add(main);
            main.BringToFront();
            main.Show();
        }

        private void productionlbl_Click(object sender, EventArgs e)
        {
            Warehouse main = new Warehouse();
            main.TopLevel = false;
            mainpanel.Controls.Add(main);
            main.BringToFront();
            main.Show();
        }

        private void llbl_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }
    }
}