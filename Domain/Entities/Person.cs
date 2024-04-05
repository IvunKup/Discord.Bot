using Domain.Entities.ValueObjects;
using Domain.Primitieves.Enum;

namespace Domain.Entities;

public class Person : BasePerson
{
    /// <summary>
    /// 
    /// </summary>
    public FullName FullName { get; set; }
    /// <summary>
    /// Пол
    /// </summary>
    public Gender Gender { get; set; }
    /// <summary>
    /// Дата рождения
    /// </summary>
    public DateTime Birthday { get; set; }
    /// <summary>
    /// Номер телефона
    /// </summary>
    public string PhoneNumber { get; set; }
    /// <summary>
    /// Ник Дискорда
    /// </summary>
    public string DiscordNick { get; set; }
}