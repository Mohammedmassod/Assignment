using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Xunit;
using Assignment.Controllers;
using Assignment.Models;
using Assignment.Service;

namespace Assignment.Test.Controllers
{
    public class EmployeesControllerTests
    {
        private readonly EmployeesController _controller;
        private readonly Mock<IEmployeeService> _mockEmployeeService;

        public EmployeesControllerTests()
        {
            _mockEmployeeService = new Mock<IEmployeeService>();
            _controller = new EmployeesController(_mockEmployeeService.Object);
        }

        [Fact]
        public async Task GetEmployees_ReturnsOkResult()
        {
            // Arrange
            var employees = new List<Employee>
            {
                new Employee { Id = 1, Name = "John" },
                new Employee { Id = 2, Name = "Jane" }
            };

            _mockEmployeeService.Setup(service => service.GetEmployees())
                .ReturnsAsync(employees);

            // Act
            var result = await _controller.GetEmployees();

            // Assert
            Assert.IsType<OkObjectResult>(result.Result);
        }

        [Fact]
        public async Task GetEmployees_ReturnsEmployees()
        {
            // Arrange
            var employees = new List<Employee>
            {
                new Employee { Id = 1, Name = "John" },
                new Employee { Id = 2, Name = "Jane" }
            };

            _mockEmployeeService.Setup(service => service.GetEmployees())
                .ReturnsAsync(employees);

            // Act
            var result = await _controller.GetEmployees();
            var okResult = Assert.IsType<OkObjectResult>(result.Result);
            var returnedEmployees = Assert.IsAssignableFrom<IEnumerable<Employee>>(okResult.Value);

            // Assert
            Assert.Equal(2, returnedEmployees.Count());
            Assert.Equal("John", returnedEmployees.First().Name);
            Assert.Equal("Jane", returnedEmployees.Last().Name);
        }

        // ... Additional tests for other controller actions
    }
}