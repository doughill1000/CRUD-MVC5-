using HazmatTracking.Models.Utility;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;

namespace HazmatTracking.Models.Repository
{
    public class HazmatRepository : IHazmatRepository
    {
        /// <summary>
        /// Database used to manage Hazmat transactions
        /// </summary>
        private HazmatEntities db;

        /// <summary>
        /// New Hazmat Repository
        /// </summary>
        public HazmatRepository()
        {
            db = new HazmatEntities();

            db.Database.Log = (s => System.Diagnostics.Debug.WriteLine(s));
        }

        /// <summary>
        /// Creates a new Hazmat transaction
        /// </summary>
        /// <param name="hazmat"></param>
        public void Create(Hazmat hazmat)
        {
            hazmat.Id = Guid.NewGuid();

            db.Hazmats.Add(hazmat);

            db.SaveChanges();
        }

        /// <summary>
        /// Deletes transation with specified ID
        /// </summary>
        /// <param name="id"></param>
        public void Delete(Guid? id)
        {
            Hazmat hazmat = db.Hazmats.Find(id);

            db.Hazmats.Remove(hazmat);

            db.SaveChanges();
        }

        /// <summary>
        /// Manages disposal
        /// </summary>
        public void Dispose()
        {
            db.Dispose();
        }

        /// <summary>
        /// Returns a list of all transactions
        /// </summary>
        /// <returns></returns>
        public List<Hazmat> GetAll()
        {
            List<Hazmat> hazmats = db.Hazmats
                .OrderBy(h => h.TransactionNum)
                .ToList();

            return hazmats;
        }

        /// <summary>
        /// Returns a list of the last ten transactions
        /// </summary>
        /// <returns></returns>
        public List<Hazmat> GetTopTen()
        {
            List<Hazmat> hazmats = db.Hazmats
                .Take(10)
                .OrderByDescending(h => h.TransactionNum)
                .ToList();

            return hazmats;
        }

        /// <summary>
        /// Updates a transaction
        /// </summary>
        /// <param name="hazmat"></param>
        public void Update(Hazmat hazmat)
        {
            db.Entry(hazmat).State = EntityState.Modified;

            db.SaveChanges();
        }
        /// <summary>
        /// Gets a Hazmat transaction by ID
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public Hazmat GetById(Guid? Id)
        {
            Hazmat hazmat = db.Hazmats.Find(Id);

            return hazmat;
        }

        /// <summary>
        /// Gets the next Transaction number 
        /// </summary>
        public float GetNextTransNum()
        {
            float fTransNum = 0;
            double? transNum = (db.Hazmats.Max(t => (double?)t.TransactionNum));
            if (transNum != null)
            {
                fTransNum = (float)transNum;
            }

            return fTransNum + 1;
        }

        /// <summary>
        /// Gets a list of all the Materials
        /// </summary>
        /// <returns>List of Materials</returns>
        public List<SelectListItem> GetAllMaterials()
        {
            var materials = db.Materials
                .ToList()
                .Select(s => new SelectListItem
                {
                    Value = s.Name.ConvertToTitleCase(),
                    Text = s.Name.ConvertToTitleCase()

                }).OrderBy(s => s.Value).ToList();

            return materials;

            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets a list of all the Destinations
        /// </summary>
        /// <returns>List of Destinations</returns>
        public List<SelectListItem> GetAllDestinations()
        {
            var destinations = db.Destinations
            .ToList()
            .Select(s => new SelectListItem
            {
                Value = s.Name.ConvertToTitleCase(),
                Text = s.Name.ConvertToTitleCase()

            }).OrderBy(s => s.Value).ToList();

            return destinations;

            throw new NotImplementedException();
        }

    }
}