using AutoMapper;
using PhoneBook.Core.Models;
using PhoneBook.Core.Utils;
using PhoneBook.Data;
using PhoneBook.Data.Entities;
using System.Collections.Generic;
using System.Linq;

namespace PhoneBook.Core
{
    public class ContactService : IContactService
    {
        private readonly IRepository<Contact> _contactRepository;

        public ContactService(IRepository<Contact> contactRepository)
        {
            _contactRepository = contactRepository;
        }


        public ContactDto GetContactById(int id)
        {
            return _contactRepository.FindById(id).ToContactDto();
        }

        public ContactDto Create(ContactDto contactDto)
        {
            return _contactRepository.Create(contactDto.ToContact()).ToContactDto();
        }

        public bool Delete(ContactDto contactDto)
        {
            contactDto.IsDeleted = true;
            return _contactRepository.Update(contactDto.ToContact());
        }

        public IEnumerable<ContactDto> GetSortedContacts()
        {
            return _contactRepository.GetAll()
                .Where(c => c.IsDeleted == false)
                .OrderBy(c => c.Name)
                .ToList()
                .Select(c => c.ToContactDto())
                .ToList();
        }

        public IEnumerable<ContactDto> Search(string keyword)
        {
            var lowerCasedKeyword = keyword.Trim().ToLower();
            return GetSortedContacts().Where(c => c.Name.ToLower().Contains(lowerCasedKeyword)
            || c.Address.ToLower().Contains(lowerCasedKeyword)
            || c.PhoneNumber.ToLower().Contains(lowerCasedKeyword))
                .ToList();
        }

        public bool Update(ContactDto contactDto)
        {
            return _contactRepository.Update(contactDto.ToContact());
        }

        
    }
}