using System.Text.RegularExpressions;

namespace Domain.Validations;
/// <summary>
/// Регулярки для валидации.
/// </summary>
public static class RegexPatterns
{
    /// <summary>
    /// Телефон
    /// </summary>
    public static readonly Regex PhoneRegex = new Regex(@"^\+373[0-9]{8}$");
    /// <summary>
    /// Псевданим
    /// </summary>
    public static readonly Regex NickRegex = new Regex(@"^[a-zA-Z0-9]{2,20}$");
    /// <summary>
    /// ФИО
    /// </summary>
    public static readonly Regex NameRegex = new Regex(@"^[a-zA-Zа-яА-Я]$");
}