using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoranzattoPortfolio.Models
{
    interface IUserRepository
    {
        void ToInsertUser(UserModels userModel);
    }
}
