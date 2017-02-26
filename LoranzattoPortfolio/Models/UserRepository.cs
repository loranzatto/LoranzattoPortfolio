using LoranzattoPortfolio.App_Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LoranzattoPortfolio.Models
{
    public class UserRepository : IUserRepository
    {
        private LoranzattoDataContext DataContext;

        public UserRepository()
        {
            DataContext = new LoranzattoDataContext();
        }

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

