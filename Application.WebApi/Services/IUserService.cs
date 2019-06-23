namespace Application.WebApi.Services
{
    using System.Collections.Generic;
    using Application.Logic.Managers.Candidates;
    using Application.WebApi.Services.Dtos;

    public interface IUserService
    {
        IEnumerable<UserDto> GetAll();

        UserDto Add(UserCandidate candidate);
    }
}