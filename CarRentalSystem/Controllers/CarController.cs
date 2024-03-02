using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using CarRentalSystem.Models;

namespace CarRentalSystem.Controllers
{
    [ApiController]
    [Route("api/Cars")]
    public class CarController : ControllerBase
    {
        private readonly CarDbContext _context;

        public CarController(CarDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<CarModel>> GetCars()
        {
            return _context.Cars.ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<CarModel> GetCarById(int id)
        {
            var car = _context.Cars.Find(id);

            if (car == null)
                return NotFound();

            return car;
        }

        [HttpPost]
        public ActionResult<CarModel> CreateCar(CarModel car)
        {
            _context.Cars.Add(car);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetCarById), new { id = car.Id }, car);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateCar(int id, CarModel updatedCar)
        {
            var car = _context.Cars.Find(id);

            if (car == null)
                return NotFound();

            car.car_no = updatedCar.car_no;
            car.date_of_booking = updatedCar.date_of_booking;
            car.from_location = updatedCar.from_location;
            car.to_location = updatedCar.to_location;
            car.booked_name = updatedCar.booked_name;
            car.booked_phone_number = updatedCar.booked_phone_number;

            _context.SaveChanges();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCar(int id)
        {
            var car = _context.Cars.Find(id);

            if (car == null)
                return NotFound();

            _context.Cars.Remove(car);
            _context.SaveChanges();

            return NoContent();
        }
    }
}


