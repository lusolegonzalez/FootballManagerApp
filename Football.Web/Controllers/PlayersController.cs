using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using AutoMapper;
using Football.Data.Abstract;
using Football.Model.Entities;
using Football.Web.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;

namespace Football.Web.Controllers
{
    public class PlayersController : Controller
    {
        private readonly IStringLocalizer<SharedResources> _sharedLocalizer;
        private readonly IUnitOfWork _unitOfWork;
        private readonly UserManager<ApplicationUser> _userManager;

        public PlayersController(
            IStringLocalizer<SharedResources> sharedLocalizer,
            IUnitOfWork unitOfWork,
            UserManager<ApplicationUser> userManager)
        {
            _sharedLocalizer = sharedLocalizer;
            _unitOfWork = unitOfWork;
            _userManager = userManager;
        }

        // GET: Players
        public ActionResult Index()
        {
            var players = _unitOfWork.Players.GetAll();
            IEnumerable<PlayerViewModel> playersVm = Mapper.Map<IEnumerable<Player>, IEnumerable<PlayerViewModel>>(players);

            return View(playersVm);
        }

        // GET: Players/5
        public ActionResult Details(int id)
        {
            var player = _unitOfWork.Players.Get(id);
            PlayerViewModel playerVm = Mapper.Map<Player, PlayerViewModel>(player);
            return View(playerVm);
        }

        // GET: Players/Create
        public ActionResult Create()
        {
            //PrepareViewBags();
            var player = new PlayerViewModel();
            return View(player);
        }

        // GET: Players/Edit/5
        public ActionResult Edit(int id)
        {
            //PrepareViewBags();
            var player = _unitOfWork.Players.Get(id);
            var playerVm = Mapper.Map<Player, PlayerViewModel>(player);
            return View(playerVm);
        }

        // GET: Players/Delete/5
        public ActionResult Delete(int id)
        {
            var player = _unitOfWork.Players.Get(id);
            var playerVm = Mapper.Map<Player, PlayerViewModel>(player);
            return View("DeleteConfirmed", playerVm);
        }

        // POST: Players/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PlayerViewModel playerVm)
        {
            try
            {
                var player = new Player
                {
                    FirstName = playerVm.FirstName,
                    LastName = playerVm.LastName,
                    Dni = playerVm.Document,
                    BirthDate = playerVm.BirthDate
                    //Address = BuildAddress(playerVm)
                };
                _unitOfWork.Players.Add(player);
                _unitOfWork.Complete();

                TempData["StatusMessage"] = $"{_sharedLocalizer["Player Created"]}";
                return RedirectToAction(nameof(Index));

            }
            catch (Exception e)
            {
                HandleExceptions(e);
                //PrepareViewBags();
                return RedirectToAction(nameof(Index));
            }
        }

        // POST: Players/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, PlayerViewModel playerVm)
        {
            try
            {
                var player = _unitOfWork.Players.Get(id);

                if (player == null)
                    return NotFound();

                player.FirstName = playerVm.FirstName;
                player.LastName = playerVm.LastName;
                player.Dni = playerVm.Document;
                player.BirthDate = playerVm.BirthDate;
                //player.Address = BuildAddress(playerVm);
                //player.Contacts = GetContacts(playerVm.Contacts);

                _unitOfWork.Complete();

                TempData["StatusMessage"] = $"{_sharedLocalizer["Player Updated"]}";
                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {
                HandleExceptions(e);
                //PrepareViewBags();
                return RedirectToAction(nameof(Index));
            }
        }
        
        // POST: Players/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            try
            {
                var player = _unitOfWork.Players.Get(id);

                if (player == null)
                    return NotFound();

                _unitOfWork.Players.Remove(player);
                _unitOfWork.Complete();

                TempData["StatusMessage"] = $"{_sharedLocalizer["Player Deleted"]}";
                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {
                HandleExceptions(e);
                return RedirectToAction(nameof(Index));
            }
        }

        private void HandleExceptions(Exception e)
        {
            var error = "Error! " + e.Message;

            if (e.InnerException != null && e.InnerException is SqlException sqlException)
            {
                if (sqlException.Number == 2601)
                    error = $"Error! {_sharedLocalizer["Player already registered"]}";
            }

            TempData["StatusMessage"] = error;
        }
    }
}