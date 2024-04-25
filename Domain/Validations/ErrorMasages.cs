namespace Domain.Validations;

public abstract class ErrorMasages
{
    /// <summary>
    /// Сообщение для неверного номера телефона.
    /// </summary>
    public const string PhoneFormat = "Вы неверно ввели номер телефона.";
    /// <summary>
    /// Значение отсутствует.
    /// </summary>
    public const string IsNull = "{0} является null.";
    /// <summary>
    /// Значение не введено.
    /// </summary>
    public const string IsEmpty = "{0} пуста.";
    /// <summary>
    /// Неверные символы в ФИО.
    /// </summary>
    public const string NameGramer = "Вы ввели недопустимые символы в {nameof(FullName)}.";
    /// <summary>
    /// Не выбран вариант ответа.
    /// </summary>
    public const string EnumIsNone = "Вы ввели недопустимые символы в имени.";
    
}