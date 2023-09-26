using System.ComponentModel.DataAnnotations;

namespace Task.Infrastructure
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
    public class ImageAspectRatioAttribute : ValidationAttribute
    {
        private readonly double width;
        private readonly double height;

        public ImageAspectRatioAttribute(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value is IFormFile file)
            {
                try
                {
                    using (var stream = file.OpenReadStream())
                    using (var image = Image.Load(stream))
                    {
                        double imageAspectRatio = (double)image.Width / image.Height;

                        if (Math.Abs(imageAspectRatio - (width / height)) > 0.01)
                        {
                            // Return a warning message instead of a validation error
                            return new ValidationResult($"Warning: The image aspect ratio is recommended to be {width}:{height}");
                        }
                    }
                }
                catch (Exception)
                {
                    return ValidationResult.Success; // Treat image loading errors as success (no aspect ratio check performed)
                }
            }

            return ValidationResult.Success;
        }
    }
}
