namespace Application.Data.Entities
{
    using System.ComponentModel.DataAnnotations;

    public class User : BaseEntity
    {
        [Required]
        public virtual Environment Environment { get; set; }

        [Required, StringLength(50)]
        public virtual string Username { get; set; }

        [Required]
        public virtual bool IsSuperUser { get; set; }

        [Required]
        public virtual string ApiToken { get; set; }
    }
}