namespace Application.WebApi.Services.Dtos
{
    using System.Collections.Generic;
    using Application.Data.Entities;

    public class ProductDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string SKU { get; set; }

        public Environment Environment { get; set; }

        public string EnvironmentName
        {
            get
            {
                return this.Environment.ToString();
            }
        }

        public IEnumerable<ProductDisplayNameDto> DisplayName { get; set; }
    }
}