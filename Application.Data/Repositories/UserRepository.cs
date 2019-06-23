namespace Application.Data.Repositories
{
    using System.Collections.Generic;
    using Application.Data.Entities;
    using System.Linq;

    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public IEnumerable<User> GetAll(Environment environment)
        {
            return this.Query().Where(m => m.Environment == environment);
        }

        public User GetByUsernameAndEnvironment(string username, Environment environment)
        {
            return this.Query().Where(m => m.Username == username && m.Environment == environment).FirstOrDefault();
        }
    }
}
