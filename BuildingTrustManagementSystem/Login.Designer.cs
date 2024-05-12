namespace FurnitureProductionManagementSystem
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            utbl = new TextBox();
            ptbl = new TextBox();
            lbtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(191, 53);
            label1.Name = "label1";
            label1.Size = new Size(369, 25);
            label1.TabIndex = 0;
            label1.Text = "Furniture Production Management System";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(175, 139);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(175, 185);
            label3.Name = "label3";
            label3.Size = new Size(87, 25);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // utbl
            // 
            utbl.Location = new Point(272, 139);
            utbl.Name = "utbl";
            utbl.Size = new Size(262, 31);
            utbl.TabIndex = 3;
            // 
            // ptbl
            // 
            ptbl.Location = new Point(272, 182);
            ptbl.Name = "ptbl";
            ptbl.PasswordChar = '*';
            ptbl.Size = new Size(262, 31);
            ptbl.TabIndex = 4;
            // 
            // lbtn
            // 
            lbtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lbtn.Location = new Point(290, 272);
            lbtn.Name = "lbtn";
            lbtn.Size = new Size(143, 39);
            lbtn.TabIndex = 5;
            lbtn.Text = "Login";
            lbtn.UseVisualStyleBackColor = true;
            lbtn.Click += lbtn_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(718, 385);
            Controls.Add(lbtn);
            Controls.Add(ptbl);
            Controls.Add(utbl);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox utbl;
        private TextBox ptbl;
        private Button lbtn;
    }
}
