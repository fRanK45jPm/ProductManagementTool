namespace Application.WebApi.Services.Mappers
{
    using System.Collections.Generic;
    using Application.Data.Entities;
    using Application.WebApi.Services.Dtos;

    public static class ToUserDtoMapper
    {
        public static IEnumerable<UserDto> ToUserDto(this IEnumerable<User> user)
        {
            foreach (var item in user)
            {
                yield return item.ToUserDto();
            }
        }

        public static UserDto ToUserDto(this User user)
        {
            if (user == null)
            {
                return null;
            }

            return new UserDto
            {
                Id = user.Id,
                Username = user.Username,
                EnvironmentName = user.Environment.ToString(),
            };
        }

        public static UserDto ToUserDto(this User user, bool showToken)
        {
            if (user == null)
            {
                return null;
            }

            return new UserDto
            {
                Id = user.Id,
                Username = user.Username,
                EnvironmentName = user.Environment.ToString(),
                ApiToken = showToken == true ? user.ApiToken.ToString() : "*********"
            };
        }
    }
}