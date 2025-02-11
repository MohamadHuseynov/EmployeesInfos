namespace EmployeeInfos
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
            txtCode = new TextBox();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            btnCountAll = new Button();
            btnCountFemale = new Button();
            btnCountMale = new Button();
            radiobtnFemale = new RadioButton();
            radiobtnMale = new RadioButton();
            lblCode = new Label();
            lblFirstName = new Label();
            lblLastName = new Label();
            dataGridViewFemale = new DataGridView();
            CodeFemale = new DataGridViewTextBoxColumn();
            FirstNameFemale = new DataGridViewTextBoxColumn();
            LastNameFemale = new DataGridViewTextBoxColumn();
            dataGridViewMale = new DataGridView();
            CodeMale = new DataGridViewTextBoxColumn();
            FirstNameMale = new DataGridViewTextBoxColumn();
            LastNameMale = new DataGridViewTextBoxColumn();
            btnSubmit = new Button();
            lblMale = new Label();
            lblFemale = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFemale).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMale).BeginInit();
            SuspendLayout();
            // 
            // txtCode
            // 
            txtCode.Location = new Point(172, 19);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(268, 39);
            txtCode.TabIndex = 0;
            txtCode.TextChanged += textBox1_TextChanged;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(172, 74);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(268, 39);
            txtFirstName.TabIndex = 1;
            txtFirstName.TextChanged += txtFirstName_TextChanged;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(172, 134);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(268, 39);
            txtLastName.TabIndex = 2;
            txtLastName.TextChanged += txtLastName_TextChanged;
            // 
            // btnCountAll
            // 
            btnCountAll.Location = new Point(610, 75);
            btnCountAll.Name = "btnCountAll";
            btnCountAll.Size = new Size(205, 46);
            btnCountAll.TabIndex = 5;
            btnCountAll.Text = "Count All";
            btnCountAll.UseVisualStyleBackColor = true;
            btnCountAll.Click += btnCountAll_Click;
            // 
            // btnCountFemale
            // 
            btnCountFemale.Location = new Point(610, 134);
            btnCountFemale.Name = "btnCountFemale";
            btnCountFemale.Size = new Size(205, 46);
            btnCountFemale.TabIndex = 6;
            btnCountFemale.Text = "Count Female";
            btnCountFemale.UseVisualStyleBackColor = true;
            btnCountFemale.Click += btnCountFemale_Click;
            // 
            // btnCountMale
            // 
            btnCountMale.Location = new Point(610, 191);
            btnCountMale.Name = "btnCountMale";
            btnCountMale.Size = new Size(205, 46);
            btnCountMale.TabIndex = 7;
            btnCountMale.Text = "Count Male";
            btnCountMale.UseVisualStyleBackColor = true;
            btnCountMale.Click += btnCountMale_Click;
            // 
            // radiobtnFemale
            // 
            radiobtnFemale.AutoSize = true;
            radiobtnFemale.Location = new Point(40, 201);
            radiobtnFemale.Name = "radiobtnFemale";
            radiobtnFemale.Size = new Size(122, 36);
            radiobtnFemale.TabIndex = 3;
            radiobtnFemale.TabStop = true;
            radiobtnFemale.Text = "Female";
            radiobtnFemale.UseVisualStyleBackColor = true;
            radiobtnFemale.CheckedChanged += radiobtnFemale_CheckedChanged;
            // 
            // radiobtnMale
            // 
            radiobtnMale.AutoSize = true;
            radiobtnMale.Location = new Point(342, 201);
            radiobtnMale.Name = "radiobtnMale";
            radiobtnMale.Size = new Size(98, 36);
            radiobtnMale.TabIndex = 3;
            radiobtnMale.TabStop = true;
            radiobtnMale.Text = "Male";
            radiobtnMale.UseVisualStyleBackColor = true;
            radiobtnMale.CheckedChanged += radiobtnMale_CheckedChanged;
            // 
            // lblCode
            // 
            lblCode.AutoSize = true;
            lblCode.Location = new Point(35, 26);
            lblCode.Name = "lblCode";
            lblCode.Size = new Size(75, 32);
            lblCode.TabIndex = 8;
            lblCode.Text = "Code:";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(35, 81);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(127, 32);
            lblFirstName.TabIndex = 9;
            lblFirstName.Text = "FirstName:";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(35, 141);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(124, 32);
            lblLastName.TabIndex = 10;
            lblLastName.Text = "LastName:";
            lblLastName.Click += label3_Click;
            // 
            // dataGridViewFemale
            // 
            dataGridViewFemale.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFemale.Columns.AddRange(new DataGridViewColumn[] { CodeFemale, FirstNameFemale, LastNameFemale });
            dataGridViewFemale.Location = new Point(40, 317);
            dataGridViewFemale.Name = "dataGridViewFemale";
            dataGridViewFemale.ReadOnly = true;
            dataGridViewFemale.RowHeadersWidth = 82;
            dataGridViewFemale.RowTemplate.ReadOnly = true;
            dataGridViewFemale.Size = new Size(480, 273);
            dataGridViewFemale.TabIndex = 11;
            dataGridViewFemale.TabStop = false;
            dataGridViewFemale.CellContentClick += dataGridView1_CellContentClick;
            // 
            // CodeFemale
            // 
            CodeFemale.HeaderText = "Code";
            CodeFemale.MinimumWidth = 10;
            CodeFemale.Name = "CodeFemale";
            CodeFemale.ReadOnly = true;
            CodeFemale.Width = 200;
            // 
            // FirstNameFemale
            // 
            FirstNameFemale.HeaderText = "First Name:";
            FirstNameFemale.MinimumWidth = 10;
            FirstNameFemale.Name = "FirstNameFemale";
            FirstNameFemale.ReadOnly = true;
            FirstNameFemale.Width = 200;
            // 
            // LastNameFemale
            // 
            LastNameFemale.HeaderText = "Last Name";
            LastNameFemale.MinimumWidth = 10;
            LastNameFemale.Name = "LastNameFemale";
            LastNameFemale.ReadOnly = true;
            LastNameFemale.Width = 200;
            // 
            // dataGridViewMale
            // 
            dataGridViewMale.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMale.Columns.AddRange(new DataGridViewColumn[] { CodeMale, FirstNameMale, LastNameMale });
            dataGridViewMale.Location = new Point(610, 317);
            dataGridViewMale.Name = "dataGridViewMale";
            dataGridViewMale.ReadOnly = true;
            dataGridViewMale.RowHeadersWidth = 82;
            dataGridViewMale.Size = new Size(482, 273);
            dataGridViewMale.TabIndex = 12;
            dataGridViewMale.TabStop = false;
            dataGridViewMale.CellContentClick += dataGridViewMale_CellContentClick;
            // 
            // CodeMale
            // 
            CodeMale.HeaderText = "Code";
            CodeMale.MinimumWidth = 10;
            CodeMale.Name = "CodeMale";
            CodeMale.ReadOnly = true;
            CodeMale.Width = 200;
            // 
            // FirstNameMale
            // 
            FirstNameMale.HeaderText = "First Name:";
            FirstNameMale.MinimumWidth = 10;
            FirstNameMale.Name = "FirstNameMale";
            FirstNameMale.ReadOnly = true;
            FirstNameMale.Width = 200;
            // 
            // LastNameMale
            // 
            LastNameMale.HeaderText = "Last Name:";
            LastNameMale.MinimumWidth = 10;
            LastNameMale.Name = "LastNameMale";
            LastNameMale.ReadOnly = true;
            LastNameMale.Width = 200;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(610, 14);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(205, 49);
            btnSubmit.TabIndex = 4;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // lblMale
            // 
            lblMale.AutoSize = true;
            lblMale.Location = new Point(610, 274);
            lblMale.Name = "lblMale";
            lblMale.Size = new Size(67, 32);
            lblMale.TabIndex = 13;
            lblMale.Text = "Male";
            // 
            // lblFemale
            // 
            lblFemale.AutoSize = true;
            lblFemale.Location = new Point(35, 274);
            lblFemale.Name = "lblFemale";
            lblFemale.Size = new Size(91, 32);
            lblFemale.TabIndex = 14;
            lblFemale.Text = "Female";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1288, 627);
            Controls.Add(lblFemale);
            Controls.Add(lblMale);
            Controls.Add(btnSubmit);
            Controls.Add(dataGridViewMale);
            Controls.Add(dataGridViewFemale);
            Controls.Add(lblLastName);
            Controls.Add(lblFirstName);
            Controls.Add(lblCode);
            Controls.Add(radiobtnMale);
            Controls.Add(radiobtnFemale);
            Controls.Add(btnCountMale);
            Controls.Add(btnCountFemale);
            Controls.Add(btnCountAll);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(txtCode);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridViewFemale).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMale).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCode;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private Button btnCountAll;
        private Button btnCountFemale;
        private Button btnCountMale;
        private RadioButton radiobtnFemale;
        private RadioButton radiobtnMale;
        private Label lblCode;
        private Label lblFirstName;
        private Label lblLastName;
        private DataGridView dataGridViewFemale;
        private DataGridView dataGridViewMale;
        private Button btnSubmit;
        private Label lblMale;
        private Label lblFemale;
        private DataGridViewTextBoxColumn Code;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn LastName;
        private DataGridViewTextBoxColumn CodeMale;
        private DataGridViewTextBoxColumn FirstNameMale;
        private DataGridViewTextBoxColumn LastNameMale;
        private DataGridViewTextBoxColumn CodeFemale;
        private DataGridViewTextBoxColumn FirstNameFemale;
        private DataGridViewTextBoxColumn LastNameFemale;
    }
}
