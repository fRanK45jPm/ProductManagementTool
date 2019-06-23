namespace Application.Logic.Managers
{
    using System.Collections.Generic;
    using Application.Data.Entities;
    using Application.Logic.Managers.Candidates;

    public interface IUserManager
    {
        User AddNew(UserCandidate candidate);

        IEnumerable<User> GetAll(Environment environment);

        User GetUseyByToken(string token);
    }
}
