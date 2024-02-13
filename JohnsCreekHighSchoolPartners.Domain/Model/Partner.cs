using JohnsCreekHighSchoolPartners.Domain.Enums;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;

namespace JohnsCreekHighSchoolPartners.Domain.Model
{

    //model class (where we define all of our fields)
    public class Partner
    {

        //int will be auto incremented
        public int Id { get; set; }

        //the name is required and has a max length of 100 characters
        [Required]
        [StringLength(100)]
        public string? Name { get; set; }

        //the description is also required and has a max length of 200 characters
        [Required]
        [StringLength(200)]
        public string? Description { get; set; }

        //the signing date will give the user a calendar to choose the date
        public DateTime? SigningDate { get; set; }

        //the closing date will give the user a calendar to choose the date
        public DateTime? ClosingDate { get; set; }

        //the primary contact is required and max 100 characters
        [Required]
        [StringLength(100)]
        public string? ContactPrimary { get; set; }

        //the secondary contact is required with 100 max characters
        [Required]
        [StringLength(100)]
        public string? ContactSecondary { get; set; }

        //category is the type of buisness they run and user gets to choose between options
        [Required]
        public Category Category { get; set; }





    }
}

