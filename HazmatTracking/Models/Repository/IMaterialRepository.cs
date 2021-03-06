﻿using System.Collections.Generic;

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