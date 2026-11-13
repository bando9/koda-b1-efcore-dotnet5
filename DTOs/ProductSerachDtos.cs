using System.ComponentModel.DataAnnotations;

namespace KodaStore.Api.DTOs;

public sealed class ProductSearchRequest : IValidatableObject
{
    [StringLength(60)]
    public string? Search {get; set;}
    public string? Category {get; set;}
    public decimal? MinPrice {get; set;}
    public decimal? MaxPrice {get; set;}
    [Required,StringLength(20)]
    public string Sort {get; set;} = "code_asc";
    
    [Range(1,100)]
    public int Page {get; set;} = 1;
    [Range(1,50)]
    public int PageSize {get; set;} = 10;
    
    
    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        if(MinPrice < 0)
        {
            yield return new ValidationResult("minPrice tidak boleh negatif");
        }    
        if(MaxPrice < 0)
        {
            yield return new ValidationResult("minPrice tidak boleh negatif",[nameof(MaxPrice)]);
        }

        if(MinPrice.HasValue && MaxPrice.HasValue && MinPrice > MaxPrice)
        {
            yield return new ValidationResult("MinPrice tidak boleh melebihi MaxPrice.", [nameof(MinPrice)]);
        }

        string[] allowedSort = [
            "code_asc", "code_desc",
            "name_asc", "name_desc",
            "price_asc", "price_desc",
            "stock_asc", "stock_desc",
        ];

        if(!allowedSort.Contains(Sort, StringComparer.OrdinalIgnoreCase))
        {
            yield return new ValidationResult("Sort ga ada di whilelist bang");
        }
    }
}


public sealed record ProductSearchItemResponse(
    string ProductCode,
    string Name,
    string Category,
    decimal Price,
    int Stock
);

public sealed record PagedResult<T>(
    int Page, int PageSize, long TotalCount, long TotalPages, IReadOnlyList<T> Items
);