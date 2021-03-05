using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Context
{
    public partial class AppDbContext : IdentityDbContext
    {
        protected override void OnModelCreating(ModelBuilder builder)
        {
            string adminUserId = Guid.NewGuid().ToString();
            
            builder.Entity<IdentityUser>()
                .HasData(new IdentityUser
                {
                    Id = adminUserId,
                    ConcurrencyStamp = Guid.NewGuid().ToString(),
                    Email = "ivanoff@i.ua",
                    LockoutEnabled = false,
                    EmailConfirmed = true,
                    NormalizedEmail = "IVANOFF@I.UA",
                    UserName = "ivanoff@i.ua",
                    NormalizedUserName = "IVANOFF@I.UA",
                    
                    //  77P@sswd.Net
                    PasswordHash = "AQAAAAEAACcQAAAAEJpIGeU8Raa9V3+FqO27qk4oRPnlrtd6NC1qP2MDJDguOZMu+qR3s5y4AAmJ3txDmg==", 
                    SecurityStamp= "KMTW3BACEMSXRX3TNCHPBHM3TDDH6UWU"
                });

            string adminRoleId = Guid.NewGuid().ToString();
            builder.Entity<IdentityRole>()
               .HasData(new IdentityRole
               {
                   Id = adminRoleId,
                   Name = "Administrators",
                   NormalizedName = "ADMINISTRATORS",
                   ConcurrencyStamp = Guid.NewGuid().ToString()
               });


            builder.Entity<IdentityUserRole<string>>()
                .HasData(new IdentityUserRole<string> { 
                UserId=adminUserId,
                RoleId=adminRoleId
                });
            
            base.OnModelCreating(builder);

            
        }
    }
}
