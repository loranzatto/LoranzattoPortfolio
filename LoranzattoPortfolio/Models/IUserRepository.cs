using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoranzattoPortfolio.Models
{
    /// <summary>
    /// Interface class to make a bridge between Controller and Model classes
    /// </summary>
    interface IUserRepository
    {
        void ToInsertUser(UserModels userModel);
    }
}
