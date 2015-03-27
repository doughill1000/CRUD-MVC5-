using HazmatTracking.Models;
using HazmatTracking.Models.Hazmats;
using HazmatTracking.Models.Repository;
using System;
using System.Net;
using System.Web.Mvc;

namespace HazmatTracking.Controllers
{
    public class HazmatController : Controller
    {
        private IHazmatRepository hazmatRepository;
        private IMaterialRepository materialRepository;
        private IDestinationRepository destinationRepository;

        public HazmatController()
            :this(new HazmatRepository(), new MaterialRepository(), new DestinationRepository())
        {

        }

        public HazmatController(IHazmatRepository hazmatRepository, IMaterialRepository materialRepository, IDestinationRepository destinationRepository)
        {
            this.hazmatRepository = hazmatRepository;
            this.materialRepository = materialRepository;
            this.destinationRepository = destinationRepository;
        }

        // GET: Hazmat
        public ActionResult Index()
        {
            return View(hazmatRepository.GetTopTen());
        }

        // GET: Hazmat/Details/5 
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {  
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Hazmat hazmat = hazmatRepository.GetById(id);
            if (hazmat == null)
            {
                return HttpNotFound();
            }
            return View(hazmat);
        }

        // GET: Hazmat/Create
        public ActionResult Create()
        {
            HazmatViewModel model = new HazmatViewModel();

            model.Hazmat = new Hazmat { TransactionNum = hazmatRepository.GetNextTransNum() };

            //Get all materials for dropdownlist
            model.Materials = hazmatRepository.GetAllMaterials();

            //Get all destinations for dropdownlist
            model.Destinations = hazmatRepository.GetAllDestinations();

            return View(model);
        }

        // POST: Hazmat/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,TransactionNum,Void,Date,Initials,Material,New_Distilled,Quantity,Gallon_Pound,Destination,RequestedBy,Shift,RequiredFor,Notes")] Hazmat hazmat)
        {
            if (ModelState.IsValid)
            {
                hazmat.Id = Guid.NewGuid();
                try
                {
                    hazmatRepository.Create(hazmat);
                }
                catch (Exception ex)
                {
                    return RedirectToAction("Error");
                }
                return RedirectToAction("Index");
            }

            return View(hazmat);
        }

        // GET: Hazmat/Edit/5
        public ActionResult Edit(Guid? id)
        {
            HazmatViewModel model = new HazmatViewModel();

            //Get all materials for dropdownlist
            model.Materials = hazmatRepository.GetAllMaterials();

            //Get all destinations for dropdownlist
            model.Destinations = hazmatRepository.GetAllDestinations();

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Hazmat hazmat = hazmatRepository.GetById(id);
            if (hazmat == null)
            {
                return HttpNotFound();
            }

            model.Hazmat = hazmat;

            return View(model);
        }

        // POST: Hazmat/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,TransactionNum,Void,Date,Initials,Material,New_Distilled,Quantity,Gallon_Pound,Destination,RequestedBy,Shift,RequiredFor,Notes")] Hazmat hazmat)
        {
            if (ModelState.IsValid)    
            {
                try
                {
                    hazmatRepository.Update(hazmat);
                }
                catch (Exception ex)
                {
                    return RedirectToAction("Error");
                }
                return RedirectToAction("Index");
            }
            return View(hazmat);
        }

        // GET: Hazmat/Delete/5
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Hazmat hazmat = hazmatRepository.GetById(id);
            if (hazmat == null)
            {
                return HttpNotFound();
            }
            return View(hazmat);
        }

        // POST: Hazmat/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            hazmatRepository.Delete(id);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                hazmatRepository.Dispose();
            }
            base.Dispose(disposing);
        }

        // GET: Hazmat/Error
        public ActionResult Error()
        {
            return View();
        }

        // GET: Hazmat/CodeGuide
        public ActionResult CodeGuide()
        {
            HazmatViewModel model = new HazmatViewModel();

            model.MaterialList = materialRepository.GetAll();

            model.DestinationList = destinationRepository.GetAll();

            return View(model);
        }

    }
}
