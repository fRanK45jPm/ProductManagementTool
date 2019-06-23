namespace Application.WebApi.Services.Dtos
{
    using Application.Data.Entities;

    public class UserDto
    {
        public int Id { get; set; }

        public string EnvironmentName { get; set; }

        public string Username { get; set; }

        public string ApiToken { get; set; }
    }
}