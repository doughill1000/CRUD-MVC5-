using HazmatTracking.Models;
using HazmatTracking.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HazmatTracking.Controllers
{
    public class HazmatAPIController : ApiController
    {
        private IHazmatRepository hazmatRepository;

        public HazmatAPIController()
            : this(new HazmatRepository())
        {
        }
        public HazmatAPIController(IHazmatRepository hazmatRepository)
        {
            this.hazmatRepository = hazmatRepository;
        }

        public IEnumerable<Hazmat> Get()
        {
            var results = hazmatRepository.GetTopTen()
                            .OrderByDescending(h => h.Id)
                            .ToList();

            return results;
        }
    }
}
