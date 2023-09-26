using System.ComponentModel.DataAnnotations;

namespace Task.Infrastructure
{
    public class MaxFileSizeAttribute : ValidationAttribute
    {
        private readonly long _maxFileSize;

        public MaxFileSizeAttribute(long maxFileSize)
        {
            _maxFileSize = maxFileSize;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value is IFormFile file)
            {
                if (file.Length > _maxFileSize)
                {
                    return new ValidationResult($"The file size should not exceed {_maxFileSize} bytes.");
                }
            }

            return ValidationResult.Success;
        }
    }


}
