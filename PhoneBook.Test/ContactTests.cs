using PhoneBook.Core;
using System;
using Xunit;

namespace PhoneBook.Test
{
    public class ContactTests
    {
        private readonly IContactService _sut;

        public ContactTests()
        {
            //_sut = new Contactser
        }

        [Fact]
        public void ShouldSaveContact_WhenContactNoExist()
        {
            // Arrange 
            //var contact = new Contact()
            //{
            //    Id = 1,
            //    Name = "Kelly",
            //    Address = "Unit-123, Address 1, 1234567, Singapore",
            //    PhoneNumber = "88775588",
            //    IsDeleted = true
            //};

            //// Act 
            //_sut.Create(contact);

            // Assert  
            //Assert.
        }
    }
}
