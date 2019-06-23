namespace Application.WebApi.Services
{
    using System.Collections.Generic;
    using Application.Logic.Managers;
    using Application.Logic.Managers.Candidates;
    using Application.WebApi.Services.Dtos;
    using Unity;
    using Application.WebApi.Services.Mappers;
    using Application.Logic;

    public class UserService : IUserService
    {
        [Dependency]
        public IUserManager UserManager { get; set; }

        [Dependency]
        public IUserContext UserContext { get; set; }

        public UserDto Add(UserCandidate candidate)
        {
            return this.UserManager.AddNew(candidate).ToUserDto(true);
        }

        public IEnumerable<UserDto> GetAll()
        {
            return this.UserManager.GetAll(this.UserContext.Environment).ToUserDto();
        }
    }
}