using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace questionnaire.Data.Models
{
    public class Choices
    {
        public int Id { get; set; }
        public string Choice { get; set; }

        // Nevigator Properties
        public int QuestionId { get; set; }
        public Questions question { get; set; }
    }
}
