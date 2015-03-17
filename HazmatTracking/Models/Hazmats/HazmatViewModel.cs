using System.Collections.Generic;
using System.Web.Mvc;

namespace HazmatTracking.Models.Hazmats
{
    public class HazmatViewModel
    {
        public Hazmat Hazmat { get; set; }

        public List<Hazmat> Hazmats { get; set; }

        public List<SelectListItem> Materials { get; set; }

        public List<SelectListItem> Locations { get; set; }

        //Used for getting the next transaction number for creating a new transation
        public float TransactionNum { get; set; }
    }
}