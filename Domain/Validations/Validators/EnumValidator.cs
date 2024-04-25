namespace Domain.Validations.Validators;

public class EnumValidator<TEnum> where TEnum : Enum
{
    private readonly TEnum[] _defaultValues;

    public EnumValidator(TEnum[] defaultValues)
    {
        _defaultValues = defaultValues;
    }

    public bool Validate(TEnum value)
    {
        foreach (var defaultValue in _defaultValues)
        {
            if (value.Equals(defaultValue))
            {
                return true;
            }
        }
        return false;
    }
}