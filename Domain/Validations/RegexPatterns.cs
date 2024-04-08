using System.Text.RegularExpressions;

namespace Domain.Validations;

public class RegexPatterns
{
    public readonly Regex PhoneRegex = new Regex(@"^\+373[0-9]{8}$");
    public readonly Regex NickRegex = new Regex(@"^[a-zA-Z0-9]{2,20}$");
    public readonly Regex NameRegex = new Regex(@"^[a-zA-Zа-яА-Я]$");
}