namespace GameStore.Api.Dtos;

public record GameDto(
    int Id,
    String Name,
    String Genere,
    decimal Price,
    DateOnly ReleaseDate
);