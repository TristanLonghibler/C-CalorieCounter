namespace team_project
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
            this.components = new System.ComponentModel.Container();
            this.comboBoxUser = new System.Windows.Forms.ComboBox();
            this.labelUser = new System.Windows.Forms.Label();
            this.textBoxBMI = new System.Windows.Forms.TextBox();
            this.labelHeight = new System.Windows.Forms.Label();
            this.labelBMI = new System.Windows.Forms.Label();
            this.labelWeight = new System.Windows.Forms.Label();
            this.textBoxWeight = new System.Windows.Forms.TextBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonNew = new System.Windows.Forms.Button();
            this.textBoxHeightInches = new System.Windows.Forms.TextBox();
            this.textBoxHeightFeet = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelUserError = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.comboBoxFoodEntry = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.foodEaten = new System.Windows.Forms.TextBox();
            this.newfoodbutton = new System.Windows.Forms.Button();
            this.updatefood = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.calCount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxFoodEntry = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.form1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.form1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.Calories = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxUser
            // 
            this.comboBoxUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUser.FormattingEnabled = true;
            this.comboBoxUser.Items.AddRange(new object[] {
            "--Select--",
            "a"});
            this.comboBoxUser.Location = new System.Drawing.Point(117, 29);
            this.comboBoxUser.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.comboBoxUser.Name = "comboBoxUser";
            this.comboBoxUser.Size = new System.Drawing.Size(300, 39);
            this.comboBoxUser.TabIndex = 0;
            this.comboBoxUser.SelectedIndexChanged += new System.EventHandler(this.comboBoxUser_SelectedIndexChanged);
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Location = new System.Drawing.Point(16, 31);
            this.labelUser.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(72, 31);
            this.labelUser.TabIndex = 1;
            this.labelUser.Text = "User";
            // 
            // textBoxBMI
            // 
            this.textBoxBMI.Location = new System.Drawing.Point(1043, 246);
            this.textBoxBMI.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.textBoxBMI.Name = "textBoxBMI";
            this.textBoxBMI.ReadOnly = true;
            this.textBoxBMI.Size = new System.Drawing.Size(207, 38);
            this.textBoxBMI.TabIndex = 4;
            this.textBoxBMI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.Location = new System.Drawing.Point(419, 212);
            this.labelHeight.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(93, 31);
            this.labelHeight.TabIndex = 7;
            this.labelHeight.Text = "Height";
            // 
            // labelBMI
            // 
            this.labelBMI.AutoSize = true;
            this.labelBMI.Location = new System.Drawing.Point(1117, 212);
            this.labelBMI.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelBMI.Name = "labelBMI";
            this.labelBMI.Size = new System.Drawing.Size(62, 31);
            this.labelBMI.TabIndex = 8;
            this.labelBMI.Text = "BMI";
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Location = new System.Drawing.Point(736, 212);
            this.labelWeight.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(98, 31);
            this.labelWeight.TabIndex = 10;
            this.labelWeight.Text = "Weight";
            // 
            // textBoxWeight
            // 
            this.textBoxWeight.Location = new System.Drawing.Point(685, 246);
            this.textBoxWeight.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.Size = new System.Drawing.Size(207, 38);
            this.textBoxWeight.TabIndex = 9;
            this.textBoxWeight.Text = "lbs";
            this.textBoxWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxWeight.Enter += new System.EventHandler(this.textBoxWeight_Enter);
            this.textBoxWeight.Leave += new System.EventHandler(this.textBoxWeight_Leave);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(477, 348);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(147, 45);
            this.buttonUpdate.TabIndex = 11;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonNew
            // 
            this.buttonNew.Location = new System.Drawing.Point(637, 348);
            this.buttonNew.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(147, 45);
            this.buttonNew.TabIndex = 12;
            this.buttonNew.Text = "New";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // textBoxHeightInches
            // 
            this.textBoxHeightInches.Location = new System.Drawing.Point(477, 246);
            this.textBoxHeightInches.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.textBoxHeightInches.Name = "textBoxHeightInches";
            this.textBoxHeightInches.Size = new System.Drawing.Size(97, 38);
            this.textBoxHeightInches.TabIndex = 13;
            this.textBoxHeightInches.Text = "in";
            this.textBoxHeightInches.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxHeightInches.Enter += new System.EventHandler(this.textBoxHeightInches_Enter);
            this.textBoxHeightInches.Leave += new System.EventHandler(this.textBoxHeightInches_Leave);
            // 
            // textBoxHeightFeet
            // 
            this.textBoxHeightFeet.Location = new System.Drawing.Point(357, 246);
            this.textBoxHeightFeet.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.textBoxHeightFeet.Name = "textBoxHeightFeet";
            this.textBoxHeightFeet.Size = new System.Drawing.Size(97, 38);
            this.textBoxHeightFeet.TabIndex = 14;
            this.textBoxHeightFeet.Text = "ft";
            this.textBoxHeightFeet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxHeightFeet.Enter += new System.EventHandler(this.textBoxHeightFeet_Enter);
            this.textBoxHeightFeet.Leave += new System.EventHandler(this.textBoxHeightFeet_Leave);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(91, 212);
            this.labelName.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(86, 31);
            this.labelName.TabIndex = 16;
            this.labelName.Text = "Name";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(40, 246);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(207, 38);
            this.textBoxName.TabIndex = 15;
            this.textBoxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // labelUserError
            // 
            this.labelUserError.AutoSize = true;
            this.labelUserError.Location = new System.Drawing.Point(552, 310);
            this.labelUserError.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelUserError.Name = "labelUserError";
            this.labelUserError.Size = new System.Drawing.Size(0, 31);
            this.labelUserError.TabIndex = 17;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(11, 95);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(2096, 966);
            this.tabControl1.TabIndex = 18;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_TabIndexChanged);
            this.tabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_Selecting);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.labelUserError);
            this.tabPage1.Controls.Add(this.labelName);
            this.tabPage1.Controls.Add(this.textBoxBMI);
            this.tabPage1.Controls.Add(this.textBoxName);
            this.tabPage1.Controls.Add(this.labelHeight);
            this.tabPage1.Controls.Add(this.textBoxHeightFeet);
            this.tabPage1.Controls.Add(this.labelBMI);
            this.tabPage1.Controls.Add(this.textBoxHeightInches);
            this.tabPage1.Controls.Add(this.textBoxWeight);
            this.tabPage1.Controls.Add(this.buttonNew);
            this.tabPage1.Controls.Add(this.labelWeight);
            this.tabPage1.Controls.Add(this.buttonUpdate);
            this.tabPage1.Location = new System.Drawing.Point(8, 45);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(2080, 913);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "User Settings";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.comboBoxFoodEntry);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.dateTimePicker1);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.foodEaten);
            this.tabPage2.Controls.Add(this.newfoodbutton);
            this.tabPage2.Controls.Add(this.updatefood);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.calCount);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.textBoxFoodEntry);
            this.tabPage2.Location = new System.Drawing.Point(8, 45);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(2080, 913);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Food Entry";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // comboBoxFoodEntry
            // 
            this.comboBoxFoodEntry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFoodEntry.FormattingEnabled = true;
            this.comboBoxFoodEntry.Location = new System.Drawing.Point(37, 348);
            this.comboBoxFoodEntry.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.comboBoxFoodEntry.Name = "comboBoxFoodEntry";
            this.comboBoxFoodEntry.Size = new System.Drawing.Size(295, 39);
            this.comboBoxFoodEntry.TabIndex = 18;
            this.comboBoxFoodEntry.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1397, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 31);
            this.label4.TabIndex = 17;
            this.label4.Text = "Time Eaten";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(1389, 262);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(652, 38);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(979, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 31);
            this.label3.TabIndex = 15;
            this.label3.Text = "Amount Eaten";
            // 
            // foodEaten
            // 
            this.foodEaten.Location = new System.Drawing.Point(944, 258);
            this.foodEaten.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.foodEaten.Name = "foodEaten";
            this.foodEaten.Size = new System.Drawing.Size(295, 38);
            this.foodEaten.TabIndex = 14;
            // 
            // newfoodbutton
            // 
            this.newfoodbutton.Location = new System.Drawing.Point(949, 348);
            this.newfoodbutton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.newfoodbutton.Name = "newfoodbutton";
            this.newfoodbutton.Size = new System.Drawing.Size(147, 45);
            this.newfoodbutton.TabIndex = 13;
            this.newfoodbutton.Text = "New";
            this.newfoodbutton.UseVisualStyleBackColor = true;
            this.newfoodbutton.Click += new System.EventHandler(this.newfoodbutton_Click);
            // 
            // updatefood
            // 
            this.updatefood.Location = new System.Drawing.Point(653, 348);
            this.updatefood.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.updatefood.Name = "updatefood";
            this.updatefood.Size = new System.Drawing.Size(147, 45);
            this.updatefood.TabIndex = 12;
            this.updatefood.Text = "Update";
            this.updatefood.UseVisualStyleBackColor = true;
            this.updatefood.Click += new System.EventHandler(this.updatefood_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(581, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Calories Of Food";
            // 
            // calCount
            // 
            this.calCount.Location = new System.Drawing.Point(539, 267);
            this.calCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.calCount.Name = "calCount";
            this.calCount.Size = new System.Drawing.Size(295, 38);
            this.calCount.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Food Entry";
            // 
            // textBoxFoodEntry
            // 
            this.textBoxFoodEntry.Location = new System.Drawing.Point(37, 267);
            this.textBoxFoodEntry.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxFoodEntry.Name = "textBoxFoodEntry";
            this.textBoxFoodEntry.Size = new System.Drawing.Size(295, 38);
            this.textBoxFoodEntry.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView1);
            this.tabPage3.Location = new System.Drawing.Point(8, 45);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(2080, 913);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Weekly Summary";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Calories});
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.Size = new System.Drawing.Size(2074, 907);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // form1BindingSource
            // 
            this.form1BindingSource.DataSource = typeof(team_project.Form1);
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(team_project.User);
            // 
            // form1BindingSource1
            // 
            this.form1BindingSource1.DataSource = typeof(team_project.Form1);
            // 
            // Calories
            // 
            this.Calories.HeaderText = "Calories";
            this.Calories.MinimumWidth = 10;
            this.Calories.Name = "Calories";
            this.Calories.Width = 200;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2133, 1073);
            this.Controls.Add(this.comboBoxUser);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.labelUser);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxUser;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.TextBox textBoxBMI;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.Label labelBMI;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.TextBox textBoxWeight;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.TextBox textBoxHeightInches;
        private System.Windows.Forms.TextBox textBoxHeightFeet;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelUserError;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox calCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxFoodEntry;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.BindingSource form1BindingSource;
        private System.Windows.Forms.BindingSource form1BindingSource1;
        private System.Windows.Forms.Button newfoodbutton;
        private System.Windows.Forms.Button updatefood;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox foodEaten;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBoxFoodEntry;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Calories;
    }
}

