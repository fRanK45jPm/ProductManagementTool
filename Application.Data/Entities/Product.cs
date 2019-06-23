namespace Application.Data.Entities
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Product : BaseEntity
    {
        [Required]
        public virtual string Name { get; set; }

        [Required]
        public virtual string SKU { get; set; }

        [Required]
        public virtual Environment Environment { get; set; }

        public virtual IList<ProductDisplayName> DisplayName { get; set; }
    }
}
