using Domain.Primitives.Enum;

namespace Application.Dtos;

/// <summary>
/// Базовый дто
/// </summary>
public class BasePersonDto
{
    /// <summary>
    /// ФИО
    /// </summary>
    public FullNameDto FullNameDto { get; init; }
    
    /// <summary>
    /// Пол
    /// </summary>
    public Gender Gender { get; init; }
    
    /// <summary>
    /// Дата рождения
    /// </summary>
    public DateTime BirthDay { get; init; }
    
    /// <summary>
    /// Номер телефона
    /// </summary>
    public string PhoneNumber { get; init; }
    
    /// <summary>
    /// Ник Дискорда
    /// </summary>
    public string DiscordNick { get; init; }
}