namespace Application.Data.Repositories
{
    using System.Collections.Generic;
    using Application.Data.Entities;

    public interface IUserRepository: IBaseRepository<User>
    {
        IEnumerable<User> GetAll(Environment environment);

        User GetByUsernameAndEnvironment(string username, Environment environment);
    }
}