﻿using Domain.Entities.ValueObjects;
using Domain.Primitives.Enum;
using Domain.Validations.Validators;

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
        Gender = gender;
        BirthDay = birthDay;
        PhoneNumber = PhoneValidation(phoneNumber, nameof(phoneNumber));
        DiscordNick = discordNick;
    }

    //NOPE Проверить, вернулись ли ошибки после валидации.
    private string PhoneValidation(string phoneNumber, string paramName)
    {
        var phoneValidator = new PhoneValidator(paramName);
        var phoneValidationResult = phoneValidator.Validate(phoneNumber);
        return phoneNumber;
    }
}