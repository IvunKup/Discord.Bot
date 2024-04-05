namespace Domain.Entities.ValueObjects;

public class FullName
{
    /// <summary>
    /// Имя
    /// </summary>
    public string FirstName { get; set; }
    
    /// <summary>
    /// Фамилия
    /// </summary>
    public string LastName { get; set; }
    
    /// <summary>
    /// Отчество
    /// </summary>
    public string? FatherName { get; set;}
}