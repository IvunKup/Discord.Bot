namespace Application.Dtos;

/// <summary>
/// Получение Person
/// </summary>
public class PersonGetAllResponse : BasePersonDto
{
    /// <summary>
    /// Идентификатор Person
    /// </summary>
    public Guid Id { get; init; }
}