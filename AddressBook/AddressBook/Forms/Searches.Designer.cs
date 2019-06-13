namespace AddressBook.Forms
{
    partial class Searches
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
            this.LblFullName = new System.Windows.Forms.Label();
            this.LblPhoneNo = new System.Windows.Forms.Label();
            this.TxtFullName = new System.Windows.Forms.TextBox();
            this.TxtPhoneNo = new System.Windows.Forms.TextBox();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.DgvSearchList = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LblTitle = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSearchList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnSearch);
            this.panel1.Controls.Add(this.TxtPhoneNo);
            this.panel1.Controls.Add(this.TxtFullName);
            this.panel1.Controls.Add(this.LblPhoneNo);
            this.panel1.Controls.Add(this.LblFullName);
            this.panel1.Location = new System.Drawing.Point(222, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(678, 115);
            this.panel1.TabIndex = 0;
            // 
            // LblFullName
            // 
            this.LblFullName.AutoSize = true;
            this.LblFullName.Location = new System.Drawing.Point(21, 45);
            this.LblFullName.Name = "LblFullName";
            this.LblFullName.Size = new System.Drawing.Size(80, 20);
            this.LblFullName.TabIndex = 0;
            this.LblFullName.Text = "Full Name";
            // 
            // LblPhoneNo
            // 
            this.LblPhoneNo.AutoSize = true;
            this.LblPhoneNo.Location = new System.Drawing.Point(256, 45);
            this.LblPhoneNo.Name = "LblPhoneNo";
            this.LblPhoneNo.Size = new System.Drawing.Size(115, 20);
            this.LblPhoneNo.TabIndex = 1;
            this.LblPhoneNo.Text = "Phone Number";
            // 
            // TxtFullName
            // 
            this.TxtFullName.Location = new System.Drawing.Point(25, 78);
            this.TxtFullName.Name = "TxtFullName";
            this.TxtFullName.Size = new System.Drawing.Size(177, 26);
            this.TxtFullName.TabIndex = 2;
            // 
            // TxtPhoneNo
            // 
            this.TxtPhoneNo.Location = new System.Drawing.Point(260, 78);
            this.TxtPhoneNo.Name = "TxtPhoneNo";
            this.TxtPhoneNo.Size = new System.Drawing.Size(177, 26);
            this.TxtPhoneNo.TabIndex = 3;
            // 
            // BtnSearch
            // 
            this.BtnSearch.BackColor = System.Drawing.Color.SkyBlue;
            this.BtnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnSearch.Location = new System.Drawing.Point(491, 66);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(142, 46);
            this.BtnSearch.TabIndex = 4;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = false;
            // 
            // DgvSearchList
            // 
            this.DgvSearchList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvSearchList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvSearchList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.DgvSearchList.Location = new System.Drawing.Point(12, 161);
            this.DgvSearchList.Name = "DgvSearchList";
            this.DgvSearchList.RowHeadersWidth = 62;
            this.DgvSearchList.RowTemplate.Height = 28;
            this.DgvSearchList.Size = new System.Drawing.Size(888, 289);
            this.DgvSearchList.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Full Name";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Phone Number";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Work Number";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Email";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "CompanyId";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            this.Column6.Visible = false;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Company";
            this.Column7.MinimumWidth = 8;
            this.Column7.Name = "Column7";
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.Location = new System.Drawing.Point(12, 62);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(188, 46);
            this.LblTitle.TabIndex = 2;
            this.LblTitle.Text = "SEARCH";
            // 
            // Searches
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 503);
            this.Controls.Add(this.LblTitle);
            this.Controls.Add(this.DgvSearchList);
            this.Controls.Add(this.panel1);
            this.Name = "Searches";
            this.Text = "Searches";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSearchList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.TextBox TxtPhoneNo;
        private System.Windows.Forms.TextBox TxtFullName;
        private System.Windows.Forms.Label LblPhoneNo;
        private System.Windows.Forms.Label LblFullName;
        private System.Windows.Forms.DataGridView DgvSearchList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Label LblTitle;
    }
}