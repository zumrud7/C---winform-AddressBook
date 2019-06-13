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
    public partial class People : Form
    {
        private CompanyContactListEntities _context;

        private Person SelectedPerson;

        public People()
        {
            this._context = new CompanyContactListEntities();

            InitializeComponent();

            FillCompanies();
            FillPeople();


        }

        private void FillCompanies()
        {
            

            foreach (Company item in _context.Companies.ToList())
            {
                CmbCompanyList.Items.Add(item.Name);
            }

        }

        private void FillPeople()
        {
            DgvPeopleList.Rows.Clear();

            foreach (Person item in _context.People.ToList())
            {
                DgvPeopleList.Rows.Add(item.Id,
                                        item.FullName,
                                        item.PhoneNumber,
                                        item.WorkNumber,
                                        item.Email,
                                        item.CompanyId,
                                        item.Company.Name);
            };
        }

        private bool Validation()
        {
            ResetForm();
            if (string.IsNullOrEmpty(TxtFullName.Text))
            {
                LblFullName.ForeColor = Color.Red;
                return false;
            }

            if (string.IsNullOrEmpty(TxtPhoneNumber.Text))
            {
                LblPhoneNumber.ForeColor = Color.Red;
                return false;
            }
            if (string.IsNullOrEmpty(TxtEmail.Text))
            {
                LblEmail.ForeColor = Color.Red;
                return false;
            }
            if (string.IsNullOrEmpty(CmbCompanyList.Text))
            {
                LblCompanyList.ForeColor = Color.Red;
                return false;
            }
            
            return true;
            
        }

        private void ResetForm()
        {
            BtnDelete.Visible = false;
            BtnUpdate.Visible = false;
            BtnAdd.Visible = true;

            LblFullName.ForeColor = SystemColors.ControlText;
            LblPhoneNumber.ForeColor = SystemColors.ControlText;
            LblEmail.ForeColor = SystemColors.ControlText;
            LblCompanyList.ForeColor = SystemColors.ControlText;
        }

        private void EmptyText()
        {
            TxtFullName.Text = string.Empty;
            TxtPhoneNumber.Text = string.Empty;
            TxtWorkNumber.Text = string.Empty;
            TxtEmail.Text = string.Empty;
            CmbCompanyList.Text = string.Empty;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Validation();
     

            Person prs = new Person();

            prs.FullName = TxtFullName.Text;
            prs.PhoneNumber = TxtPhoneNumber.Text;
            prs.WorkNumber = TxtWorkNumber.Text;
            prs.Email = TxtEmail.Text;
            prs.CompanyId = _context.Companies.FirstOrDefault(c => c.Name == CmbCompanyList.Text).Id;

            
            _context.People.Add(prs);
            _context.SaveChanges();

            FillPeople();
            ResetForm();
            EmptyText();
        }

        private void DgvPeopleList_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            BtnDelete.Visible = true;
            BtnUpdate.Visible = true;
            BtnAdd.Visible = false;

            int Id = Convert.ToInt32(DgvPeopleList.Rows[e.RowIndex].Cells[0].Value.ToString());

            this.SelectedPerson = _context.People.Find(Id);

            TxtFullName.Text = this.SelectedPerson.FullName;
            TxtPhoneNumber.Text = this.SelectedPerson.PhoneNumber;
            TxtWorkNumber.Text = this.SelectedPerson.WorkNumber;
            TxtEmail.Text = this.SelectedPerson.Email;
            CmbCompanyList.Text = this.SelectedPerson.Company.Name;
           
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            
            if (!Validation())
            {
                return;
            }

            this.SelectedPerson.FullName = TxtFullName.Text;
            this.SelectedPerson.PhoneNumber = TxtPhoneNumber.Text;
            this.SelectedPerson.WorkNumber = TxtWorkNumber.Text;
            this.SelectedPerson.Email = TxtEmail.Text;
            this.SelectedPerson.Company.Name = CmbCompanyList.Text;

            _context.SaveChanges();
            EmptyText();
            ResetForm();
            FillPeople();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Are you sure to remove selected person from the list?", "Delete", MessageBoxButtons.YesNo);

            if(r == DialogResult.Yes)
            {

                _context.People.Remove(this.SelectedPerson);

                _context.SaveChanges();

                ResetForm();
                EmptyText();
                FillPeople();
                MessageBox.Show("Selected person is successfully deleted.", "Done!");
            }
        }
    }
}
