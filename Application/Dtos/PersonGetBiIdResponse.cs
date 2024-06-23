namespace Application.Dtos;

/// <summary>
/// Получение Person по идентификатору
/// </summary>
public class PersonGetBiIdResponse : BasePersonDto
{
    /// <summary>
    /// Идентификатор Person
    /// </summary>
    public Guid Id { get; init; }
}