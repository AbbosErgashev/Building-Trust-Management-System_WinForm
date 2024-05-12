namespace FurnitureProductionManagementSystem
{
    partial class Warehouse
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            stbl = new TextBox();
            label5 = new Label();
            label4 = new Label();
            restorebtn = new Button();
            wDGV = new DataGridView();
            dbtn = new Button();
            ubtn = new Button();
            resetbtn = new Button();
            sbtn = new Button();
            cntbl = new TextBox();
            label1 = new Label();
            citbl = new Label();
            pncb = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)wDGV).BeginInit();
            SuspendLayout();
            // 
            // stbl
            // 
            stbl.Location = new Point(361, 339);
            stbl.Name = "stbl";
            stbl.Size = new Size(285, 31);
            stbl.TabIndex = 43;
            stbl.TextChanged += stbl_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(193, 342);
            label5.Name = "label5";
            label5.Size = new Size(164, 25);
            label5.TabIndex = 42;
            label5.Text = "Search by All Types";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(9, 341);
            label4.Name = "label4";
            label4.Size = new Size(150, 28);
            label4.TabIndex = 41;
            label4.Text = "Companies List";
            // 
            // restorebtn
            // 
            restorebtn.BackColor = Color.White;
            restorebtn.FlatAppearance.MouseOverBackColor = Color.Cyan;
            restorebtn.FlatStyle = FlatStyle.Flat;
            restorebtn.Location = new Point(661, 334);
            restorebtn.Name = "restorebtn";
            restorebtn.Size = new Size(147, 39);
            restorebtn.TabIndex = 40;
            restorebtn.Text = "Restore";
            restorebtn.UseVisualStyleBackColor = false;
            restorebtn.Click += restorebtn_Click;
            // 
            // wDGV
            // 
            wDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            wDGV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            wDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            wDGV.Dock = DockStyle.Bottom;
            wDGV.Location = new Point(0, 379);
            wDGV.Name = "wDGV";
            wDGV.RowHeadersWidth = 51;
            wDGV.Size = new Size(881, 315);
            wDGV.TabIndex = 39;
            wDGV.CellContentClick += wDGV_CellContentClick;
            // 
            // dbtn
            // 
            dbtn.BackColor = Color.White;
            dbtn.FlatAppearance.MouseOverBackColor = Color.Red;
            dbtn.FlatStyle = FlatStyle.Flat;
            dbtn.Location = new Point(466, 201);
            dbtn.Name = "dbtn";
            dbtn.Size = new Size(147, 42);
            dbtn.TabIndex = 38;
            dbtn.Text = "Delete";
            dbtn.UseVisualStyleBackColor = false;
            dbtn.Click += dbtn_Click;
            // 
            // ubtn
            // 
            ubtn.BackColor = Color.White;
            ubtn.FlatAppearance.MouseOverBackColor = Color.Yellow;
            ubtn.FlatStyle = FlatStyle.Flat;
            ubtn.Location = new Point(272, 201);
            ubtn.Name = "ubtn";
            ubtn.Size = new Size(147, 42);
            ubtn.TabIndex = 36;
            ubtn.Text = "Update";
            ubtn.UseVisualStyleBackColor = false;
            ubtn.Click += ubtn_Click;
            // 
            // resetbtn
            // 
            resetbtn.BackColor = Color.White;
            resetbtn.FlatAppearance.MouseOverBackColor = Color.Cyan;
            resetbtn.FlatStyle = FlatStyle.Flat;
            resetbtn.Location = new Point(661, 201);
            resetbtn.Name = "resetbtn";
            resetbtn.Size = new Size(147, 42);
            resetbtn.TabIndex = 37;
            resetbtn.Text = "Reset";
            resetbtn.UseVisualStyleBackColor = false;
            resetbtn.Click += resetbtn_Click;
            // 
            // sbtn
            // 
            sbtn.BackColor = Color.White;
            sbtn.FlatAppearance.MouseOverBackColor = Color.Lime;
            sbtn.FlatStyle = FlatStyle.Flat;
            sbtn.Location = new Point(90, 201);
            sbtn.Name = "sbtn";
            sbtn.Size = new Size(147, 42);
            sbtn.TabIndex = 35;
            sbtn.Text = "Save";
            sbtn.UseVisualStyleBackColor = false;
            sbtn.Click += sbtn_Click;
            // 
            // cntbl
            // 
            cntbl.Location = new Point(90, 104);
            cntbl.Name = "cntbl";
            cntbl.Size = new Size(284, 31);
            cntbl.TabIndex = 30;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(90, 76);
            label1.Name = "label1";
            label1.Size = new Size(141, 25);
            label1.TabIndex = 29;
            label1.Text = "Company Name";
            // 
            // citbl
            // 
            citbl.AutoSize = true;
            citbl.Location = new Point(466, 76);
            citbl.Name = "citbl";
            citbl.Size = new Size(118, 25);
            citbl.TabIndex = 33;
            citbl.Text = "Project Name";
            // 
            // pncb
            // 
            pncb.FormattingEnabled = true;
            pncb.Location = new Point(466, 104);
            pncb.Name = "pncb";
            pncb.Size = new Size(284, 33);
            pncb.TabIndex = 45;
            // 
            // Warehouse
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(881, 694);
            Controls.Add(pncb);
            Controls.Add(stbl);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(restorebtn);
            Controls.Add(wDGV);
            Controls.Add(dbtn);
            Controls.Add(ubtn);
            Controls.Add(resetbtn);
            Controls.Add(sbtn);
            Controls.Add(citbl);
            Controls.Add(cntbl);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Warehouse";
            Text = "Warehouse";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)wDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox stbl;
        private Label label5;
        private Label label4;
        private Button restorebtn;
        private DataGridView wDGV;
        private Button dbtn;
        private Button ubtn;
        private Button resetbtn;
        private Button sbtn;
        private TextBox cntbl;
        private Label label1;
        private Label citbl;
        private ComboBox pncb;
    }
}