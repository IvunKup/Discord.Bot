﻿namespace Application.Dtos;

public class BaseDto
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
}