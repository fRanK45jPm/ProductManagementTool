namespace Application.Logic
{
    using Application.Data.Entities;

    public class UserContext : IUserContext
    {
        public int UserId { get; set; }

        public Environment Environment { get; set; }
    }
}
