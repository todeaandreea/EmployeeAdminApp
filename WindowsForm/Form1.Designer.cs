namespace WindowsForm
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
            button1 = new Button();
            comboBox1 = new ComboBox();
            label1 = new Label();
            delete_button = new Button();
            update_button = new Button();
            textBoxDepartmentId = new TextBox();
            textBoxName = new TextBox();
            textBoxEmail = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            textBoxDeleteId = new TextBox();
            label7 = new Label();
            textBoxUpdateId = new TextBox();
            textBoxUpdatedDepartmentId = new TextBox();
            textBoxUpdatedEmail = new TextBox();
            textBoxUpdatedName = new TextBox();
            insert_button = new Button();
            label2 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            checkBoxIsManager = new CheckBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(392, 27);
            button1.Name = "button1";
            button1.Size = new Size(171, 34);
            button1.TabIndex = 0;
            button1.Text = "Load Employees";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(165, 27);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 27);
            label1.Name = "label1";
            label1.Size = new Size(98, 25);
            label1.TabIndex = 2;
            label1.Text = "Employees";
            // 
            // delete_button
            // 
            delete_button.BackColor = Color.Salmon;
            delete_button.Location = new Point(600, 196);
            delete_button.Name = "delete_button";
            delete_button.Size = new Size(188, 61);
            delete_button.TabIndex = 4;
            delete_button.Text = "Delete Employee";
            delete_button.UseVisualStyleBackColor = false;
            delete_button.Click += delete_button_Click;
            // 
            // update_button
            // 
            update_button.BackColor = Color.LightSalmon;
            update_button.Location = new Point(69, 379);
            update_button.Name = "update_button";
            update_button.Size = new Size(213, 59);
            update_button.TabIndex = 5;
            update_button.Text = "Update Employee";
            update_button.UseVisualStyleBackColor = false;
            update_button.Click += update_button_Click;
            // 
            // textBoxDepartmentId
            // 
            textBoxDepartmentId.Location = new Point(392, 175);
            textBoxDepartmentId.Name = "textBoxDepartmentId";
            textBoxDepartmentId.Size = new Size(117, 31);
            textBoxDepartmentId.TabIndex = 7;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(392, 283);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(117, 31);
            textBoxName.TabIndex = 8;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(392, 226);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(117, 31);
            textBoxEmail.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(316, 178);
            label3.Name = "label3";
            label3.Size = new Size(70, 25);
            label3.TabIndex = 12;
            label3.Text = "Dep. Id";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(319, 232);
            label4.Name = "label4";
            label4.Size = new Size(54, 25);
            label4.TabIndex = 13;
            label4.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(319, 289);
            label6.Name = "label6";
            label6.Size = new Size(59, 25);
            label6.TabIndex = 15;
            label6.Text = "Name";
            // 
            // textBoxDeleteId
            // 
            textBoxDeleteId.Location = new Point(636, 150);
            textBoxDeleteId.Name = "textBoxDeleteId";
            textBoxDeleteId.Size = new Size(117, 31);
            textBoxDeleteId.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(588, 153);
            label7.Name = "label7";
            label7.Size = new Size(28, 25);
            label7.TabIndex = 17;
            label7.Text = "Id";
            // 
            // textBoxUpdateId
            // 
            textBoxUpdateId.Location = new Point(149, 175);
            textBoxUpdateId.Name = "textBoxUpdateId";
            textBoxUpdateId.Size = new Size(117, 31);
            textBoxUpdateId.TabIndex = 18;
            // 
            // textBoxUpdatedDepartmentId
            // 
            textBoxUpdatedDepartmentId.Location = new Point(149, 226);
            textBoxUpdatedDepartmentId.Name = "textBoxUpdatedDepartmentId";
            textBoxUpdatedDepartmentId.Size = new Size(117, 31);
            textBoxUpdatedDepartmentId.TabIndex = 19;
            // 
            // textBoxUpdatedEmail
            // 
            textBoxUpdatedEmail.Location = new Point(149, 274);
            textBoxUpdatedEmail.Name = "textBoxUpdatedEmail";
            textBoxUpdatedEmail.Size = new Size(117, 31);
            textBoxUpdatedEmail.TabIndex = 20;
            // 
            // textBoxUpdatedName
            // 
            textBoxUpdatedName.Location = new Point(149, 332);
            textBoxUpdatedName.Name = "textBoxUpdatedName";
            textBoxUpdatedName.Size = new Size(117, 31);
            textBoxUpdatedName.TabIndex = 22;
            // 
            // insert_button
            // 
            insert_button.BackColor = Color.DarkSalmon;
            insert_button.Location = new Point(350, 332);
            insert_button.Name = "insert_button";
            insert_button.Size = new Size(213, 63);
            insert_button.TabIndex = 23;
            insert_button.Text = "Insert Employee";
            insert_button.UseVisualStyleBackColor = false;
            insert_button.Click += insert_button_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(69, 181);
            label2.Name = "label2";
            label2.Size = new Size(28, 25);
            label2.TabIndex = 24;
            label2.Text = "Id";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 226);
            label8.Name = "label8";
            label8.Size = new Size(128, 25);
            label8.TabIndex = 25;
            label8.Text = "Department Id";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(55, 280);
            label9.Name = "label9";
            label9.Size = new Size(54, 25);
            label9.TabIndex = 26;
            label9.Text = "Email";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(55, 335);
            label10.Name = "label10";
            label10.Size = new Size(59, 25);
            label10.TabIndex = 27;
            label10.Text = "Name";
            // 
            // checkBoxIsManager
            // 
            checkBoxIsManager.AutoSize = true;
            checkBoxIsManager.Location = new Point(530, 285);
            checkBoxIsManager.Name = "checkBoxIsManager";
            checkBoxIsManager.Size = new Size(108, 29);
            checkBoxIsManager.TabIndex = 28;
            checkBoxIsManager.Text = "Manager";
            checkBoxIsManager.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            ClientSize = new Size(800, 450);
            Controls.Add(checkBoxIsManager);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label2);
            Controls.Add(insert_button);
            Controls.Add(textBoxUpdatedName);
            Controls.Add(textBoxUpdatedEmail);
            Controls.Add(textBoxUpdatedDepartmentId);
            Controls.Add(textBoxUpdateId);
            Controls.Add(label7);
            Controls.Add(textBoxDeleteId);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxName);
            Controls.Add(textBoxDepartmentId);
            Controls.Add(update_button);
            Controls.Add(delete_button);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ComboBox comboBox1;
        private Label label1;
        private Button delete_button;
        private Button update_button;
        private TextBox textBoxDepartmentId;
        private TextBox textBoxName;
        private TextBox textBoxEmail;
        private Label label3;
        private Label label4;
        private Label label6;
        private TextBox textBoxDeleteId;
        private Label label7;
        private TextBox textBoxUpdateId;
        private TextBox textBoxUpdatedDepartmentId;
        private TextBox textBoxUpdatedEmail;
        private TextBox textBoxUpdatedName;
        private Button insert_button;
        private Label label2;
        private Label label8;
        private Label label9;
        private Label label10;
        private CheckBox checkBoxIsManager;
    }
}