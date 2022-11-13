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
                    Name = "User"
                },
                new Role()
                {
                    Name = "Manager"
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
