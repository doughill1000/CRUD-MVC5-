using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HazmatTracking.Models.Repository
{
    public interface IMaterialRepository
    {
        /// <summary>
        /// Returns a list of all materials
        /// </summary>
        /// <returns></returns>
        List<Material> GetAll();
    }
}