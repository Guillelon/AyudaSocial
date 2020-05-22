using Presentation.Models;
using Repositories.Models;
using Repositories.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Presentation.Controllers
{
    public class PollsController : Controller
    {
        private PollsRepositories _pollRepository;

        public PollsController()
        {
            _pollRepository = new PollsRepositories();
        }

        [HttpGet]
        public ActionResult Help()
        {
            var dto = new HelpPollDTO();
            return View(dto);
        }

        [HttpPost]
        public ActionResult Help(HelpPollDTO dto) 
        {
            dto.Poll.AgeRange = string.Join(",", dto.SelectedAgeRange);
            if (ModelState.IsValid)
            {
                
                _pollRepository.AddHelpPoll(dto.Poll);
                return View();
            }
            else
            {
                ViewBag.ErrorMessage = "Revisar los campos requeridos";
                return View(dto);
            }
        }

        [HttpGet]
        public ActionResult Volunteer()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Volunteer(VolunteerPoll poll)
        {
            if (ModelState.IsValid)
            {
                _pollRepository.AddVolunteerPoll(poll);
                return View();
            }
            else
            {
                ViewBag.ErrorMessage = "Revisar los campos requeridos";
                return View(poll);
            }
        }

        public ActionResult SuccessMessage()
        {
            return View();
        }
    }
}