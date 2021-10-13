using Microsoft.Extensions.DependencyInjection;
using PhoneBook.Core;
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
    public partial class MainForm : Form
    {
        private readonly IContactService _contactService;

        public ContactDto SelectedContactDto { get; set; }


        public MainForm()
        {
            _contactService = (IContactService)Program.ServiceProvider.GetService(typeof(IContactService));
            InitializeComponent();
        }

        #region Events

        private void MainForm_Load(object sender, EventArgs e)
        {
            ResetUI();
        }

        private void buttonCreateOrEdit_Click(object sender, EventArgs e)
        {
            var errorMessage = ValidateBuildContactDto();
            if (errorMessage.Any())
            {
                MessageBox.Show(errorMessage);
                return;
            }

            var contactDto = BuildContactDto();
            if (contactDto.Id == 0)
            {
                _contactService.Create(contactDto);
            }
            else
            {
                _contactService.Update(contactDto);
            }
            RefreshPanel();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (SelectedContactDto == null)
            {
                MessageBox.Show("No contact is selected. Please select a contact.");
            }
            else
            {
                _contactService.Delete(SelectedContactDto);
                RefreshPanel();
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            var contactDtos = _contactService.Search(textBoxSearch.Text.Trim());
            RefreshPanel(contactDtos);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            ResetUI();
        }
        #endregion

        private void ResetUI()
        {
            var contactDto = new ContactDto()
            {
                Name = "",
                PhoneNumber = "",
                Address = "",
            };
            DisplayTextBoxWithContactDto(contactDto);
            buttonCreateOrEdit.Text = "Create";
        }

        private string ValidateBuildContactDto()
        {
            return ValidateTextBox(new List<TextBox> { textBoxName, textBoxPhone, textBoxAddress });
        }

        private ContactDto BuildContactDto()
        {
            var contactDto = new ContactDto()
            {
                Id = SelectedContactDto.Id,
                Name = textBoxName.Text.Trim(),
                PhoneNumber = textBoxPhone.Text.Trim(),
                Address = textBoxAddress.Text.Trim(),
            };

            return contactDto;
        }

        private void RefreshPanel(IEnumerable<ContactDto> contactDtos = null)
        {
            flowLayoutPanelContact.Controls.Clear();
            if (contactDtos == null)
            {
                contactDtos = _contactService.GetSortedContacts();
            }

            flowLayoutPanelContact.Controls.AddRange(MapToUserControl(contactDtos));
            ResetUI();
        }

        private static UserControlContact[] MapToUserControl(IEnumerable<ContactDto> contactDtos)
        {
            List<UserControlContact> list = new();
            foreach (var contactDto in contactDtos)
            {
                var userControlContact = new UserControlContact
                {
                    Tag = contactDto
                };
                list.Add(userControlContact);
            }

            return list.ToArray();
        }

        private static string ValidateTextBox(List<TextBox> textBoxes)
        {
            var errorMessage = "";
            foreach (var textBox in textBoxes)
            {
                if (textBox.Text.Trim().Length < 1)
                {
                    errorMessage += $"Contact Details - {textBox.Name.Replace("textBox", "")} cannot be empty. {Environment.NewLine}";
                }
            }

            return errorMessage;
        }

        public void DisplayTextBoxWithContactDto(ContactDto contactDto)
        {
            if (contactDto != null)
            {
                SelectedContactDto = contactDto;
                textBoxName.Text = contactDto.Name;
                textBoxPhone.Text = contactDto.PhoneNumber;
                textBoxAddress.Text = contactDto.Address;
                buttonCreateOrEdit.Text = "Edit";
            }
        }

    }
}
