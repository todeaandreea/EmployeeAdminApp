namespace WindowsForm
{
    partial class Form2
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
            label8 = new Label();
            label2 = new Label();
            insert_button = new Button();
            textBoxUpdatedManagerId = new TextBox();
            textBoxUpdatedDescription = new TextBox();
            textBoxUpdateId = new TextBox();
            label7 = new Label();
            textBoxDeleteId = new TextBox();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            textBoxDescription = new TextBox();
            textBoxParentId = new TextBox();
            textBoxManagerId = new TextBox();
            update_button = new Button();
            delete_button = new Button();
            label1 = new Label();
            load_button = new Button();
            label5 = new Label();
            label9 = new Label();
            textBoxUpdatedParentId = new TextBox();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 158);
            label8.Name = "label8";
            label8.Size = new Size(128, 25);
            label8.TabIndex = 44;
            label8.Text = "Department Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 209);
            label2.Name = "label2";
            label2.Size = new Size(102, 25);
            label2.TabIndex = 43;
            label2.Text = "Description";
            // 
            // insert_button
            // 
            insert_button.BackColor = Color.DarkSalmon;
            insert_button.Location = new Point(341, 312);
            insert_button.Name = "insert_button";
            insert_button.Size = new Size(213, 63);
            insert_button.TabIndex = 42;
            insert_button.Text = "Insert Department";
            insert_button.UseVisualStyleBackColor = false;
            insert_button.Click += insert_button_Click;
            // 
            // textBoxUpdatedManagerId
            // 
            textBoxUpdatedManagerId.Location = new Point(140, 254);
            textBoxUpdatedManagerId.Name = "textBoxUpdatedManagerId";
            textBoxUpdatedManagerId.Size = new Size(117, 31);
            textBoxUpdatedManagerId.TabIndex = 40;
            // 
            // textBoxUpdatedDescription
            // 
            textBoxUpdatedDescription.Location = new Point(140, 206);
            textBoxUpdatedDescription.Name = "textBoxUpdatedDescription";
            textBoxUpdatedDescription.Size = new Size(117, 31);
            textBoxUpdatedDescription.TabIndex = 39;
            // 
            // textBoxUpdateId
            // 
            textBoxUpdateId.Location = new Point(140, 155);
            textBoxUpdateId.Name = "textBoxUpdateId";
            textBoxUpdateId.Size = new Size(117, 31);
            textBoxUpdateId.TabIndex = 38;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(579, 164);
            label7.Name = "label7";
            label7.Size = new Size(28, 25);
            label7.TabIndex = 37;
            label7.Text = "Id";
            // 
            // textBoxDeleteId
            // 
            textBoxDeleteId.Location = new Point(633, 158);
            textBoxDeleteId.Name = "textBoxDeleteId";
            textBoxDeleteId.Size = new Size(117, 31);
            textBoxDeleteId.TabIndex = 36;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(285, 266);
            label6.Name = "label6";
            label6.Size = new Size(82, 25);
            label6.TabIndex = 35;
            label6.Text = "Parent Id";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(274, 212);
            label4.Name = "label4";
            label4.Size = new Size(102, 25);
            label4.TabIndex = 34;
            label4.Text = "Description";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(274, 158);
            label3.Name = "label3";
            label3.Size = new Size(103, 25);
            label3.TabIndex = 33;
            label3.Text = "Manager Id";
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(383, 206);
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(117, 31);
            textBoxDescription.TabIndex = 32;
            // 
            // textBoxParentId
            // 
            textBoxParentId.Location = new Point(383, 263);
            textBoxParentId.Name = "textBoxParentId";
            textBoxParentId.Size = new Size(117, 31);
            textBoxParentId.TabIndex = 31;
            // 
            // textBoxManagerId
            // 
            textBoxManagerId.Location = new Point(383, 155);
            textBoxManagerId.Name = "textBoxManagerId";
            textBoxManagerId.Size = new Size(117, 31);
            textBoxManagerId.TabIndex = 30;
            // 
            // update_button
            // 
            update_button.BackColor = Color.LightSalmon;
            update_button.Location = new Point(60, 359);
            update_button.Name = "update_button";
            update_button.Size = new Size(213, 59);
            update_button.TabIndex = 29;
            update_button.Text = "Update Department";
            update_button.UseVisualStyleBackColor = false;
            update_button.Click += update_button_Click;
            // 
            // delete_button
            // 
            delete_button.BackColor = Color.Salmon;
            delete_button.Location = new Point(579, 212);
            delete_button.Name = "delete_button";
            delete_button.Size = new Size(188, 61);
            delete_button.TabIndex = 28;
            delete_button.Text = "Delete Department";
            delete_button.UseVisualStyleBackColor = false;
            delete_button.Click += delete_button_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 39);
            label1.Name = "label1";
            label1.Size = new Size(115, 25);
            label1.TabIndex = 49;
            label1.Text = "Departments";
            // 
            // load_button
            // 
            load_button.Location = new Point(395, 34);
            load_button.Name = "load_button";
            load_button.Size = new Size(171, 34);
            load_button.TabIndex = 47;
            load_button.Text = "Load Departments";
            load_button.UseVisualStyleBackColor = true;
            load_button.Click += load_button_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 263);
            label5.Name = "label5";
            label5.Size = new Size(103, 25);
            label5.TabIndex = 50;
            label5.Text = "Manager Id";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(32, 315);
            label9.Name = "label9";
            label9.Size = new Size(82, 25);
            label9.TabIndex = 51;
            label9.Text = "Parent Id";
            // 
            // textBoxUpdatedParentId
            // 
            textBoxUpdatedParentId.Location = new Point(140, 315);
            textBoxUpdatedParentId.Name = "textBoxUpdatedParentId";
            textBoxUpdatedParentId.Size = new Size(117, 31);
            textBoxUpdatedParentId.TabIndex = 52;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(173, 39);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 53;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox1);
            Controls.Add(textBoxUpdatedParentId);
            Controls.Add(label9);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(load_button);
            Controls.Add(label8);
            Controls.Add(label2);
            Controls.Add(insert_button);
            Controls.Add(textBoxUpdatedManagerId);
            Controls.Add(textBoxUpdatedDescription);
            Controls.Add(textBoxUpdateId);
            Controls.Add(label7);
            Controls.Add(textBoxDeleteId);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBoxDescription);
            Controls.Add(textBoxParentId);
            Controls.Add(textBoxManagerId);
            Controls.Add(update_button);
            Controls.Add(delete_button);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label10;
        private Label label8;
        private Label label2;
        private Button insert_button;
        private TextBox textBoxUpdatedName;
        private TextBox textBoxUpdatedManagerId;
        private TextBox textBoxUpdatedDescription;
        private TextBox textBoxUpdateId;
        private Label label7;
        private TextBox textBoxDeleteId;
        private Label label6;
        private Label label4;
        private Label label3;
        private TextBox textBoxDescription;
        private TextBox textBoxParentId;
        private TextBox textBoxManagerId;
        private Button update_button;
        private Button delete_button;
        private Label label1;
        private Button load_button;
        private Label label5;
        private Label label9;
        private TextBox textBoxUpdatedParentId;
        private ComboBox comboBox1;
    }
}