namespace KodaStore.Api.Repositories;

public enum ProductSort
{
    CodeAsc,
    CodeDesc,
    NameAsc,
    NameDesc,
    PriceAsc,
    PriceDesc,
    StockAsc,
    StockDesc,
}

public sealed record ProductSearchCriteria(
    string? Search,
    long? CategoryId,
    decimal? MinPrice,
    decimal? MaxPrice,
    ProductSort Sort,
    int Page,
    int PageSize
);

 