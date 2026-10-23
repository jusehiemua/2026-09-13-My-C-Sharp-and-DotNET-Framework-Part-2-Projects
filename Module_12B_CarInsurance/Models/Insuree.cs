using Microsoft.EntityFrameworkCore;
namespace Module_12B_CarInsurance.Models
{
    public class Insuree
    {
        //Id, FirstName, LastName, EmailAddress, DateOfBirth, CarYear, CarMake, CarModel, DUI, SpeedingTickets, CoverageType, and Quote.
        public int Id { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string EmailAddress { get; set; }
        public required DateTime DateOfBirth { get; set; }
        public required int CarYear { get; set; }
        public required string CarMake { get; set; }
        public required string CarModel { get; set; }
        public required bool DUI { get; set; }
        public required int SpeedingTickets { get; set; }
        public required string CoverageType { get; set; }
        [Precision(18, 2)]
        public required decimal Quote { get; set; }
    }
}
