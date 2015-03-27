using System.Collections.Generic;
using System.Web.Mvc;

namespace HazmatTracking.Models.Hazmats
{
    public class HazmatViewModel
    {
        public Hazmat Hazmat { get; set; }

        public List<Hazmat> Hazmats { get; set; }

        //Used for Code Guide
        public List<Material> MaterialList { get; set; }

        //Used for Code Guide
        public List<Destination> DestinationList { get; set; }

        //Used for Dropdowns on Create and Edit
        public List<SelectListItem> Materials { get; set; }

        //Used for Dropdowns on Create and Edit
        public List<SelectListItem> Destinations { get; set; }

        //Used for storing the next transaction number for creating a new transation
        public float TransactionNum { get; set; }

        //Used for New and Distilled DropDown
        public IEnumerable<SelectListItem> New_Distilled
        {
            get
            {
                return new[]
                {
                    new SelectListItem {Value = "New", Text = "New"},
                    new SelectListItem {Value = "Distilled", Text = "Distilled"}
                };
            }
        }

        //Used for Gallon and Pound DropDown
        public IEnumerable<SelectListItem> Gallon_Pound
        {
            get
            {
                return new[]
                {
                    new SelectListItem {Value = "Lbs", Text = "Lbs"},
                    new SelectListItem {Value = "Gal", Text = "Gal"}
                };
            }
        }

        //Used for Required For Dropdown
        public IEnumerable<SelectListItem> RequiredFor
        {
            get
            {
                return new[]
                {
                    new SelectListItem {Value = "Thinning", Text = "Thinning"},
                    new SelectListItem {Value = "Washup", Text = "Washup"}
                };
            }
        }
    }
}