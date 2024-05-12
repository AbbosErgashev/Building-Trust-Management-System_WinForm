namespace FurnitureProductionManagementSystem
{
    partial class Project
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
            pDGV = new DataGridView();
            dbtn = new Button();
            ubtn = new Button();
            resetbtn = new Button();
            sbtn = new Button();
            sdfd = new Label();
            dsfdf = new Label();
            pntbl = new TextBox();
            label1 = new Label();
            tncb = new ComboBox();
            sd = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)pDGV).BeginInit();
            SuspendLayout();
            // 
            // stbl
            // 
            stbl.Location = new Point(364, 339);
            stbl.Name = "stbl";
            stbl.Size = new Size(285, 31);
            stbl.TabIndex = 43;
            stbl.TextChanged += stbl_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(196, 342);
            label5.Name = "label5";
            label5.Size = new Size(164, 25);
            label5.TabIndex = 42;
            label5.Text = "Search by All Types";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(12, 341);
            label4.Name = "label4";
            label4.Size = new Size(121, 28);
            label4.TabIndex = 41;
            label4.Text = "Projects List";
            // 
            // restorebtn
            // 
            restorebtn.BackColor = Color.White;
            restorebtn.FlatAppearance.MouseOverBackColor = Color.Cyan;
            restorebtn.FlatStyle = FlatStyle.Flat;
            restorebtn.Location = new Point(667, 334);
            restorebtn.Name = "restorebtn";
            restorebtn.Size = new Size(147, 39);
            restorebtn.TabIndex = 40;
            restorebtn.Text = "Restore";
            restorebtn.UseVisualStyleBackColor = false;
            restorebtn.Click += restorebtn_Click;
            // 
            // pDGV
            // 
            pDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            pDGV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            pDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            pDGV.Dock = DockStyle.Bottom;
            pDGV.Location = new Point(0, 379);
            pDGV.Name = "pDGV";
            pDGV.RowHeadersWidth = 51;
            pDGV.Size = new Size(881, 315);
            pDGV.TabIndex = 39;
            pDGV.CellContentClick += pDGV_CellContentClick;
            // 
            // dbtn
            // 
            dbtn.BackColor = Color.White;
            dbtn.FlatAppearance.MouseOverBackColor = Color.Red;
            dbtn.FlatStyle = FlatStyle.Flat;
            dbtn.Location = new Point(472, 220);
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
            ubtn.Location = new Point(278, 220);
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
            resetbtn.Location = new Point(667, 220);
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
            sbtn.Location = new Point(96, 220);
            sbtn.Name = "sbtn";
            sbtn.Size = new Size(147, 42);
            sbtn.TabIndex = 35;
            sbtn.Text = "Save";
            sbtn.UseVisualStyleBackColor = false;
            sbtn.Click += sbtn_Click;
            // 
            // sdfd
            // 
            sdfd.AutoSize = true;
            sdfd.Location = new Point(607, 96);
            sdfd.Name = "sdfd";
            sdfd.Size = new Size(146, 25);
            sdfd.TabIndex = 34;
            sdfd.Text = "Submission Date";
            // 
            // dsfdf
            // 
            dsfdf.AutoSize = true;
            dsfdf.Location = new Point(352, 96);
            dsfdf.Name = "dsfdf";
            dsfdf.Size = new Size(118, 25);
            dsfdf.TabIndex = 33;
            dsfdf.Text = "Project Name";
            // 
            // pntbl
            // 
            pntbl.Location = new Point(352, 124);
            pntbl.Name = "pntbl";
            pntbl.Size = new Size(207, 31);
            pntbl.TabIndex = 32;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(96, 96);
            label1.Name = "label1";
            label1.Size = new Size(97, 25);
            label1.TabIndex = 29;
            label1.Text = "Task Name";
            // 
            // tncb
            // 
            tncb.FormattingEnabled = true;
            tncb.Location = new Point(96, 124);
            tncb.Name = "tncb";
            tncb.Size = new Size(205, 33);
            tncb.TabIndex = 44;
            // 
            // sd
            // 
            sd.Location = new Point(607, 122);
            sd.Name = "sd";
            sd.Size = new Size(207, 31);
            sd.TabIndex = 45;
            // 
            // Project
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(881, 694);
            Controls.Add(sd);
            Controls.Add(tncb);
            Controls.Add(stbl);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(restorebtn);
            Controls.Add(pDGV);
            Controls.Add(dbtn);
            Controls.Add(ubtn);
            Controls.Add(resetbtn);
            Controls.Add(sbtn);
            Controls.Add(sdfd);
            Controls.Add(dsfdf);
            Controls.Add(pntbl);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Project";
            Text = "Production";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox stbl;
        private Label label5;
        private Label label4;
        private Button restorebtn;
        private DataGridView pDGV;
        private Button dbtn;
        private Button ubtn;
        private Button resetbtn;
        private Button sbtn;
        private Label sdfd;
        private Label dsfdf;
        private TextBox pntbl;
        private Label label1;
        private ComboBox tncb;
        private DateTimePicker sd;
    }
}