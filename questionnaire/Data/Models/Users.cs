using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace questionnaire.Data.Models
{
    public class Users
    {
        [Column("UserId")]
        public int Id { get; set; }

        [Required(ErrorMessage = "UserName is required")]
        string UserName { get; set; }

        [Required(ErrorMessage = "Password is required")]
        string Password { get; set; }
        public DateTime DateAdd { get; set; }
        public DateTime DateLogin { get; set; }
    }
}
