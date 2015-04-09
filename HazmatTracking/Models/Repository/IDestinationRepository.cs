using System.Collections.Generic;

namespace HazmatTracking.Models.Repository
{
    public interface IDestinationRepository
    {
        /// <summary>
        /// Returns a list of all destinations
        /// </summary>
        /// <returns></returns>
        List<Destination> GetAll();
    }
}
