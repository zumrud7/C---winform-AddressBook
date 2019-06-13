using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AddressBook.Models;

namespace AddressBook.Forms
{
   
    public partial class Companies : Form
    {

        private CompanyContactListEntities _context;

        private Company _selectedCompany;

        public Companies()
        {
            this._context = new CompanyContactListEntities();
            
            InitializeComponent();
            FillCompanies();
        }

       private void FillCompanies()
        {
            DgvCompanyList.Rows.Clear();
            foreach(Company item in _context.Companies.ToList())
            {
                DgvCompanyList.Rows.Add(item.Id, item.Name);
            }
        }

        private bool Validation()
        {
            ResetForm();
            
            if (string.IsNullOrEmpty(TxtCompName.Text))
            {
                LblCompName.ForeColor = Color.Red;
                return false;
            }
            return true;
        }

        private void ResetForm()
        {
            BtnAdd.Visible = true;
            BtnDelete.Visible = false;
            BtnUpdate.Visible = false;

            LblCompName.ForeColor = SystemColors.ControlText;
            
        }

        private void EmptyText()
        {
            TxtCompName.Text = string.Empty;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Validation();

            Company comp = new Company();

            comp.Name = TxtCompName.Text;

            _context.Companies.Add(comp);
            _context.SaveChanges();

            FillCompanies();
            ResetForm();
            EmptyText();

        }

        
        private void DgvCompanyList_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            BtnUpdate.Visible = true;
            BtnDelete.Visible = true;
            BtnAdd.Visible = false;

            int Id = Convert.ToInt32(DgvCompanyList.Rows[e.RowIndex].Cells[0].Value.ToString());
            this._selectedCompany = _context.Companies.Find(Id);

            TxtCompName.Text = this._selectedCompany.Name;
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (!Validation())
            {
                return;
            }
            this._selectedCompany.Name = TxtCompName.Text;
            _context.SaveChanges();

            ResetForm();
            FillCompanies();
            EmptyText();
            MessageBox.Show("Company name is successfully updated.", "Update");
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Are you sure to remove selected company from the list?", "Delete", MessageBoxButtons.YesNo);

            if(r == DialogResult.Yes)
            {
                _context.Companies.Remove(this._selectedCompany);
                _context.SaveChanges();

                ResetForm();
                FillCompanies();
                EmptyText();
                MessageBox.Show("Selected company is successfully Deleted!", "Delete");
            }
        }

        
    }
}
