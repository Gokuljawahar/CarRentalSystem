using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace CarRentalSystem.Models
{
    public class CarModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int car_no { get; set; }
        public DateTime date_of_booking { get; set; }
        
        public string from_location { get; set; }

        public string to_location { get; set; }
        public string booked_name { get; set; }
        public long booked_phone_number { get; set; }
    }
}
