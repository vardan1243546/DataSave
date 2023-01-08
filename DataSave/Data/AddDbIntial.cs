using DataSave.Models;

namespace DataSave.Data
{
    public class AddDbIntial
    {
        public static void Seed(IApplicationBuilder application)
        {
            using (var servicesScope=application.ApplicationServices.CreateScope())
            {
                var context = servicesScope.ServiceProvider.GetService<UserContext>();

                context.Database.EnsureCreated();
                if (!context.Users.Any())
                {

                    context.Users.AddRange(new List<User>()
                    {

                        new User()
                        {
                            Email="Tomgmail.com",
                            Password="tomengenner12",
                            Age=23,
                        },new User()
                        {
                            Email="Bobgmail.com",
                            Password="bobengenner12",
                            Age=23,
                        },new User()
                        {
                            Email="jackgmail.com",
                            Password="jackengenner12",
                            Age=23,
                        },new User()
                        {
                            Email="jackgmail.com",
                            Password="jackengenner12",
                            Age=23,
                        },

                    });

                    context.SaveChanges();
                }
            }
        }
    }
}
