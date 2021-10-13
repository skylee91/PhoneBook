using PhoneBook.Core.Models;
using PhoneBook.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.Core.Utils
{
    public static class ExtensionMethods
    {
        public static ContactDto ToContactDto(this Contact contact)
        {
            return DtoEntityMapping.Mapper.Map<ContactDto>(contact);
        }

        public static Contact ToContact(this ContactDto contactDto)
        {
            return DtoEntityMapping.Mapper.Map<Contact>(contactDto);
        }
    }
}
