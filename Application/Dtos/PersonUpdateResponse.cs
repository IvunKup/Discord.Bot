namespace Application.Dtos;

/// <summary>
/// Ответ обновления Person
/// </summary>
public class PersonUpdateResponse : BasePersonDto
{
    /// <summary>
    /// Идентификатор Person
    /// </summary>
    public Guid Id { get; init; }
}