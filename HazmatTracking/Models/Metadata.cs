using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HazmatTracking.Models
{
    /// <summary>
    /// Metadata for Hazmats
    /// </summary>
    public class HazmatMetadata
    {
        [Required(ErrorMessage="Required")]
        [DisplayName("Trans#")]
        [Range(0, float.MaxValue, ErrorMessage = "Please enter a valid Trans#")]
        public Nullable<double> TransactionNum { get; set; }

        public Nullable<bool> Void { get; set; }

        [DisplayName("Date")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy, hh:mm}", ApplyFormatInEditMode = true)]
        public Nullable<System.DateTime> Date { get; set; }

        [Required(ErrorMessage = "Required")]
        [DisplayName("Initials")]
        [MaxLength(2, ErrorMessage = "Maximum length is 2 characters.")]
        public string Initials { get; set; }

        [Required(ErrorMessage = "Required")]
        [DisplayName("Material")]
        [MaxLength(50, ErrorMessage = "Maximum length is 50 characters.")]
        public string Material { get; set; }

        [Required(ErrorMessage = "Required")]
        [DisplayName("New/Distilled/Dark")]
        [MaxLength(10, ErrorMessage = "Maximum length is 10 characters.")]    
        public string New_Distilled_Dark { get; set; }

        [Required(ErrorMessage = "Required")]
        [DisplayName("Quantity")]
        [Range(0, float.MaxValue, ErrorMessage = "Please enter a valid quantity")]
        public Nullable<double> Quantity { get; set; }

        [Required(ErrorMessage = "Required")]
        [DisplayName("Gallon/Pound")]
        [MaxLength(10, ErrorMessage = "Maximum length is 10 characters.")] 
        public string Gallon_Pound { get; set; }

        [Required(ErrorMessage = "Required")]
        [DisplayName("Destination")]
        [MaxLength(50, ErrorMessage = "Maximum length is 50 characters.")]
        public string Destination { get; set; }

        [Required(ErrorMessage = "Required")]
        [DisplayName("Requested By")]
        [MaxLength(2, ErrorMessage = "Maximum length is 2 characters.")]
        public string RequestedBy { get; set; }

        [Required(ErrorMessage = "Required")]
        [DisplayName("Shift")]
        [MaxLength(10, ErrorMessage = "Maximum length is 10 characters.")] 
        public string Shift { get; set; }

        [Required(ErrorMessage = "Required")]
        [DisplayName("Required For")]
        [MaxLength(15, ErrorMessage = "Maximum length is 15 characters.")] 
        public string RequiredFor { get; set; }

        [DisplayName("Notes")]
        [MaxLength(255, ErrorMessage = "Maximum length is 255 characters.")] 
        public string Notes { get; set; }
    }
}