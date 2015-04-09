using System.Collections.Generic;
using System.Linq;

namespace HazmatTracking.Models.Repository
{
    public class MaterialRepository : IMaterialRepository
    {
        /// <summary>
        /// Database used to manage Hazmat transactions
        /// </summary>
        private HazmatEntities db;

        /// <summary>
        /// New Hazmat Repository
        /// </summary>
        public MaterialRepository()
        {
            db = new HazmatEntities();

            db.Database.Log = (s => System.Diagnostics.Debug.WriteLine(s));
        }

        /// <summary>
        /// Returns a list of all materials
        /// </summary>
        /// <returns></returns>
        public List<Material> GetAll()
        {
            List<Material> materials = db.Materials
                .OrderBy(m => m.Name)
                .ToList();

            return materials;
        }
    }
}