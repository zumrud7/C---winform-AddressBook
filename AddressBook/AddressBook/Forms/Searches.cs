using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AddressBook.Forms;
using AddressBook.Models;


namespace AddressBook.Forms
{
    public partial class Searches : Form
    {

        private CompanyContactListEntities _context;
        public Searches()
        {
            this._context = new CompanyContactListEntities();

            InitializeComponent();
            FillPeople();
        }

        private void FillPeople()
        {
            DgvSearchList.Rows.Clear();

            foreach(Person item in _context.People.ToList())
            {
                DgvSearchList.Rows.Add(item.Id,
                                        item.FullName,
                                        item.PhoneNumber,
                                        item.WorkNumber,
                                        item.Email,
                                        item.CompanyId,
                                        item.Company.Name);
            }
            
        }

        
    }
}
