using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using LoranzattoPortfolio.Models;

namespace LoranzattoPortfolio.Controllers
{
    public class UserController : Controller
    {
        private IUserRepository _repository;
        public UserController():this(new UserRepository())
        {

        }
        public UserController(UserRepository repository)
        {
            _repository = repository;
        }
        
        public ActionResult Insert()
        {
            return View("Insert",new UserModels());
        }
        [HttpPost, ActionName("Insert")]
        public ActionResult Insert(UserModels userModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _repository.ToInsertUser(userModel);
                    ViewBag.StatusMessage = "Comment sent with success!";
                    ModelState.Clear();
                    return View("Insert");
                }
            }
            catch (DataException)
            {
                ModelState.AddModelError("", "Insert Operation Can't Executed!");

            }
            return View(userModel);
        }
    }
}