using PhoneBook.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneBook.WinForm
{

    public partial class UserControlContact : UserControl
    {

        public UserControlContact()
        {
            InitializeComponent();
        }

        private void UserControlContact_Load(object sender, EventArgs e)
        {
            if (Tag is ContactDto contactDto)
            {
                labelName.Text = contactDto.Name.ToUpper();
                labelPhone.Text = contactDto.PhoneNumber;
                labelAddress.Text = contactDto.Address;
            }
            else
            {
                labelName.Text = "";
                labelPhone.Text = "";
                labelAddress.Text = "";
            }
        }

        private void UserControlContact_Click(object sender, EventArgs e)
        {
            UpdateMainFormTextBox();
        }
        
        private void labelAddress_Click(object sender, EventArgs e)
        {
            UpdateMainFormTextBox();
        }

        private void labelPhone_Click(object sender, EventArgs e)
        {
            UpdateMainFormTextBox();

        }

        private void labelName_Click(object sender, EventArgs e)
        {
            UpdateMainFormTextBox();

        }

        private void UpdateMainFormTextBox()
        {
            if (ParentForm is MainForm mainForm && Tag is ContactDto contactDto)
            {
                //SelectedContactDto = contactDto;
                mainForm.DisplayTextBoxWithContactDto(contactDto);
            }
        }

    }
}
