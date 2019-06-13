namespace AddressBook.Forms
{
    partial class People
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtWorkNumber = new System.Windows.Forms.TextBox();
            this.TxtPhoneNumber = new System.Windows.Forms.TextBox();
            this.TxtFullName = new System.Windows.Forms.TextBox();
            this.CmbCompanyList = new System.Windows.Forms.ComboBox();
            this.LblCompanyList = new System.Windows.Forms.Label();
            this.LblEmail = new System.Windows.Forms.Label();
            this.LblWorkNumber = new System.Windows.Forms.Label();
            this.LblPhoneNumber = new System.Windows.Forms.Label();
            this.LblFullName = new System.Windows.Forms.Label();
            this.DgvPeopleList = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPeopleList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnDelete);
            this.panel1.Controls.Add(this.BtnUpdate);
            this.panel1.Controls.Add(this.BtnAdd);
            this.panel1.Controls.Add(this.TxtEmail);
            this.panel1.Controls.Add(this.TxtWorkNumber);
            this.panel1.Controls.Add(this.TxtPhoneNumber);
            this.panel1.Controls.Add(this.TxtFullName);
            this.panel1.Controls.Add(this.CmbCompanyList);
            this.panel1.Controls.Add(this.LblCompanyList);
            this.panel1.Controls.Add(this.LblEmail);
            this.panel1.Controls.Add(this.LblWorkNumber);
            this.panel1.Controls.Add(this.LblPhoneNumber);
            this.panel1.Controls.Add(this.LblFullName);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 470);
            this.panel1.TabIndex = 0;
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.DarkKhaki;
            this.BtnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnAdd.Location = new System.Drawing.Point(153, 409);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(97, 41);
            this.BtnAdd.TabIndex = 10;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(18, 281);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(232, 26);
            this.TxtEmail.TabIndex = 9;
            // 
            // TxtWorkNumber
            // 
            this.TxtWorkNumber.Location = new System.Drawing.Point(18, 215);
            this.TxtWorkNumber.Name = "TxtWorkNumber";
            this.TxtWorkNumber.Size = new System.Drawing.Size(232, 26);
            this.TxtWorkNumber.TabIndex = 8;
            // 
            // TxtPhoneNumber
            // 
            this.TxtPhoneNumber.Location = new System.Drawing.Point(18, 141);
            this.TxtPhoneNumber.Name = "TxtPhoneNumber";
            this.TxtPhoneNumber.Size = new System.Drawing.Size(232, 26);
            this.TxtPhoneNumber.TabIndex = 7;
            // 
            // TxtFullName
            // 
            this.TxtFullName.Location = new System.Drawing.Point(18, 64);
            this.TxtFullName.Name = "TxtFullName";
            this.TxtFullName.Size = new System.Drawing.Size(232, 26);
            this.TxtFullName.TabIndex = 6;
            // 
            // CmbCompanyList
            // 
            this.CmbCompanyList.FormattingEnabled = true;
            this.CmbCompanyList.Location = new System.Drawing.Point(18, 347);
            this.CmbCompanyList.Name = "CmbCompanyList";
            this.CmbCompanyList.Size = new System.Drawing.Size(232, 28);
            this.CmbCompanyList.TabIndex = 5;
            // 
            // LblCompanyList
            // 
            this.LblCompanyList.AutoSize = true;
            this.LblCompanyList.Location = new System.Drawing.Point(14, 324);
            this.LblCompanyList.Name = "LblCompanyList";
            this.LblCompanyList.Size = new System.Drawing.Size(95, 20);
            this.LblCompanyList.TabIndex = 4;
            this.LblCompanyList.Text = "Companies*";
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Location = new System.Drawing.Point(14, 258);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(54, 20);
            this.LblEmail.TabIndex = 3;
            this.LblEmail.Text = "Email*";
            // 
            // LblWorkNumber
            // 
            this.LblWorkNumber.AutoSize = true;
            this.LblWorkNumber.Location = new System.Drawing.Point(14, 192);
            this.LblWorkNumber.Name = "LblWorkNumber";
            this.LblWorkNumber.Size = new System.Drawing.Size(106, 20);
            this.LblWorkNumber.TabIndex = 2;
            this.LblWorkNumber.Text = "Work Number";
            // 
            // LblPhoneNumber
            // 
            this.LblPhoneNumber.AutoSize = true;
            this.LblPhoneNumber.Location = new System.Drawing.Point(14, 118);
            this.LblPhoneNumber.Name = "LblPhoneNumber";
            this.LblPhoneNumber.Size = new System.Drawing.Size(121, 20);
            this.LblPhoneNumber.TabIndex = 1;
            this.LblPhoneNumber.Text = "Phone Number*";
            // 
            // LblFullName
            // 
            this.LblFullName.AutoSize = true;
            this.LblFullName.Location = new System.Drawing.Point(14, 41);
            this.LblFullName.Name = "LblFullName";
            this.LblFullName.Size = new System.Drawing.Size(86, 20);
            this.LblFullName.TabIndex = 0;
            this.LblFullName.Text = "Full Name*";
            // 
            // DgvPeopleList
            // 
            this.DgvPeopleList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.DgvPeopleList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPeopleList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.DgvPeopleList.Location = new System.Drawing.Point(326, 31);
            this.DgvPeopleList.Name = "DgvPeopleList";
            this.DgvPeopleList.RowHeadersWidth = 62;
            this.DgvPeopleList.RowTemplate.Height = 28;
            this.DgvPeopleList.Size = new System.Drawing.Size(852, 452);
            this.DgvPeopleList.TabIndex = 1;
            this.DgvPeopleList.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvPeopleList_RowHeaderMouseClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Full Name";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 107;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Phone Number";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.Width = 139;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Work Number";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.Width = 131;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Email";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.Width = 84;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Company Id";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            this.Column6.Visible = false;
            this.Column6.Width = 150;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Company";
            this.Column7.MinimumWidth = 8;
            this.Column7.Name = "Column7";
            this.Column7.Width = 112;
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.BackColor = System.Drawing.Color.Gold;
            this.BtnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUpdate.Location = new System.Drawing.Point(153, 409);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(97, 41);
            this.BtnUpdate.TabIndex = 11;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = false;
            this.BtnUpdate.Visible = false;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.Red;
            this.BtnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnDelete.Location = new System.Drawing.Point(18, 409);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(97, 41);
            this.BtnDelete.TabIndex = 12;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Visible = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // People
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 513);
            this.Controls.Add(this.DgvPeopleList);
            this.Controls.Add(this.panel1);
            this.Name = "People";
            this.Text = "People";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPeopleList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.TextBox TxtWorkNumber;
        private System.Windows.Forms.TextBox TxtPhoneNumber;
        private System.Windows.Forms.TextBox TxtFullName;
        private System.Windows.Forms.ComboBox CmbCompanyList;
        private System.Windows.Forms.Label LblCompanyList;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.Label LblWorkNumber;
        private System.Windows.Forms.Label LblPhoneNumber;
        private System.Windows.Forms.Label LblFullName;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.DataGridView DgvPeopleList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnUpdate;
    }
}