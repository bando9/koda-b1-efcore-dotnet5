using KodaStore.Api.DTOs;

namespace KodaStore.Api.Services;

public interface IProductQueryService
{
    Task<PagedResult<ProductSearchItemResponse>> SearchAsync(ProductSearchRequest request, CancellationToken cancellationToken);
}

