using System.ComponentModel.DataAnnotations;

namespace Task.Infrastructure
{
    public class RequiredIfAttribute : ValidationAttribute
    {
        private readonly string _propertyName;
        private readonly object _desiredValue;

        public RequiredIfAttribute(string propertyName, object desiredValue)
        {
            _propertyName = propertyName;
            _desiredValue = desiredValue;
        }

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var property = validationContext.ObjectType.GetProperty(_propertyName);
            if (property is null)
            {
                return new ValidationResult($"Unknown property: {_propertyName}");
            }

            var propertyValue = property.GetValue(validationContext.ObjectInstance);

            if (propertyValue != null && propertyValue.Equals(_desiredValue) && (value == null || string.IsNullOrWhiteSpace(value.ToString())))
            {
                return new ValidationResult(ErrorMessage);
            }

            return ValidationResult.Success;
        }
    }
 
}
