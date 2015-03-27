using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HazmatTracking.Models.Repository
{
    public class DestinationRepository : IDestinationRepository
    {
        /// <summary>
        /// Database used to manage Hazmat transactions
        /// </summary>
        private HazmatEntities db;

        /// <summary>
        /// New Hazmat Repository
        /// </summary>
        public DestinationRepository()
        {
            db = new HazmatEntities();

            db.Database.Log = (s => System.Diagnostics.Debug.WriteLine(s));
        }

        /// <summary>
        /// Returns a list of all materials
        /// </summary>
        /// <returns></returns>
        public List<Destination> GetAll()
        {
            List<Destination> destinations = db.Destinations
                .OrderBy(m => m.Name)
                .ToList();

            return destinations;
        }
    }
}