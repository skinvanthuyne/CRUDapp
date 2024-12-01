namespace CRUDapp
{
    partial class Form1
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
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtRole = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dataGridView1 = new DataGridView();
            label5 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(18, 17);
            label1.Name = "label1";
            label1.Size = new Size(211, 32);
            label1.TabIndex = 0;
            label1.Text = "User Database";                  
            // txtFirstName
            // 
            txtFirstName.Location = new Point(20, 143);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(242, 27);
            txtFirstName.TabIndex = 1;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(18, 229);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(242, 27);
            txtLastName.TabIndex = 2;
            // 
            // txtRole
            // 
            txtRole.Location = new Point(20, 310);
            txtRole.Name = "txtRole";
            txtRole.Size = new Size(242, 27);
            txtRole.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(19, 113);
            label2.Name = "label2";
            label2.Size = new Size(92, 20);
            label2.TabIndex = 4;
            label2.Text = "First Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(18, 205);
            label3.Name = "label3";
            label3.Size = new Size(90, 20);
            label3.TabIndex = 5;
            label3.Text = "Last Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(20, 286);
            label4.Name = "label4";
            label4.Size = new Size(43, 20);
            label4.TabIndex = 6;
            label4.Text = "Role";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(335, 113);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(437, 305);
            dataGridView1.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(335, 58);
            label5.Name = "label5";
            label5.Size = new Size(135, 32);
            label5.TabIndex = 8;
            label5.Text = "User List";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(19, 380);
            button1.Name = "button1";
            button1.Size = new Size(106, 38);
            button1.TabIndex = 9;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(131, 380);
            button2.Name = "button2";
            button2.Size = new Size(106, 38);
            button2.TabIndex = 10;
            button2.Text = "Remove";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(243, 380);
            button3.Name = "button3";
            button3.Size = new Size(73, 38);
            button3.TabIndex = 11;
            button3.Text = "Refresh";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(dataGridView1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtRole);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtRole;
        private Label label2;
        private Label label3;
        private Label label4;
        private DataGridView dataGridView1;
        private Label label5;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}
