using Microsoft.EntityFrameworkCore;

using System;
using System.Linq;
using CarRentalSystem.Controllers;
using CarRentalSystem.Models;
using Microsoft.AspNetCore.Mvc;
using NUnit;
using NUnit.Framework.Legacy;


namespace CarRentalSystem.test
{
    public class Tests
    {
        private CarDbContext _context;
        private CarController _controller;

        [SetUp]
        public void Setup()
        {
            var options = new DbContextOptionsBuilder<CarDbContext>()
                .UseInMemoryDatabase(databaseName: "cardatabase.db")
                .Options;

            _context = new CarDbContext(options);
            _controller = new CarController(_context);
        }

      
        

        [Test]
        public void CreateCar_CarCreatedSuccessfully()
        {
            // Arrange
            var car = new CarModel
            {
                car_no = 123,
                date_of_booking = DateTime.Now,
                from_location = "Location A",
                to_location = "Location B",
                booked_name = "John Doe",
                booked_phone_number = 1234567890
            };

            // Act
            var createResult = _controller.CreateCar(car).Result as CreatedAtActionResult;
            var createdCar = createResult?.Value as CarModel;

            // Assert
            ClassicAssert.IsNotNull(createResult);
            ClassicAssert.AreEqual(201, createResult.StatusCode);
            ClassicAssert.IsNotNull(createdCar);
            ClassicAssert.AreEqual(car.car_no, createdCar.car_no);
            ClassicAssert.AreEqual(car.from_location, createdCar.from_location);

            // Additional assertion: Check if the created car exists in the database
            var savedCar = _context.Cars.FirstOrDefault(c => c.Id == createdCar.Id);
            ClassicAssert.IsNotNull(savedCar);
            ClassicAssert.AreEqual(car.car_no, savedCar.car_no);
            ClassicAssert.AreEqual(car.from_location, savedCar.from_location);
        }

    }
}

