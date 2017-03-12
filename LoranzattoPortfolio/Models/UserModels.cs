using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LoranzattoPortfolio.Models
{
    /// <summary>
    /// Entity class that define which characteristics is necessary to the user 
    /// to send a message to the own application
    /// </summary>
    public class UserModels
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Required]
        public string Comments { get; set; }
        public DateTime CreationDate { get; set; }            
    }
}