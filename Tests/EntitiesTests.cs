using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Xunit;

namespace Tests
{
    public class EntitiesTests
    {
        [Fact]
        public void CorrectInitialization_ContactInformation()
        {
            //Arrange
            int id = 1;
            string mail = "philip@gmail.com";
            string phoneNumber = "53253213";

            //Act
            ContactInformation contactInformation = new(id, mail, phoneNumber);

            //Assert
            Assert.True(contactInformation.Id > 0);
            Assert.Contains("@", contactInformation.Mail);
            Assert.True(contactInformation.PhoneNumber.Length < 7);
        }
        [Fact]
        public void Mutation_ContactInformation()
        {
            //Arrange
            int id = 1;
            string mail = "philip@gmail.com";
            string phoneNumber = "53253213";

            //Act
            ContactInformation contactInformation = new(id, mail, phoneNumber);
            contactInformation.Mail = "trumpfanclub@gmail.com";
            contactInformation.PhoneNumber = "95832021";

            //Assert
            Assert.Equal("trumpfanclub@gmail.com", contactInformation.Mail);
            Assert.Equal("95832021", contactInformation.PhoneNumber);

        }
    }
}
