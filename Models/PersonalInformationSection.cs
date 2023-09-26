using System.ComponentModel;

namespace Task.Models
{
    public class PersonalInformationSection: Section
    {
        public Question FirstName { get; set; }

        public Question LastName { get; set; } 

        public Question Email { get; set; }

        [DisplayName("Phone (without dial code)")]
        public Question Phone { get; set; }

        public Question Nationality { get; set; }

        public Question CurrentResdience { get; set; }

        [DisplayName("ID Number")]
        public Question IdNumber {  get; set; }

        [DisplayName("Date of Birth")]
        public Question DateOfBirth { get; set; }

        public Question Gender { get; set; }
    }

     
}
