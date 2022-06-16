using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using Entities;
using Xunit;

namespace Tests
{
    public class RepositoryTests
    {
        [Fact]
        public void GetRepositoryDataTest()
        {
            //Arrange
            Repository repository;

            //Act
            repository = new();

            //Assert
            Assert.NotNull(repository);
        }
        [Fact]
        public void GetAllPersonsAndTestIfDataReturns()
        {
            //Arrange
            Repository repo = new();

            //Act
            List<Person> people = repo.GetAllPersons();

            //Assert
            Assert.True(people.Count > 0);
        }
    }
}
