using Domain.Validations.Validators;

namespace Domain.Entities.ValueObjects;

/// <summary>
/// ФИО
/// </summary>
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
    
    /// <summary>
    /// Конструктор.
    /// </summary>
    /// <param name="firstName">Имя.</param>
    /// <param name="lastName">Фамилия.</param>
    /// <param name="fatherName">Отчество.</param>
    public FullName(string firstName, string lastName, string fatherName)
    {
        FirstName = FullNameValidation(firstName, nameof(firstName));
        LastName = FullNameValidation(lastName, nameof(lastName));
        FatherName = FullNameValidation(fatherName, nameof(fatherName));
    }
    
    private string FullNameValidation(string value, string paramName)
    {
        var nameValidator = new FullNameValidator(paramName);
        var nameValidationResult = nameValidator.Validate(value);
        return value;
    }
}