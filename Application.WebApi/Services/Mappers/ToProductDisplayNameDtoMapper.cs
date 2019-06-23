namespace Application.WebApi.Services.Mappers
{
    using System.Collections.Generic;
    using Application.Data.Entities;
    using Application.WebApi.Services.Dtos;

    public static class ToProductDisplayNameDtoMapper
    {
        public static IEnumerable<ProductDisplayNameDto> ToProductDisplayNameDto(this IEnumerable<ProductDisplayName> product)
        {
            foreach (var item in product)
            {
                yield return item.ToProductDisplayNameDto();
            }
        }

        public static ProductDisplayNameDto ToProductDisplayNameDto(this ProductDisplayName productDisplayName)
        {
            if (productDisplayName == null)
            {
                return null;
            }

            return new ProductDisplayNameDto
            {
                Id = productDisplayName.Id,
                Language = productDisplayName.Language,
                LocalDisplayName = productDisplayName.LocalDisplayName
            };
        }
    }
}