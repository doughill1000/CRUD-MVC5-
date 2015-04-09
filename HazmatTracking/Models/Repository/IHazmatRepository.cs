using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace HazmatTracking.Models.Repository
{
    public interface IHazmatRepository
    {
        /// <summary>
        /// Create Hazmat transaction
        /// </summary>
        /// <param name="hazmat">The hazmat transaction to be created</param>
        void Create(Hazmat hazmat);

        /// <summary>
        /// Deletes a transaction
        /// </summary>
        /// <param name="id"></param>
        void Delete(Guid? id);

        /// <summary>
        /// Manages class disposal
        /// </summary>
        void Dispose();

        /// <summary>
        /// Gets all Hazmat transactions
        /// </summary>
        /// <returns></returns>
        List<Hazmat> GetAll();

        /// <summary>
        /// Gets top ten Hazmat transactions
        /// </summary>
        /// <returns></returns>

        List<Hazmat> GetTopTen();
        /// <summary>
        /// Gets a Hazmat transaction by ID
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        Hazmat GetById(Guid? Id);

        /// <summary>
        /// Updates a Hazmat transaction
        /// </summary>
        /// <param name="hazmat"></param>
        void Update(Hazmat hazmat);

        /// <summary>
        /// Gets the next transaction number when creating a new transaction
        /// </summary>
        /// <returns></returns>
        float GetNextTransNum();

        /// <summary>
        /// Gets a list of materials for dropdowns
        /// </summary>
        /// <returns></returns>
        List<SelectListItem> GetAllMaterials();

        /// <summary>
        /// Gets a list of locations for dropdowns
        /// </summary>
        /// <returns></returns>
        List<SelectListItem> GetAllDestinations();

    }
}