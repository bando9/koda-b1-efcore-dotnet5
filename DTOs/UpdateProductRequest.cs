namespace KodaStore.Api.DTOs;

public record UpdateProductRequest(
    string Name,
    decimal Price,
    int Stock,
    long CategoryId,
    string Description
);