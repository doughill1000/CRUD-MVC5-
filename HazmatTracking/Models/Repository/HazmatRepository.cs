using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HazmatTracking.Models.Repository
{
    public class HazmatRepository
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

        public void Create(Hazmat hazmat)
        {
            hazmat.Id = Guid.NewGuid();

            

            
        }

        /// <summary>
        /// Gets the next Transaction number 
        /// </summary>
        public float GetNextTransNum()
        {
            float transNum = (float)(db.Hazmats.Max(t => t.TransactionNum) + 1);

            return transNum;
        }
    }
}