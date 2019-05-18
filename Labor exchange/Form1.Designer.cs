namespace Labor_exchange
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.system = new System.Windows.Forms.TabControl();
            this.Unemployed = new System.Windows.Forms.TabPage();
            this.Jobs = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.p_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Person_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Person_surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Profession = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Education = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Last_work_place = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Last_work_position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reason_of_firing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marital_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Living_conditions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telephone_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Requirements = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.To_archive_1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Print = new System.Windows.Forms.DataGridViewButtonColumn();
            this.c_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Company = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Working_conditions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Payment_conditions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Living_conditions_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Company_requirements = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.To_archive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Delete_1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Print_1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.system.SuspendLayout();
            this.Unemployed.SuspendLayout();
            this.Jobs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // system
            // 
            this.system.Controls.Add(this.Unemployed);
            this.system.Controls.Add(this.Jobs);
            this.system.Location = new System.Drawing.Point(0, 2);
            this.system.Name = "system";
            this.system.SelectedIndex = 0;
            this.system.Size = new System.Drawing.Size(1281, 483);
            this.system.TabIndex = 0;
            // 
            // Unemployed
            // 
            this.Unemployed.Controls.Add(this.button7);
            this.Unemployed.Controls.Add(this.button3);
            this.Unemployed.Controls.Add(this.button5);
            this.Unemployed.Controls.Add(this.dataGridView1);
            this.Unemployed.Controls.Add(this.button1);
            this.Unemployed.Location = new System.Drawing.Point(4, 22);
            this.Unemployed.Name = "Unemployed";
            this.Unemployed.Padding = new System.Windows.Forms.Padding(3);
            this.Unemployed.Size = new System.Drawing.Size(1273, 457);
            this.Unemployed.TabIndex = 0;
            this.Unemployed.Text = "Unemployed";
            this.Unemployed.UseVisualStyleBackColor = true;
            // 
            // Jobs
            // 
            this.Jobs.Controls.Add(this.button8);
            this.Jobs.Controls.Add(this.button6);
            this.Jobs.Controls.Add(this.button4);
            this.Jobs.Controls.Add(this.dataGridView2);
            this.Jobs.Controls.Add(this.button2);
            this.Jobs.Location = new System.Drawing.Point(4, 22);
            this.Jobs.Name = "Jobs";
            this.Jobs.Padding = new System.Windows.Forms.Padding(3);
            this.Jobs.Size = new System.Drawing.Size(1273, 457);
            this.Jobs.TabIndex = 1;
            this.Jobs.Text = "Jobs";
            this.Jobs.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.p_id,
            this.Person_name,
            this.Person_surname,
            this.Profession,
            this.Education,
            this.Last_work_place,
            this.Last_work_position,
            this.Reason_of_firing,
            this.Marital_status,
            this.Living_conditions,
            this.Telephone_number,
            this.Email,
            this.Requirements,
            this.To_archive_1,
            this.Delete,
            this.Print});
            this.dataGridView1.Location = new System.Drawing.Point(1, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1272, 424);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellValueChanged);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.c_id,
            this.Company,
            this.Position,
            this.Working_conditions,
            this.Payment_conditions,
            this.Living_conditions_1,
            this.Company_requirements,
            this.To_archive,
            this.Delete_1,
            this.Print_1});
            this.dataGridView2.Location = new System.Drawing.Point(1, 32);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(1272, 424);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView2_CellClick);
            this.dataGridView2.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView2_CellValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1194, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add person";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1194, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Add job";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1027, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Show archive";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1113, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Search";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1113, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 2;
            this.button5.Text = "Search";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(1027, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(80, 23);
            this.button6.TabIndex = 4;
            this.button6.Text = "Show archive";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(3, 3);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(108, 23);
            this.button7.TabIndex = 4;
            this.button7.Text = "Refresh view";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(3, 3);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(111, 23);
            this.button8.TabIndex = 5;
            this.button8.Text = "Refresh view";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.Button8_Click);
            // 
            // p_id
            // 
            this.p_id.HeaderText = "p_id";
            this.p_id.Name = "p_id";
            // 
            // Person_name
            // 
            this.Person_name.HeaderText = "Name";
            this.Person_name.Name = "Person_name";
            // 
            // Person_surname
            // 
            this.Person_surname.HeaderText = "Surname";
            this.Person_surname.Name = "Person_surname";
            // 
            // Profession
            // 
            this.Profession.HeaderText = "Profession";
            this.Profession.Name = "Profession";
            // 
            // Education
            // 
            this.Education.HeaderText = "Education";
            this.Education.Name = "Education";
            // 
            // Last_work_place
            // 
            this.Last_work_place.HeaderText = "Last_work_place";
            this.Last_work_place.Name = "Last_work_place";
            // 
            // Last_work_position
            // 
            this.Last_work_position.HeaderText = "Last_work_position";
            this.Last_work_position.Name = "Last_work_position";
            // 
            // Reason_of_firing
            // 
            this.Reason_of_firing.HeaderText = "Reason_of_firing";
            this.Reason_of_firing.Name = "Reason_of_firing";
            // 
            // Marital_status
            // 
            this.Marital_status.HeaderText = "Marital_status";
            this.Marital_status.Name = "Marital_status";
            // 
            // Living_conditions
            // 
            this.Living_conditions.HeaderText = "Living_conditions";
            this.Living_conditions.Name = "Living_conditions";
            // 
            // Telephone_number
            // 
            this.Telephone_number.HeaderText = "Telephone_number";
            this.Telephone_number.Name = "Telephone_number";
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // Requirements
            // 
            this.Requirements.HeaderText = "Requirements";
            this.Requirements.Name = "Requirements";
            // 
            // To_archive_1
            // 
            this.To_archive_1.HeaderText = "To_Archive";
            this.To_archive_1.Name = "To_archive_1";
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Print
            // 
            this.Print.HeaderText = "Print";
            this.Print.Name = "Print";
            // 
            // c_id
            // 
            this.c_id.HeaderText = "c_id";
            this.c_id.Name = "c_id";
            // 
            // Company
            // 
            this.Company.HeaderText = "Company";
            this.Company.Name = "Company";
            // 
            // Position
            // 
            this.Position.HeaderText = "Position";
            this.Position.Name = "Position";
            // 
            // Working_conditions
            // 
            this.Working_conditions.HeaderText = "Working_conditions";
            this.Working_conditions.Name = "Working_conditions";
            // 
            // Payment_conditions
            // 
            this.Payment_conditions.HeaderText = "Payment_conditions";
            this.Payment_conditions.Name = "Payment_conditions";
            // 
            // Living_conditions_1
            // 
            this.Living_conditions_1.HeaderText = "Living_conditions";
            this.Living_conditions_1.Name = "Living_conditions_1";
            // 
            // Company_requirements
            // 
            this.Company_requirements.HeaderText = "Company_requirements";
            this.Company_requirements.Name = "Company_requirements";
            // 
            // To_archive
            // 
            this.To_archive.HeaderText = "To_archive";
            this.To_archive.Name = "To_archive";
            // 
            // Delete_1
            // 
            this.Delete_1.HeaderText = "Delete";
            this.Delete_1.Name = "Delete_1";
            this.Delete_1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Print_1
            // 
            this.Print_1.HeaderText = "Print";
            this.Print_1.Name = "Print_1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1281, 483);
            this.Controls.Add(this.system);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Labor exchange";
            this.system.ResumeLayout(false);
            this.Unemployed.ResumeLayout(false);
            this.Jobs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl system;
        private System.Windows.Forms.TabPage Unemployed;
        private System.Windows.Forms.TabPage Jobs;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Person_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Person_surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Profession;
        private System.Windows.Forms.DataGridViewTextBoxColumn Education;
        private System.Windows.Forms.DataGridViewTextBoxColumn Last_work_place;
        private System.Windows.Forms.DataGridViewTextBoxColumn Last_work_position;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reason_of_firing;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marital_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Living_conditions;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telephone_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Requirements;
        private System.Windows.Forms.DataGridViewCheckBoxColumn To_archive_1;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DataGridViewButtonColumn Print;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Company;
        private System.Windows.Forms.DataGridViewTextBoxColumn Position;
        private System.Windows.Forms.DataGridViewTextBoxColumn Working_conditions;
        private System.Windows.Forms.DataGridViewTextBoxColumn Payment_conditions;
        private System.Windows.Forms.DataGridViewTextBoxColumn Living_conditions_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Company_requirements;
        private System.Windows.Forms.DataGridViewCheckBoxColumn To_archive;
        private System.Windows.Forms.DataGridViewButtonColumn Delete_1;
        private System.Windows.Forms.DataGridViewButtonColumn Print_1;
    }
}

