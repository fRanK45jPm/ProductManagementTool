namespace Application.WebApi.Services.Dtos
{
    using Application.Data.Entities;

    public class ProductDisplayNameDto
    {
        public int Id { get; set; }

        public SupportLanguage Language { get; set; }

        public string LocalDisplayName { get; set; }

        public string LanguageName
        {
            get
            {
                return this.Language.ToString();
            }
        }
    }
}