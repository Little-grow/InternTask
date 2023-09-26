using System.ComponentModel.DataAnnotations;
using Task.Infrastructure;

namespace Task.Models
{
    public class UploadCoverLetterSection
    {
        [Required]
        [DataType(DataType.Upload)]
        [Display(Name = "Cover Image")]
        [FileExtensions(Extensions = "jpg,jpeg,png")]
        [MaxFileSize(1000_000)]
        [ImageAspectRatio(16, 9)]
        public IFormFile? CoverImage { get; set; }
    }

     
}
