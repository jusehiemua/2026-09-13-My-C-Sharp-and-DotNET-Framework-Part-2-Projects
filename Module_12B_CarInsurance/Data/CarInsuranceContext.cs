using Microsoft.EntityFrameworkCore;
using Module_12B_CarInsurance.Models;


namespace Module_12B_CarInsurance.Data
{
    public class CarInsuranceContext : DbContext
    {
        public CarInsuranceContext(DbContextOptions<CarInsuranceContext> options)
            : base(options)
        {
        }

        public DbSet<Insuree> Insurees { get; set; }
    }
}


