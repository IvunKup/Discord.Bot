using Domain.Entities.ValueObjects;
using Domain.Primitives.Enum;
using Domain.Validations.Validators;
using FluentValidation.Validators;

namespace Domain.Entities;

/// <summary>
/// Макет человека.
/// </summary>
public class Person : BaseEntity
{
    /// <summary>
    /// ФИО
    /// </summary>
    public FullName FullName { get; set; }
    
    /// <summary>
    /// Пол
    /// </summary>
    public Gender Gender { get; set; }
    
    /// <summary>
    /// Дата рождения
    /// </summary>
    public DateTime BirthDay { get; set; }
    
    /// <summary>
    /// Номер телефона
    /// </summary>
    public string PhoneNumber { get; set; }
    
    /// <summary>
    /// Ник Дискорда
    /// </summary>
    public string DiscordNick { get; set; }
    
    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="fullName">ФИО.</param>
    /// <param name="gender">Пол.</param>
    /// <param name="birthDay">Дата рождения.</param>
    /// <param name="phoneNumber">Номер телефона.</param>
    /// <param name="discordNick">Ник в Дискорде.</param>
    public Person(FullName fullName, Gender gender, DateTime birthDay, string phoneNumber, string discordNick)
    {
        FullName = fullName;
        Gender = EnumValidation(gender, nameof(gender));
        BirthDay = BirthDayValidation(birthDay, nameof(birthDay));
        PhoneNumber = PhoneValidation(phoneNumber, nameof(phoneNumber));
        DiscordNick = DiscordNickValidation(discordNick, nameof(discordNick));
    }

    private string PhoneValidation(string phoneNumber, string paramName)
    {
        var phoneValidator = new PhoneValidator(paramName);
        var phoneValidationResult = phoneValidator.Validate(phoneNumber);
        return phoneNumber;
    }
    private string DiscordNickValidation(string discordNick, string paramName)
    {
        var discordValidator = new DiscordNickValidator(paramName);
        var discordValidationResult = discordValidator.Validate(discordNick);
        return discordNick;
    }
    private DateTime BirthDayValidation(DateTime birthDay, string paramName)
    {
        var dateTimeValidator = new DateTimeValidator(paramName);
        var birthDayValidationResult = dateTimeValidator.Validate(birthDay);
        return birthDay;
    }
    private Gender EnumValidation(Gender gender, string paramName)
    {
        var genderValidator = new EnumValidator<Gender>(paramName);
        var genderValidationResult = genderValidator.Validate(gender);
        return gender;
    }
}