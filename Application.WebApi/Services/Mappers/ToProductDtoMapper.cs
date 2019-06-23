namespace Application.WebApi.Services.Mappers
{
    using Application.WebApi.Services.Dtos;
    using Application.Data.Entities;
    using System.Collections.Generic;

    public static class ToProductDtoMapper
    {
        public static IEnumerable<ProductDto> ToProductDto(this IEnumerable<Product> product)
        {
            foreach (var item in product)
            {
                yield return item.ToProductDto();
            }
        }

        public static ProductDto ToProductDto(this Product product)
        {
            if (product == null)
            {
                return null;
            }

            var productDisplayName = new List<ProductDisplayNameDto>();

            if (product.DisplayName != null &&
                product.DisplayName.Count > 0)
            {
                foreach (var item in product.DisplayName)
                {
                    productDisplayName.Add(new ProductDisplayNameDto
                    {
                        Id = item.Id,
                        Language = item.Language,
                        LocalDisplayName = item.LocalDisplayName,
                    });
                }
            }

            return new ProductDto
            {
                Id = product.Id,
                Name = product.Name,
                Environment = product.Environment,
                SKU = product.SKU,
                DisplayName = productDisplayName
            };
        }
    }
}