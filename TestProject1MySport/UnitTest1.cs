using Back_BookMySport.DTOS;
using Back_BookMySport.Models;
using Back_BookMySport.Repositories;
using Back_BookMySport.Services;
using Microsoft.AspNetCore.Http;
using Moq;

namespace TestProject1MySport
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCreateUserFalse()
        {
            RegisterRequestDTO registerRequestDTO = new RegisterRequestDTO()
            {
                FirstName = "Test",
                LastName = "Test",
                UserName = "Test",
                PasswordHash = "Test",
                PhoneNumber = "Test",
            };
            var repository = new Mock<IUser>();
            repository.Setup(r => r.Create(registerRequestDTO)).ReturnsAsync(false);
            
        }
        [TestMethod]
        public void TestCreateUserTrue()
        {
            RegisterRequestDTO registerRequestDTO = new RegisterRequestDTO()
            {
                FirstName = "Grégory",
                LastName = "Schoemaecker",
                UserName = "test@gmail.com",
                PasswordHash = "12345azertyA/",
                PhoneNumber = "060606060606",
            };
            var repository = new Mock<IUser>();
            repository.Setup(r => r.Create(registerRequestDTO)).ReturnsAsync(false);

        }
        [TestMethod]
        public void TestGetUser()
        {
            GetUserDTO userA = new GetUserDTO()
            {
                Id = "1",
                FirstName = "Grégory",
                LastName = "Schoemacker",
                UserName = "test@gmail.com"
            };
                GetUserDTO userB = new GetUserDTO()
               {
                    Id = "2",
                   FirstName = "Bastien",
                   LastName = "Schoemacker",
                   UserName = "test2@gmail.com"
               };
                  GetUserDTO userC = new GetUserDTO()
                  {
                      Id = "3",
                      FirstName = "Céléna",
                      LastName = "Schoemacker",
                      UserName = "test3@gmail.com"
                  };
            List<GetUserDTO> users = new List<GetUserDTO>
            {
                userA,userB, userC
            }; 
            var repository = new Mock<IUser>();
            repository.Setup(r => r.GetUser("3")).ReturnsAsync(userC);            
         
        }
    }
}