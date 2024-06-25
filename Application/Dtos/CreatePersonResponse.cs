namespace Application.Dtos;

/// <summary>
/// Ответ создания Person
/// </summary>
public class CreatePersonResponse : BasePersonDto
{
    /// <summary>
    /// Идентификатор Person
    /// </summary>
    public Guid Id { get; init; }
}