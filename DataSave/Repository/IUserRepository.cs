using DataSave.Models;

namespace DataSave.Repository
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetAll();

        Task<User> GetFindById(int id);

        Task Add(User user);

        Task Update(User user);

        Task Save();
    }
}
