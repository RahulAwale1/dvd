using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using DvdRentalApplication.Models;
using DvdRentalApplication.Models.ViewModels;

namespace DvdRentalApplication.DBContext
{
    public class ApplicationDBContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
        public DbSet<DvdRentalApplication.Models.UserRegisterModel> UserRegisterModel { get; set; }
        public DbSet<DvdRentalApplication.Models.ViewModels.UserDetailsViewModel> UserDetailsViewModel { get; set; }

    }
}
