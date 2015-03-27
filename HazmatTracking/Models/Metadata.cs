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

        [Required(ErrorMessage = "Required")]
        [DisplayName("Date")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public Nullable<System.DateTime> Date { get; set; }

        [DisplayName("Initials")]
        [MaxLength(2, ErrorMessage = "Maximum length is 2 characters.")]
        public string Initials { get; set; }

        [Required(ErrorMessage = "Required")]
        [DisplayName("Material")]
        public string Material { get; set; }

        [Required(ErrorMessage = "Required")]
        [DisplayName("New/Distilled")]  
        public string New_Distilled { get; set; }

        [Required(ErrorMessage = "Required")]
        [DisplayName("Quantity")]
        [Range(0, float.MaxValue, ErrorMessage = "Please enter a valid quantity")]
        public Nullable<double> Quantity { get; set; }

        [Required(ErrorMessage = "Required")]
        [DisplayName("Gallon/Pound")]
        public string Gallon_Pound { get; set; }

        [Required(ErrorMessage = "Required")]
        [DisplayName("Destination")]
        public string Destination { get; set; }

        [DisplayName("Requested By")]
        [MaxLength(2, ErrorMessage = "Maximum length is 2 characters.")]
        public string RequestedBy { get; set; }

        [DisplayName("Shift")]
        [MaxLength(10, ErrorMessage = "Maximum length is 10 characters.")] 
        public string Shift { get; set; }

        [DisplayName("Required For")]
        public string RequiredFor { get; set; }

        [DisplayName("Notes")]
        [MaxLength(255, ErrorMessage = "Maximum length is 255 characters.")] 
        public string Notes { get; set; }
    }
}