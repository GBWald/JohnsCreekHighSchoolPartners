using JohnsCreekHighSchoolPartners.Domain.Enums;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;

namespace JohnsCreekHighSchoolPartners.Domain.Model
{
    public class Partner
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string? Name { get; set; }

        [Required]
        [StringLength(200)]
        public string? Description { get; set; }

        public DateTime? SigningDate { get; set; }

        public DateTime? ClosingDate { get; set; }

        [Required]
        [StringLength(100)]
        public string? ContactPrimary { get; set; }

        [Required]
        [StringLength(100)]
        public string? ContactSecondary { get; set; }

        public Category Category { get; set; }





    }
}
