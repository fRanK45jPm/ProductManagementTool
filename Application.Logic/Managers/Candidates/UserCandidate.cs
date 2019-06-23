namespace Application.Logic.Managers.Candidates
{
    using System.ComponentModel.DataAnnotations;
    using Application.Data.Entities;

    public class UserCandidate
    {
        [Required]
        public string Username { get; set; }
    }
}
