using DataSave.Data;
using DataSave.Models;
using Microsoft.EntityFrameworkCore;

namespace DataSave.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly UserContext userContext;

        public UserRepository(UserContext userContext)
        {
            this.userContext = userContext;
        }
        public async Task Add(User user)
        {
            await Save();
            await userContext.AddAsync(user);
        }

        public async Task<IEnumerable<User>> GetAll()
        {
            await Save();
            return await userContext.Users.ToListAsync();
        }

        public async Task<User> GetFindById(int id)
        {
            await Save();
            return await userContext.Users.FirstOrDefaultAsync(a=>a.Id==id);
        }

        public async Task Save()
        {
            await userContext.SaveChangesAsync();
        }

        public async Task Update(User user)
        {
               await Save();
              userContext.Users.Update(user);
        }
    }
}
