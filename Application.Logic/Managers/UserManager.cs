namespace Application.Logic.Managers
{
    using System;
    using System.Collections.Generic;
    using Application.Data.Entities;
    using Application.Data.Repositories;
    using Application.Logic.Exceptions;
    using Application.Logic.Managers.Candidates;
    using Unity;
    using System.Linq;

    public class UserManager : BaseManager, IUserManager
    {
        [Dependency]
        public IUserContext UserContext { get; set; }

        [Dependency]
        public IUserRepository UserRepository { get; set; }

        public User AddNew(UserCandidate candidate)
        {
            var existing = this.UserRepository.GetByUsernameAndEnvironment(candidate.Username, this.UserContext.Environment);
            if (existing != null)
            {
                throw new UserAlreadyExistsException();
            }

            var entity = this.UserRepository.Create();
            entity.Username = candidate.Username;
            entity.ApiToken = Guid.NewGuid().ToString();
            entity.IsSuperUser = false;
            entity.Environment = this.UserContext.Environment;

            this.Save();

            return entity;
        }

        public IEnumerable<User> GetAll(Data.Entities.Environment environment)
        {
            return this.UserRepository.GetAll(environment);
        }

        public User GetUseyByToken(string token)
        {
            return this.UserRepository.Query().Where(m => m.ApiToken == token).FirstOrDefault();
        }
    }
}
