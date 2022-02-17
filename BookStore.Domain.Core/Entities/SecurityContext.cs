using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace BookStore.Domain.Core.Entities
{
    public class SecurityContext: IdentityDbContext<IdentityUser>
    {
   
            public SecurityContext()
            {

            }
            public SecurityContext(DbContextOptions<SecurityContext> options)
                : base(options)
            {
                Database.EnsureCreated();
            }
        
    }

   
}

