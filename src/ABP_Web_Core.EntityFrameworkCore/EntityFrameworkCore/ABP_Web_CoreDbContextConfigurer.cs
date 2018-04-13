using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace ABP_Web_Core.EntityFrameworkCore
{
    public static class ABP_Web_CoreDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<ABP_Web_CoreDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<ABP_Web_CoreDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
