namespace Application.Data.Entities
{
    public class ProductDisplayName : BaseEntity
    {
        public virtual Product Product { get; set; }

        public virtual string LocalDisplayName { get; set; }

        public virtual SupportLanguage Language { get; set; }
    }
}
