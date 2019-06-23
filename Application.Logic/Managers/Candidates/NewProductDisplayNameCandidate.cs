namespace Application.Logic.Managers.Candidates
{
    using System.ComponentModel.DataAnnotations;
    using Application.Data.Entities;

    public class NewProductDisplayNameCandidate
    {
        [Required]
        public int ProductId { get; set; }

        [Required]
        public string LocaleName { get; set; }

        [Required]
        public SupportLanguage Language { get; set; }
    }
}