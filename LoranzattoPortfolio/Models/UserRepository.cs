using LoranzattoPortfolio.App_Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LoranzattoPortfolio.Models
{
    /// <summary>
    /// Repository class to make the interface between Model and Controller classes
    /// </summary>
    public class UserRepository : IUserRepository
    {
        private LoranzattoDataContext DataContext;

        public UserRepository()
        {
            DataContext = new LoranzattoDataContext();
        }
        /// <summary>
        /// Method to insert a new user message data. 
        /// The method receive an Object UserModel from Controller class through the interface IUserRepository
        /// and persist the data in teh SQL Database.s
        /// </summary>
        /// <param name="UserModel"></param>
        public void ToInsertUser(UserModels UserModel)
        {
        try
        {
            var UserData = new OurUser
            {
                Id = UserModel.Id,
                Name = UserModel.Name,
                Email = UserModel.Email,
                Comments = UserModel.Comments,
                CreationDate = DateTime.Now
            };
            DataContext.OurUsers.InsertOnSubmit(UserData);
            DataContext.SubmitChanges();
        }
        catch (Exception e)
        {
            throw e;
        }

        }
    }
}

