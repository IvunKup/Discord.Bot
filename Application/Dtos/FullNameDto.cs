namespace Application.Dtos;

public class FullNameDto
{
    /// <summary>
    /// Имя
    /// </summary>
    public string FirstName { get; init; }
    
    /// <summary>
    /// Фамилия
    /// </summary>
    public string LastName { get; init; }
    
    /// <summary>
    /// Отчество
    /// </summary>
    public string? FatherName { get; init;}
}