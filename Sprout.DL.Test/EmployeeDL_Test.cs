using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Sprout.DL.Repo;
using Sprout.Entities;
using AutoMapper;
using System.Collections.Generic;
using Sprout.DTO;
using System.Linq;

namespace Sprout.DL.Test
{
    [TestClass]
    public class EmployeeDL_Test
    {
        private Mock<IRepository<Employee>> _mockEmployeeRepository;
        private Mock<IMapper> _mockMapper;

        [TestInitialize]
        public void Initialize()
        {
            _mockEmployeeRepository = new Mock<IRepository<Employee>>();
            _mockMapper = new Mock<IMapper>();
        }

        [TestMethod]
        public void EmployeeDL_GetAll_Return_List()
        {
            //arrange
            var employees = new List<Employee> {
                new Employee { Id = 1, FirstName = "John" , LastName = "Smith"},
                new Employee { Id = 2, FirstName = "Mark" , LastName = "Stan"},
                new Employee { Id = 3, FirstName = "Eric" , LastName = "Lee"},
                new Employee { Id = 4, FirstName = "Grace", LastName = "Rock" }
            };
            var expectedValue = new List<EmployeeDto> {
                new EmployeeDto { Id = 1, FirstName = "John" , LastName = "Smith"},
                new EmployeeDto { Id = 2, FirstName = "Mark" , LastName = "Stan"},
                new EmployeeDto { Id = 3, FirstName = "Eric" , LastName = "Lee"},
                new EmployeeDto { Id = 4, FirstName = "Grace", LastName = "Rock" }
            };
            var dl = new EmployeeDL(_mockEmployeeRepository.Object, _mockMapper.Object);
            _mockEmployeeRepository.Setup(x => x.All()).Returns(employees);
            _mockMapper.Setup(x => x.Map<IEnumerable<EmployeeDto>>(employees)).Returns(expectedValue);

            //act
            var result = dl.GetAll();
            
            //assert
            Assert.AreEqual(expectedValue.Count, result.Count());
            
        }

        [TestMethod]
        public void EmployeeDL_GetAll_Return_Empty()
        {
            //arrange
            List<Employee> employees = null;
            List<EmployeeDto> expectedValue = null;
            var dl = new EmployeeDL(_mockEmployeeRepository.Object, _mockMapper.Object);
            _mockEmployeeRepository.Setup(x => x.All()).Returns((List<Employee>)null);
            _mockMapper.Setup(x => x.Map<IEnumerable<EmployeeDto>>(employees)).Returns(expectedValue);

            //act
            var result = dl.GetAll();

            //assert
            Assert.AreEqual(expectedValue, result);

        }
    }
}
