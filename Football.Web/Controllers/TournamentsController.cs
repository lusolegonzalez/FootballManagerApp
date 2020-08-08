using Football.Data.Abstract;
using Football.Model.Entities;
using Football.Web.Services;
using Football.Web.Services.Profile;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;

namespace Football.Web.Controllers
{
    public class TournamentsController : Controller
    {
        private readonly IStringLocalizer<SharedResources> _sharedLocalizer;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ProfileManager _profileManager;

        public TournamentsController(
            IStringLocalizer<SharedResources> sharedLocalizer,
            UserManager<ApplicationUser> userManager,
            IUnitOfWork unitOfWork,
            ProfileManager profileManager)
        {
            _sharedLocalizer = sharedLocalizer;
            _userManager = userManager;
            _unitOfWork = unitOfWork;
            _profileManager = profileManager;
        }

        // GET: Tournament
        public ActionResult Index()
        {
            return View();
        }

        //// GET: Tournament/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        //// GET: Tournament/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: Tournament/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(IFormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add insert logic here

        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: Tournament/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: Tournament/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add update logic here

        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: Tournament/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: Tournament/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add delete logic here

        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}