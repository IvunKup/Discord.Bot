namespace Domain.Entities;

/// <summary>
/// Базовый класс для Person.
/// </summary>
public abstract class BaseEntity
{
    /// <summary>
    /// ID пользователя.
    /// </summary>
    public Guid Id { get; set; }
}