using KodaStore.Api.Models;

namespace KodaStore.Api.DTOs;

public sealed record CategoryResponse(
    long Id,
    string Name)
{
    public static CategoryResponse FromModel(Category category) =>
        new(category.Id, category.Name);
}