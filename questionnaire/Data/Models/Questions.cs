using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace questionnaire.Data.Models
{
    public class Questions
    {
        public int Id { get; set; }
        public string Question { get; set; }

        // Nevigetor Properties
        public List<Choices> Choices { get; set; }
    }
}
