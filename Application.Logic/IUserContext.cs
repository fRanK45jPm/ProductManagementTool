namespace Application.Logic
{
    using Application.Data.Entities;

    public interface IUserContext
    {
        int UserId { get; set; }

        Environment Environment { get; set; }
    }
}
