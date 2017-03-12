using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using LoranzattoPortfolio.Models;

namespace LoranzattoPortfolio.Controllers
{
    /// <summary>
    /// Controller class that receive the data from the View class and send to 
    /// the Model class to be persisted in the database.
    /// </summary>
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
        /// <summary>
        /// Method to be render the page with the clean fields.
        /// </summary>
        /// <returns></returns>
        public ActionResult Insert()
        {
            return View("Insert",new UserModels());
        }
        /// <summary>
        /// Get the UserModel Entity object from the View page that use Razor and 
        /// send to the Model Class through the Repository class, after that send the message 
        /// that the operation executed with succes and render the View page again.
        /// </summary>
        /// <param name="userModel"></param>
        /// <returns></returns>
        [HttpPost, ActionName("Insert")]
        public ActionResult Insert(UserModels userModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _repository.ToInsertUser(userModel);
                    ViewBag.StatusMessage = Resources.Global.ResourceManager.GetString("SuccessMessage");
                    ModelState.Clear();
                    return View("Insert");
                }
            }
            catch (DataException)
            {
                ModelState.AddModelError(String.Empty, Resources.Global.ResourceManager.GetString("SuccessMessage"));

            }
            return View(userModel);
        }
    }
}