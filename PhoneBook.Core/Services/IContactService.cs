using PhoneBook.Core.Models;
using System.Collections.Generic;

namespace PhoneBook.Core
{
    public interface IContactService
    {
        ContactDto GetContactById(int id);

        ContactDto Create(ContactDto contact);

        bool Update(ContactDto contact);

        bool Delete(ContactDto contact);

        IEnumerable<ContactDto> Search(string keyword);

        IEnumerable<ContactDto> GetSortedContacts();
    }
}