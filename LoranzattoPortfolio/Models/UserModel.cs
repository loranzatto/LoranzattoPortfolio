using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LoranzattoPortfolio.Models
{
    public class UserModel
    {
        
        public int Id
        {
            get
            {
                return Id;
            }

            set
            {
                Id = value;
            }
        }

        public string Name
        {
            get
            {
                return Name;
            }

            set
            {
                Name = value;
            }
        }

        public string Email
        {
            get
            {
                return Email;
            }

            set
            {
                Email = value;
            }
        }

        public DateTime CreationDate
        {
            get
            {
                return CreationDate;
            }

            set
            {
                CreationDate = value;
            }
        }
    }
}