using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace questionnaire.Data.Models
{
    public class Users
    {
        public int Id { get; set; }
        string UserName { get; set; }
        string Password { get; set; }
        public byte[] Salt { get; set; }
        public DateTime DateOfJoing { get; set; }
    }
}
