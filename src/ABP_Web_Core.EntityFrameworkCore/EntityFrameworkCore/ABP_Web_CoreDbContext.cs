using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using ABP_Web_Core.Authorization.Roles;
using ABP_Web_Core.Authorization.Users;
using ABP_Web_Core.MultiTenancy;

namespace ABP_Web_Core.EntityFrameworkCore
{
    public class ABP_Web_CoreDbContext : AbpZeroDbContext<Tenant, Role, User, ABP_Web_CoreDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public ABP_Web_CoreDbContext(DbContextOptions<ABP_Web_CoreDbContext> options)
            : base(options)
        {
        }
    }
}
