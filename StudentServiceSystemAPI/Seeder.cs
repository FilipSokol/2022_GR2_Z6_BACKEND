using Microsoft.EntityFrameworkCore;
using StudentServiceSystemAPI.Data;
using StudentServiceSystemAPI.Entities;

namespace StudentServiceSystemAPI
{
    public class Seeder
    {
        private readonly ApplicationDbContext context;
        public Seeder(ApplicationDbContext context)
        {
            this.context = context;
        }

        public void Seed()
        {
            if (this.context.Database.CanConnect())
            {
                var pendingMigrations = this.context.Database.GetPendingMigrations();

                if (pendingMigrations != null && pendingMigrations.Any())
                {
                    this.context.Database.Migrate();
                }

                if (!this.context.Roles.Any())
                {
                    var roles = GetRoles();

                    this.context.Roles.AddRange(roles);
                    this.context.SaveChanges();
                }
            }
        }


        private IEnumerable<Role> GetRoles()
        {
            var roles = new List<Role>()
            {
                new Role()
                {
                    Name = "Student"
                },
                new Role()
                {
                    Name = "Teacher"
                },
                new Role()
                {
                    Name = "Admin"
                }
            };

            return roles;

        }
    }
}
