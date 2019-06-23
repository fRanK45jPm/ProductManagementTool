namespace Application.Logic.Managers.Candidates
{
    using System.ComponentModel.DataAnnotations;

    public class EditProductDisplayNameCandidate : NewProductDisplayNameCandidate
    {
        [Required]
        public int Id { get; set; }
    }
}
